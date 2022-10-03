using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIItem : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler,
IPointerExitHandler
{
    public Item item;
    private Image spriteImage;
    private UIItem selectedItem;

    public bool craftingSlot = false;
    private CraftingSlots craftingSlots;

    public bool craftingResultSlot;

    private Tooltip tooltip;

    private GameObject replaceItem;

    private ItemDatabase itemDatabase;

    private void Awake(){
        selectedItem = GameObject.Find("SelectedItem").GetComponent<UIItem>();
        spriteImage = GetComponent<Image>();
 
        craftingSlots = FindObjectOfType<CraftingSlots>();
        UpdateItem(null);

        tooltip = FindObjectOfType<Tooltip>();

        replaceItem = GameObject.FindGameObjectWithTag("ReplaceItem");

        itemDatabase = FindObjectOfType<ItemDatabase>();
    }

    public void UpdateItem(Item item){
        this.item = item;
        if (this.item != null){
            spriteImage.color = Color.white;
            spriteImage.sprite = item.icon;
        } else {
            spriteImage.color = Color.clear;
            spriteImage.sprite = null;
        }
        if (craftingSlot){
            craftingSlots.UpdateRecipe();
        }
    }

    public void OnPointerDown (PointerEventData eventData){
        if (this.item != null){
            UICraftResult craftResult = GetComponent<UICraftResult>();
            if (craftResult != null && this.item != null && selectedItem.item == null){
                craftResult.PickItem();
                selectedItem.UpdateItem(this.item);
                craftResult.ClearSlots();
            } else if (!craftingSlot){
                if (selectedItem.item != null){
                    //Item clone = Instantiate(selectedItem.item) as Item;
                    //Item clone = new Item(selectedItem.item);
                    //Item clone = replaceItem.AddComponent<Item>();
                    //clone.CopyItem(selectedItem.item);

                    int id = selectedItem.item.id;
                    selectedItem.UpdateItem(this.item);
                    UpdateItem(itemDatabase.GetItem(id));
                    // Destroy(clone.GetComponent<Item>());
                } else {
                    selectedItem.UpdateItem(this.item);
                    UpdateItem(null);
                }
            } else if (craftingSlot){
                if (selectedItem.item != null){
                    int id = selectedItem.item.id;
                    selectedItem.UpdateItem(this.item);
                    UpdateItem(itemDatabase.GetItem(id));
                } else {
                    selectedItem.UpdateItem(this.item);
                    UpdateItem(null);
                }
            }
        } else if (selectedItem.item != null && !craftingResultSlot){
            UpdateItem(selectedItem.item);
            selectedItem.UpdateItem(null);
        }
    }

    public void OnPointerEnter(PointerEventData eventData){
        if (this.item != null){
            tooltip.GenerateTooltip(item);
        }
    }

    public void OnPointerExit(PointerEventData eventData){
        tooltip.gameObject.SetActive(false);
    }
}
