using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;

    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    public int score = 0;
    public int numOfEnemies;

    void Awake()
    {
        if(instance){
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateScore()
    {
        score++;

        Debug.Log(score);
    }

    public void UpdateNumOfEnemies()
    {
        numOfEnemies--;
        if(numOfEnemies == 0)
            Debug.Log("Level Cleared");
        else
            Debug.Log(numOfEnemies);
    }
}