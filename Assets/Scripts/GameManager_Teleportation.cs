using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GameManager_Teleportation : MonoBehaviour
{
    private static GameManager_Teleportation instance = null;

    public static GameManager_Teleportation Instance
    {
        get
        {
            return instance;
        }
    }

    private int score = 0;
    private int numOfEnemies;

    public GameObject enemies;

    void Awake()
    {
        if(instance){
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
        
        if(enemies != null)
            numOfEnemies = enemies.transform.childCount;
    }

    public void UpdateScore()
    {
        score++;

        Debug.Log("Score : " + score);
    }

    public void UpdateNumOfEnemies()
    {
        numOfEnemies--;
        UpdateScore();
        if(numOfEnemies == 0)
            Debug.Log("Level Cleared");
        else
            Debug.Log("Remaining enemies : " + numOfEnemies);
    }

    public void DestroyAllEnemies()
    {
        enemies.SetActive(false);
        score += numOfEnemies;
        numOfEnemies = 0;

        Debug.Log("Score : " + score);
        Debug.Log("Level Cleared");
    }
}