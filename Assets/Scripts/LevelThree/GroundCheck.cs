using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {

            this.transform.parent.GetComponent<CharacterMovementLv3>().isGrounded = true; // Set isGrounded to true when touching the ground
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {

            this.transform.parent.GetComponent<CharacterMovementLv3>().isGrounded = false; // Set isGrounded to true when touching the ground
        }
    }
}
