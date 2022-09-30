using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace QuestSystem{ 
    public class QuestGiver : MonoBehaviour
    {
        [SerializeField]
        private string questName;
        private QuestController questController;
        private Quest quest;

        void Start(){
            questController = FindObjectOfType<QuestController>();
            EventController.OnQuestCompleted += Completed;
        }

        public void GiveQuest(){
            quest = questController.AssignQuest(questName);
            GetComponent<Button>().image.color = Color.green;
            GetComponent<Button>().interactable = false;
        }

        public void Completed(Quest quest){
            if (this.quest != null && quest == this.quest){
                GetComponent<Button>().interactable = false;
            }
        }
    }
}