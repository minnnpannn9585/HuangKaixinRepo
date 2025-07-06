using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementLv3 : MonoBehaviour
{
    float horizontalInput;
    Rigidbody2D rb;
    public float speed = 5f;
    public float jumpForce = 300f;
    public bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if(horizontalInput > 0)
        {
            transform.GetChild(0).localScale = new Vector3(1, 1, 1) * 0.4f; // Facing right
            transform.GetChild(0).GetComponent<Animator>().SetBool("isWalking", true);
        }
        else if (horizontalInput < 0)
        {
            transform.GetChild(0).localScale = new Vector3(-1, 1, 1) * 0.4f; // Facing left
            transform.GetChild(0).GetComponent<Animator>().SetBool("isWalking", true);
        }
        else
        {
            transform.GetChild(0).GetComponent<Animator>().SetBool("isWalking", false);
        }
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpForce));
        }
    }
}
