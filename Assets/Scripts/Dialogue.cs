using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    [SerializeField]
    private Text dialogueText;

    [SerializeField]
    private GameObject dialoguePanel;
    private string[] dialogue;
    private int dialogueIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartDialogue(string[] dialogue){
        dialogueIndex = 0;
        this.dialogue = dialogue;
        dialoguePanel.SetActive(true);
        dialogueText.text = dialogue[dialogueIndex];
    }

    public void NextLine(){
        dialogueIndex = Mathf.Min(dialogueIndex + 1, dialogue.Length);
        if (dialogueIndex >= this.dialogue.Length){
            ResetDialogue();
        } else {
            dialogueText.text = dialogue[dialogueIndex];
        }
    }

    public void PreviousLine(){
        if (dialogueIndex == 0){
            return;
        }
        dialogueIndex = Mathf.Max(dialogueIndex - 1, 0);
        dialogueText.text = dialogue[dialogueIndex];
    }

    public void ResetDialogue(){
        dialogue = null;
        dialogueText.text = "";
        dialoguePanel.SetActive(false);
        dialogueIndex = 0;
    }
}
