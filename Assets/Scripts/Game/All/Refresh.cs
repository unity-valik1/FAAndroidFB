using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refresh : MonoBehaviour
{
    GameManager gameManager;


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }


    public void RefreshGo()
    {
        if (gameManager.time > 0 || gameManager.time < 0) 
        {
            gameManager.time = 0;
        }       

        if (gameManager.energy > 70 || gameManager.energy < 70)
        {
            gameManager.energy = 70;
        }

        if (gameManager.hunger > 200 || gameManager.hunger < 200)
        {
            gameManager.hunger = 200;
        }
    }
}
