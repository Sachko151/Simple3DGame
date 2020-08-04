using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacleScript : MonoBehaviour
{
    public Rigidbody rb;
    public int movementSpeed;
    bool hasToMoveLeft = true;

    public void FixedUpdate()
    {
        if (hasToMoveLeft)
        {
            rb.AddForce(-movementSpeed, 0, 0);
        }
        else
        {
            rb.AddForce(movementSpeed, 0, 0);
        }

                
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "RObstacleTrigger")
        {
            hasToMoveLeft = true;
        }else if(other.name == "LObstacleTrigger")
        {
            hasToMoveLeft = false;
        }
        else
        {
        }
    }

}
