using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueUI;
    public Text dialogueText;
    public Text nameText;
    public int index;
    //public int number;
    public string[] dialogues;
    public string[] names;
    public GameObject[] picsTurnOff;

    public void StartDialogue()
    {
        dialogueUI.SetActive(true); // Show the dialogue UI
        index = 0;
        dialogueText.text = dialogues[index];
        nameText.text = names[index];
        
    }

    public void DisplayNextSentence()
    {
        if (dialogues[index] == "It’s getting dark. I should leave here.")
        {
            LevelOneManager.instance.levelOneEnd = true;
        }
        
        index++;
        if(index >= dialogues.Length)
        {
            
            
            foreach(GameObject pic in picsTurnOff)
            {
                pic.SetActive(false); // Turn off all specified pictures
            }
            index = 0;
            dialogueUI.SetActive(false); // Hide the dialogue UI
            dialogues = new string[0];
            names = new string[0];
            
            
        }
        else
        {
            dialogueText.text = dialogues[index];
            nameText.text = names[index];
        }

        if (LevelOneManager.instance != null)
        {
            if (LevelOneManager.instance.propNum == 3)
            {
                LevelOneManager.instance.propNum = 0;
                LevelOneManager.instance.GoNextStage();
            }
        }
        
    }
}
