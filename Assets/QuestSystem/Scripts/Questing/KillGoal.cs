using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem{ 
    public class KillGoal : Goal
    {  
        public int enemyID;

        public KillGoal(int amountNeeded, int enemyID, Quest quest){
            countCurrent = 0;
            countNeeded = amountNeeded;
            completed = false;
            this.enemyID = enemyID;
            this.quest = quest;
            EventController.OnEnemyDied += EnemyKilled;
        }

        void EnemyKilled(int enemyID){
            if (this.enemyID == enemyID && !this.completed){
                Increment();
            } else {
                Debug.Log("already completed");
            }
        }
    }
}