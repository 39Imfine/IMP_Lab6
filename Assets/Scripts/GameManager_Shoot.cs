using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GameManager_Shoot : MonoBehaviour
{
    private static GameManager_Shoot instance = null;

    public static GameManager_Shoot Instance
    {
        get
        {
            return instance;
        }
    }
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
        else
            numOfEnemies = 0;
    }

    public void UpdateNumOfEnemies()
    {
        numOfEnemies--;
        if(numOfEnemies == 0)
            Debug.Log("Level Cleared");
        else
            Debug.Log("Remaining enemies : " + numOfEnemies);
    }
}