using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camp : MonoBehaviour
{
    GameManager gameManager;
 

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    //Костер
    public void StartFireWithFriction()//разжечь костер трением
    {
        if (gameManager.energy < 21)
        {
            //анимация нехватки энергии
        }
        if (gameManager.hunger < 21)
        {
            //анимация нехватки голода
        }
        else
        {
            gameManager.time += 20;//время +20
            gameManager.energy -= 20;//энергия -20
            gameManager.hunger -= 20;//голод -20
        }
    }

    //Костер
    public void LightFireWithMagnifyingGlass()//разжечь костер лупой
    {
        if (gameManager.energy < 6)
        {
            //анимация нехватки энергии
        }
        if (gameManager.hunger < 6)
        {
            //анимация нехватки голода
        }
        else
        {
            gameManager.time += 5;//время +5
            gameManager.energy -= 5;//энергия -5
            gameManager.hunger -= 5;//голод -5
        }
    }


    public void BoilWater()//Вскипятить воду
    {
        if (gameManager.energy < 6)
        {
            //анимация нехватки энергии
        }
        if (gameManager.hunger < 6)
        {
            //анимация нехватки голода
        }
        else
        {
            gameManager.time += 5;//время +5
            gameManager.energy -= 5;//энергия -5
            gameManager.hunger -= 5;//голод -5
        }
    }


    public void CookMeat1Unit()//Приготовить мясо на костре 1 ед
    {
        gameManager.time += 5;//время +5
        gameManager.energy -= 5;//энергия -5
        gameManager.hunger += 50;//голод +50
    }


    public void CookMeat2Unit()//Приготовить мясо на костре 2 ед
    {
        gameManager.time += 5;//время +5
        gameManager.energy -= 5;//энергия -5
        gameManager.hunger += 100;//голод +100
    }


    //Обустроить жилье
    public void MakeCanopy()//Сделать навес
    {
        gameManager.time += 30;//время +30
        gameManager.energy -= 30;//энергия -30
        gameManager.hunger -= 30;//голод -30
        gameManager.canopy = true;
        gameManager.maxEnergy += 1;
    }


    public void UpgradeToHut()//Улучшить до хижины
    {
        gameManager.time += 50;//время +50
        gameManager.energy -= 50;//энергия -50
        gameManager.hunger -= 50;//голод -50
        gameManager.upgradeToHut = true;
        gameManager.maxEnergy += 2;
    }
    
    
    public void ArrangeBedroom()//Обустроить спальное место
    {
        //gameManager.time += 50;//время +50
        //gameManager.fatigue -= 50;//энергия -50                                                 //TODO
        //gameManager.satiety -= 50;//голод -50
        gameManager.arrangeBedroom = true;
        gameManager.maxEnergy += 1;
    }


    public void BuildWall()//Построить стену
    {
        gameManager.time += 30;//время +30
        gameManager.energy -= 30;//энергия -30
        gameManager.hunger -= 30;//голод -30
        gameManager.wall = true;//стена = есть
    }


    //Ночь в кровати
    public void BedSleep()
    {
        gameManager.time = 0;//время = 0
        gameManager.nightwarning = false;//предупреждение о ночи = не активно
        gameManager.nightwarning = true;//то предупреждение о нападении животных ночью = не активно

        gameManager.energy = 70;//энергия = 70
        if (gameManager.canopy == true)//если навес = 1
        {
            gameManager.energy += 10;//то энергия +10
        }

        if (gameManager.coverlet == true)//если одеяло = 1
        {
            gameManager.energy += 10;//то энергия +10
        }

        if (gameManager.arrangeBedroom == true)//если обустроить спальное место = 1
        {
            gameManager.energy += 10;//то энергия +10
        }

        if (gameManager.upgradeToHut == true)//если улучшить до хижины = 2
        {
            gameManager.energy += 20;//то энергия +20
        }

        gameManager.health += 25;//здоровье += 25
        if(gameManager.health >= 100)
        {
            gameManager.health = 100;
        }

        //Стена

        int a = Random.Range(0, 10);
        if (gameManager.wall == false)
        {
            if (a == 5)
            {
                if (gameManager.noWeapons == true)//если оружия нету = 1
                {
                    gameManager.health -= 75;//то здоровье -75
                }

                else if (gameManager.knife == true)//если нож = 1
                {
                    gameManager.health -= 50;//здоровье -50
                }

                else if (gameManager.gun == true)//если пистолет = 1
                {
                    gameManager.health -= 25;//здоровье -25
                }
            }
        }
        else if (gameManager.wall == true)
        {
            if (a == 5)
            {
                gameManager.wall = false;
            }
        }
    }
}
