using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject player;
    public GameObject jumpBoost;
    public GameObject blinkAbility;
    public GameManager gameManager;
    public int movementSpeed = 20;
    public bool movementIsEnabled = true;
    bool gameIsAlreadyWon = false;
    public bool hasJumpBoost = false;
    bool isOnGround = true;
    public bool hasBlink = false;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerHasFallen())
        {
            movementIsEnabled = false;
        }
        if(movementIsEnabled == false && gameIsAlreadyWon == false)
        {
            gameManager.EndGame();
        }
        if(movementIsEnabled == true)
        {
            if (Input.GetKey("w"))
            {
                rb.AddForce(0, 0, movementSpeed * Time.deltaTime);
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce(-movementSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey("s"))
            {

                rb.AddForce(0, 0, -movementSpeed * Time.deltaTime);
            }
            if (Input.GetKey("d"))
            {
                rb.AddForce(movementSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey("space")){
                if(isOnGround)
                {
                    if(hasJumpBoost)
                    {
                        rb.AddForce(0, 18500 * Time.deltaTime, 0);
                    }
                    else
                    {
                        rb.AddForce(0, 9000 * Time.deltaTime, 0);
                    }
                    
                }
              
                

            }
            if(Input.GetKey("p") && hasBlink)
            {
                blinkTeleport();
                gameManager.hideBlinkAbilityPanel();
            }
        }
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "WinTrigger")
        {
            gameManager.winGame();
            gameIsAlreadyWon = true;
        }
        if (other.name == "JumpBoost")
        {
            hasJumpBoost = true;
            gameManager.showJumpBoostPanel();
            jumpBoost.SetActive(false);
        }
        if(other.name == "BlinkAbility")
        {
            hasBlink = true;
            gameManager.showBlinkAbilityPanel();
            blinkAbility.SetActive(false);
        }
        
    }

    public void OnCollisionEnter(Collision collision)
    {
       if(collision.collider.tag == "UnClimbable")
        {
            isOnGround = false;
        } else
        {
           
            isOnGround = true;
        }
           
    }

    public void OnCollisionExit(Collision collision)
    {
        isOnGround = false;
    }
    bool playerHasFallen()
    {
        return rb.position.y < -20;
    }

    void blinkTeleport()
    {
        hasBlink = false;
        Vector3 blinkTeleport = new Vector3(player.transform.position.x, player.transform.position.y + 2, player.transform.position.z + 5);
        player.transform.position = blinkTeleport;
    }

}
