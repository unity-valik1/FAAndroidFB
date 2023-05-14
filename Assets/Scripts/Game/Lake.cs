using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lake : MonoBehaviour
{
    GameManager gameManager;


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }


    public void Breath()//Возможность задерживать дыхание под водой
    {
        //TODO уровень от 0 до 10
    }


    public void PracticeHoldingYourBreath()//Тренироваться задерживать дыхание
    {
        gameManager.time += 10;//время +10
        gameManager.energy -= 15;//усталость -15
        gameManager.hunger -= 15;//насыщенность -15
    }


    public void DiveIntoThePlane()//Нырнуть в самолет
    {
        gameManager.time += 15;//время +15
        gameManager.energy -= 15;//усталость -15
        gameManager.hunger -= 15;//насыщенность -15
    }
}
