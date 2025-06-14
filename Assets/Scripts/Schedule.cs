using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schedule : MonoBehaviour
{
    //public GameObject schedulePic;
    public string[] openSceneDialogues;
    public string[] openSceneNames;
    public DialogueManager manager;

    private void OnMouseDown()
    {
        //schedulePic.SetActive(true);
        manager.dialogues = openSceneDialogues;
        manager.names = openSceneNames;
        manager.StartDialogue();

        transform.parent.GetComponent<ObjectCount>().count += 1;
        transform.GetComponent<Collider2D>().enabled = false;

    }
}
