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

        transform.Translate(hori * Time.deltaTime * 2f, 0, 0);

        if(hori > 0)
        {
            transform.GetChild(0).GetComponent<SpriteRenderer>().flipX = false;
            transform.GetChild(0).GetComponent<Animator>().SetBool("isMoving", true);
        }
        else if (hori < 0)
        {
            transform.GetChild(0).GetComponent<SpriteRenderer>().flipX = true;
            transform.GetChild(0).GetComponent<Animator>().SetBool("isMoving", true);
        }
        else if(hori == 0)
        {
            transform.GetChild(0).GetComponent<Animator>().SetBool("isMoving", false);
        }
    }
}
