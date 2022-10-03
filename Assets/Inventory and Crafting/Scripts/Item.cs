using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Item : MonoBehaviour
{
    public int id;
    public string title;
    public string description;
    public Sprite icon;
    public List<string> keyStats;
    public List<int> valueStats;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    public Item (int id, string title, string description, 
    Dictionary<string, int> stats){
        this.id = id;
        this.title = title;
        this.description = description;
        this.stats = stats;
        this.icon = Resources.Load<Sprite>("Items/Sprites/" + title);
    }

    public Item(Item item){
        this.id = item.id;
        this.title = item.title;
        this.description = item.description;
        this.icon = item.icon;
        this.stats = item.stats;
        this.icon = Resources.Load<Sprite>("Items/Sprites/" + title);
    }

    public void UpdateDictionary(){
        for (int i = 0; i < keyStats.Count; i++){
            this.stats.Add(keyStats[i], valueStats[i]);
        }
    }
}
