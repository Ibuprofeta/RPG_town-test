using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace QuestSystem{    
    public class CollectionGoal : Goal
    {  
        public int itemID;

        public CollectionGoal(int amountNeeded, int itemID, Quest quest){
            countCurrent = 0;
            countNeeded = amountNeeded;
            completed = false;
            this.itemID = itemID;
            this.quest = quest;
            EventController.OnItemFound += ItemFound;
        }

        void ItemFound(int itemID){
            if (this.itemID == itemID){
                Increment();
            } else {
                Debug.Log("already completed");
            }
        }
    }
}