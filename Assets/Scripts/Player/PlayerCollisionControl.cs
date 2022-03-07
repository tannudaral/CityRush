using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionControl : MonoBehaviour
{
    void OnTriggerEnter(Collider collision) {
        if(collision.gameObject.tag == "Enemy")
        {
            PlayerManager.gameOver = true;
            Debug.Log("Obstacle hit!");
        }
    }
}
