using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardActions : MonoBehaviour
{
    GameManager gameManager;


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }


    public void Time()//Времени суток
    {
        if (gameManager.time >= 0)//если время >= 0
        {
            gameManager.time += 1;//то ко времени +1
        }
    }

    public void Energy()//Энергия персонажа
    {
        if (gameManager.energy > 0 && gameManager.health <= 100 && gameManager.health >= 76)//если энергия > 0 и здоровье <= 100 или >= 76
        {
            gameManager.energy -= 1;//то от энергия -1
        }

        else if (gameManager.energy > 0 && gameManager.health <= 75 && gameManager.health >= 51)//если энергия > 0 и здоровье <= 75 или >= 51
        {
            gameManager.energy -= 2;//то от энергия -2
        }

        else if (gameManager.energy > 0 && gameManager.health <= 50 && gameManager.health >= 26)//если энергия > 0 и здоровье <= 50 или >= 26
        {
            gameManager.energy -= 3;//то от энергия -3
        }

        else if (gameManager.energy > 0 && gameManager.health <= 25 && gameManager.health >= 1)//если энергия > 0 и здоровье <= 25 или >= 1
        {
            gameManager.energy -= 4;//то от энергия -4
        }
    }


    public void Hunger()//Голод персонажа
    {
        if (gameManager.hunger > 0)//если голод > 0
        {
            gameManager.hunger -= 1;//то от голода -1
        }
    }
}
