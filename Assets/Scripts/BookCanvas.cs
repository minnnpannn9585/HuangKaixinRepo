using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCanvas : MonoBehaviour
{
    public GameObject openBtn;
    public GameObject bookImage;

    public void OpenBook()
    {
        bookImage.SetActive(true);
        openBtn.SetActive(false);
    }

    public void CloseBook()
    {
        openBtn.SetActive(true);
        bookImage.SetActive(false);
    }
}
