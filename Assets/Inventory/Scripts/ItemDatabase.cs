using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    private Item itemPrefab;

    void Awake(){
        if (FindObjectsOfType<ItemDatabase>().Length > 1){
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        //BuildItemDatabase();
    }


    public Item GetItem(int id){
        return items.Find((item) => item.id == id);
        
    }

    public Item GetItem(string title){
        return items.Find(item => item.title == title);
    }

    void BuildItemDatabase(){
        Item item1 = Instantiate(itemPrefab) as Item;

        item1.id = 1;
        item1.title = "Diamond Axe";
        item1.description = "An axe made of diamond";
        item1.stats = new Dictionary<string, int>{{"Power", 15}, {"Defense", 7}};
        item1.icon = Resources.Load<Sprite>("Items/Sprites/" + item1.title);
        
        Item item2 = Instantiate(itemPrefab) as Item;
        item2.id = 2;
        item2.title = "Diamond Axe";
        item2.description = "An axe made of diamond";
        item2.stats = new Dictionary<string, int>{{"Power", 15}, {"Defense", 7}};
        item2.icon = Resources.Load<Sprite>("Items/Sprites/" + item1.title);

        Item item3 = Instantiate(itemPrefab) as Item;
        item3.id = 3;
        item3.title = "Diamond Axe";
        item3.description = "An axe made of diamond";
        item3.stats = new Dictionary<string, int>{{"Power", 15}, {"Defense", 7}};
        item3.icon = Resources.Load<Sprite>("Items/Sprites/" + item1.title);

        items = new List<Item>(){
            item1, item2, item3
        };
        
        // items = new List<Item>(){
        //     new Item(1, "Diamond Axe", "An axe made of diamond.",
        //     new Dictionary<string, int>{{"Power", 15}, {"Defense", 7}}),
        //     new Item(2, "Diamond Ore", "A shiny diamond.",
        //     new Dictionary<string, int>{{"Value", 2500}}),
        //     new Item(3, "Iron Axe", "An axe made of Iron.",
        //     new Dictionary<string, int>{{"Power", 8}, {"Defense", 10}})
        // };

    }
}
