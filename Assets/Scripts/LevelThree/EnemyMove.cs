using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform firstPosition;
    public Transform secondPosition;
    bool movingToFirstPosition = true;


    void Update()
    {
        if (movingToFirstPosition)
        {
            if (Vector3.Distance(transform.position, firstPosition.position) > 0.2f)
            {
                transform.position = Vector3.MoveTowards(transform.position, firstPosition.position, Time.deltaTime * 2f);
            }
            else
            {
                movingToFirstPosition = false;
            }
        }
        else
        {
            if (Vector3.Distance(transform.position, secondPosition.position) > 0.2f)
            {
                transform.position = Vector3.MoveTowards(transform.position, secondPosition.position, Time.deltaTime * 2f);
            }
            else
            {
                movingToFirstPosition = true;
            }
        }
    }
}
