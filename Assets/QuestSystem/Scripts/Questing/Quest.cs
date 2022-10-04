using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem{ 
   public class Quest : MonoBehaviour
   {
      public string questName;
      public string description;
      public Goal goal;
      public bool completed;
      public List<string> itemRewards;

      public string slug;

      private Inventory inventory;

      private void Start(){
         inventory = FindObjectOfType<Inventory>();
      }      

      public virtual void Complete(){
         Debug.Log("Quest completed!");
         EventController.QuestCompleted(this);
         GrantReward();
      }

      public void GrantReward(){
         Debug.Log("Turning in quest... granting reward");
         foreach(string item in itemRewards){
            Debug.Log("Rewarded with: " + item);
            inventory.GiveItem(item);
         }
      }
   }
}