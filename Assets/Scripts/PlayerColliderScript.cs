using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColliderScript : MonoBehaviour
{
    public Rigidbody rb;
    public GameManager gameManager;
    private  void OnCollisionEnter(Collision info) {
        if(info.collider.tag == "Obstacle"){
            gameManager.EndGame();
        }
    }
    
}
