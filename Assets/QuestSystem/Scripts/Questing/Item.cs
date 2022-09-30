using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem{ 
    public class Item : MonoBehaviour
    {
        private int itemID;
        
        void Start(){
            this.itemID = 0;
        }

        public void Get(){
            EventController.ItemFound(itemID);
        }
    }
}