using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageUI : MonoBehaviour
{
    public Transform bookPageParent;
    public GameObject[] bookImages;
    public int index;

    private void Start()
    {
        
        for (int i = 0; i < 7; i++)
        {
            bookImages[i] = bookPageParent.GetChild(i).gameObject;
        }
        
    }

    public void NextPage()
    {
        index++;
        if (index == 7)
        {
            index = 6;
        }
        else
        {
            bookImages[index].SetActive(true);
            bookImages[index - 1].SetActive(false);
        }
        
    }

    public void PreviousPage()
    {
        index--;
        if (index == -1)
        {
            index = 0;
        }
        else
        {
            bookImages[index].SetActive(true);
            bookImages[index + 1].SetActive(false);
        }
        
        
    }
}
