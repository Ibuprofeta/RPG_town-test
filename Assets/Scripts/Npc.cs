using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : Character
{

    private Vector2[] movementDirections = new Vector2[] {Vector2.up,
    Vector2.right, Vector2.down, Vector2.left};
    private Vector2 spawnPosition;

    [SerializeField]
    private DialogueData dialogueData;
    [SerializeField]
    private Dialogue dialogue;

    [SerializeField]
    private bool wander;

    [SerializeField]
    private string questName;
    private QuestSystem.Quest quest;
    private QuestSystem.QuestController questController;
    // Start is called before the first frame update
    void Start()
    {
        questController = FindObjectOfType<QuestSystem.QuestController>();
        spawnPosition = transform.position;
        
        if (wander)
            Wander();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Wander(){
        Vector2 currentPosition = transform.position;
        if (currentPosition == spawnPosition){
            int roll = Random.Range(0, 4);
            Vector2 destination = currentPosition + movementDirections[roll];
            StartCoroutine(this.MoveTo(destination, Wander, Random.Range(2,5)));
        } else {
            StartCoroutine(this.MoveTo(spawnPosition, Wander, Random.Range(2,5)));
        }
    }

    public void Interact(Character player = null){

        if (GetComponent<BattleLauncherCharacter>() != null){
            GetComponent<BattleLaunchCharacter>().PrepareBattle(player);
        }
        if (questName != ""){
            if (quest == null){
                dialogue.StartDialogue(dialogueData.dialogue);
                quest = questController.AssignQuest(questName);
            }
        }
    }
}
