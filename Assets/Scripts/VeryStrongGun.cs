using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeryStrongGun : MonoBehaviour
{
    private GameManager_Teleportation gameManager_Teleportation;
    private AudioSource audioSource;
    void Start()
    {
        gameManager_Teleportation = GameManager_Teleportation.Instance;
        audioSource = GetComponent<AudioSource>();
    }

    public void Fire()
    {
        gameManager_Teleportation.DestroyAllEnemies();
        audioSource.Play();
    }
}
