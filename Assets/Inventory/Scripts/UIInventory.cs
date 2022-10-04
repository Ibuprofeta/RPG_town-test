using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField]
    private SlotPanel[] slotPanels;

    public void Awake(){
        if (FindObjectsOfType<UIInventory>().Length > 1){
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

        this.gameObject.SetActive(false);
    }

    public void AddItemToUI (Item item){
        foreach (SlotPanel sp in slotPanels){
            if (sp.ContainsEmptySlot()){
                sp.AddNewItem(item);
                break;
            }
        }
    }
}
