using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    GameManager gameManager;
    void Start()
    {
        gameManager = GameManager.Instance;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy")){
            collision.gameObject.GetComponent<Renderer>().material.color = new Vector4(0, 0, 0, 1);
            collision.gameObject.GetComponent<AudioSource>().Play();
            collision.gameObject.GetComponent<Collider>().enabled = false;
            gameManager.UpdateNumOfEnemies();
        }
    }
}
