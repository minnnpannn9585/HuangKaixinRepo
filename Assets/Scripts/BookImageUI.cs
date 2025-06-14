using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BookImageUI : MonoBehaviour
{
    public Sprite[] sprites;
    public int index = 0;

    public void RightPage()
    {
        if(index >= sprites.Length - 1)
        {
            return;
        }
        index += 1;
        GetComponent<Image>().sprite = sprites[index];
    }

    public void LeftPage()
    {
        if(index <= 0)
        {
            return;
        }
        index -= 1;
        GetComponent<Image>().sprite = sprites[index];
    }
}
