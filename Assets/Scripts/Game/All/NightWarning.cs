using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightWarning : MonoBehaviour
{
    GameManager gameManager;


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        Nightwarning();//в старте проверка ночи
    }


    public void Nightwarning()//проверка ночи
    {
        if (gameManager.time >= 90 && gameManager.nightwarning == false)//если время >= 90 и предупреждение о ночи = не активно
        {
            gameManager.nightwarning = true;//то предупреждение о ночи = активно
            gameManager.nightWarning.SetActive(true);//то предупреждение о ночи = активно
        }
    }
}
