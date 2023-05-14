using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medicines : MonoBehaviour
{
    GameManager gameManager;



    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }


    public void Mediciness()
    {
        gameManager.health = 100;
    }
}
