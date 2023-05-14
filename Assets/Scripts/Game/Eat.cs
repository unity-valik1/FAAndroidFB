using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }


    public void EatRawMeat1Unit()//—ъесть сырое м€со 1 ед
    {
        gameManager.time += 3;//врем€ +3
        gameManager.hunger += 25;//насыщенность +25

        int a = Random.Range(1, 4);//рандомное число 1-2-3
        if (a == 3)//если рандом число = 3
        {
            gameManager.health -= 25;//то здоровье -25
        }
    }


    public void EatBerries()//перекусить €годами
    {
        gameManager.time += 3;//врем€ +3
        gameManager.hunger += 30;//насыщенность +30
    }
    
    
    public void EatCannedFood()//съесть консерву
    {
        gameManager.time += 3;//врем€ +3
        gameManager.hunger += 100;//насыщенность +100
    }
}
