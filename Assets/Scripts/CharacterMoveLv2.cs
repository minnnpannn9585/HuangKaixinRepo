using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveLv2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hori = Input.GetAxis("Horizontal");

        transform.Translate(hori * Time.deltaTime * 5f, 0, 0);

        if(hori > 0)
        {
            transform.GetChild(0).GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (hori < 0)
        {
            transform.GetChild(0).GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
