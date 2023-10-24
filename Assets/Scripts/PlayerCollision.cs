using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Barrier") 
        {
           movement.enabled = false;
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
