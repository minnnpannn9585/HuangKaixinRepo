using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDrag : MonoBehaviour
{
    bool clicked = false;
    private bool touched = false;
    Vector3 startPos;
    Vector3 mousePos;
    GameObject obj = null;

    private void Start()
    {
        startPos = transform.position;  
    }

    private void Update()
    {
        if (clicked)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3
                (mousePos.x, mousePos.y, transform.position.z);
        }
    }
    private void OnMouseDown()
    {
        clicked = true;
    }

    private void OnMouseUp()
    {
        clicked = false;
        if (touched)
        {
            obj.GetComponent<SpriteRenderer>().enabled = true;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Slot"))
        {
            obj = other.gameObject;
            touched = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Slot"))
        {
            obj = null;
            touched = false;
        }
    }
}
