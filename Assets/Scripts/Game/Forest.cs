using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest : MonoBehaviour
{
    GameManager gameManager;


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }


    public void BigGameHunting()//ќхота на крупную дичь
    {
        gameManager.time += 50;//врем€ +50
        gameManager.energy -= 50;//усталость -50
        gameManager.hunger -= 50;//насыщенность -50
    }


    public void SmallGameHunting()//ќхота на мелкую дичь
    {
        gameManager.time += 30;//врем€ +30
        gameManager.energy -= 30;//усталость -30
        gameManager.hunger -= 30;//насыщенность -30
    }


    public void LookForFirewood()//»скать дрова
    {
        gameManager.time += 10;//врем€ +10
        gameManager.energy -= 10;//усталость -10
        gameManager.hunger -= 10;//насыщенность -10

        if (gameManager.axe == true)
        {
            int a = Random.Range(4, 11);
            gameManager.firewood += a;
        }
        else if (gameManager.axe == false)
        {
            int b = Random.Range(2, 6);
            gameManager.firewood += b;
        }
    }


    public void PickingBerries()//—обирать €годы
    {
        gameManager.time += 10;//врем€ +10
        gameManager.energy -= 3;//усталость -3
        gameManager.hunger -= 3;//насыщенность -3
    }
}
