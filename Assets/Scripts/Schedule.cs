using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schedule : MonoBehaviour
{
    //public GameObject schedulePic;
    public string[] dialogues;
    public string[] names;
    public DialogueManager manager;
    public GameObject pic;

    private void OnMouseDown()
    {
        //schedulePic.SetActive(true);
        manager.dialogues = dialogues;
        manager.names = names;
        manager.StartDialogue();
        pic.SetActive(true);

        transform.parent.GetComponent<ObjectCount>().count += 1;
        transform.GetComponent<Collider2D>().enabled = false;

        LevelOneManager.instance.propNum++;

    }
}
