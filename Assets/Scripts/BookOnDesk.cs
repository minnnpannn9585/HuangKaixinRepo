using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookOnDesk : MonoBehaviour
{
    public GameObject bookOpen;

    private void OnMouseDown()
    {
        bookOpen.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
