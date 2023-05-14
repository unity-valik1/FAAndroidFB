using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimals : MonoBehaviour
{
    GameManager gameManager;


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        AccidentallyAttackedByWildAnimals();
    }

    public void AccidentallyAttackedByWildAnimals()
    {
        if (gameManager.time >= 90 && gameManager.randomanimals == false)//если время >= 90 и предупреждение о нападении животных ночью = не активно
        {
            int a = Random.Range(0, 11);// а = рандом от 0 до 10
            if (a == 5)//если а = 5
            {
                if (gameManager.randomanimals == true)//если оружия нету = активно
                {
                    gameManager.nightwarning = true;//то предупреждение о нападении животных ночью = активно
                    gameManager.health -= 50;//то здоровье -50
                }

                else if (gameManager.knife == true)//если нож есть = активно
                {
                    gameManager.nightwarning = true;//то предупреждение о нападении животных ночью = активно
                    gameManager.health -= 25;//здоровье -25
                }

                else if (gameManager.gun == true)//если пистолет есть = активно
                {
                    gameManager.nightwarning = true;//то предупреждение о нападении животных ночью = активно
                    gameManager.health += 0;//здоровье остается прежним
                }
            }
        }
    }
}
