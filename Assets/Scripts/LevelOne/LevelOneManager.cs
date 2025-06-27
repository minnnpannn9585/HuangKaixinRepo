using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOneManager : MonoBehaviour
{
    public static LevelOneManager instance;
    public int propNum = 0;
    //public bool finishCurrentDialogue = false;

    public bool levelOneEnd = false;
    
    public string[] dialogues;
    public string[] names;
    public DialogueManager manager;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (levelOneEnd)
        {
            StartCoroutine(StartNextScene());
        }
    }

    public void GoNextStage()
    {
        //next stage
        // display second stage dialogue
		manager.dialogues = dialogues;
        manager.names = names;
        manager.StartDialogue();
    }

    
    
    public IEnumerator StartNextScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
