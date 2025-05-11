using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSceneDialogue : MonoBehaviour
{
    public string[] openSceneDialogues;
    public string[] openSceneNames;
    //public int sentenceNumber;
    public DialogueManager manager;

    void Start()
    {
        //manager.number = sentenceNumber;
        manager.dialogues = openSceneDialogues;
        manager.names = openSceneNames;
        manager.StartDialogue();
    }

}
