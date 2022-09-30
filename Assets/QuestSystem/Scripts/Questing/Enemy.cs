using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem{ 
        
    public class Enemy : MonoBehaviour
    {
        private int enemyID;

        void Start(){
            enemyID = 0;
        }

        public void Die(){
            EventController.EnemyDied(enemyID);
        }
    }
}