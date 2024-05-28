using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    GameManager_Shoot gameManager_Shoot;
    GameManager_Teleportation gameManager_Teleportation;

    [SerializeField]
    private bool isShoot = false;
    
    void Start()
    {
        if(isShoot)
            gameManager_Shoot = GameManager_Shoot.Instance;
        else
            gameManager_Teleportation = GameManager_Teleportation.Instance;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy")){
            collision.gameObject.GetComponent<Renderer>().material.color = new Vector4(0, 0, 0, 1);
            collision.gameObject.GetComponent<AudioSource>().Play();
            collision.gameObject.GetComponent<Collider>().enabled = false;
            
            if(gameManager_Shoot != null)
                gameManager_Shoot.UpdateNumOfEnemies();
            else
                gameManager_Teleportation.UpdateNumOfEnemies();
        }
    }
}
