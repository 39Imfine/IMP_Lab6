using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Target : MonoBehaviour
{
    private GameManager gameManager;
    private AudioSource audioSource;

    void Start()
    {
        gameManager = GameManager.Instance;
        audioSource = GetComponent<AudioSource>();
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Item")){
            gameManager.UpdateScore();
            Destroy(collision.gameObject);
            audioSource.Play();
        }
    }
}
