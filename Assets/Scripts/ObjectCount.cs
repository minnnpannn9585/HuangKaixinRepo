using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCount : MonoBehaviour
{
    public int count = 0;
    public GameObject bookOnDesk;

    private void Update()
    {
        if(count == 3)
        {
            bookOnDesk.SetActive(true);
            count = 0;
        }
    }
}
