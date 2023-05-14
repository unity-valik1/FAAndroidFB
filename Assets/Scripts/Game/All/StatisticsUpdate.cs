using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class StatisticsUpdate : MonoBehaviour
{
    GameManager gameManager;

    [Header("Статистика игрока")]
    [Tooltip("Время")] public TMP_Text timeText;//значение времени в игре
    [Tooltip("Здоровье")] public TMP_Text healthText;//значение здоровья в игре
    [Tooltip("Энергия")] public TMP_Text energyText;//значение усталости в игре
    [Tooltip("Голод")] public TMP_Text hungerText;//значение голода в игре
    [Tooltip("Дыхание")] public TMP_Text breathText;//значение дыхания в игре

    [Header("Время суток")]
    [Tooltip("Утро")] public GameObject morning;//фото утра
    [Tooltip("День")] public GameObject day;//фото дня
    [Tooltip("Вечер")] public GameObject evening;//фото вечера
    [Tooltip("Ночь")] public GameObject night;//фото ночи

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        NewTime();
        NewEnergy();
        NewHunger();
        NewHealth();
    }


    public void NewTime()//Обновление времени суток
    {

        if (gameManager.time >= 0 && gameManager.time <= 20)//если время >= 0 и <= 20
        {
            morning.SetActive(true);
            day.SetActive(false);
            evening.SetActive(false);
            night.SetActive(false);
        }

        else if (gameManager.time >= 21 && gameManager.time <= 70)//если время >= 21 и <= 70
        {
            morning.SetActive(false);
            day.SetActive(true);
            evening.SetActive(false);
            night.SetActive(false);
        }

        else if (gameManager.time >= 71 && gameManager.time <= 90)//если время >= 71 и <= 90
        {
            morning.SetActive(false);
            day.SetActive(false);
            evening.SetActive(true);
            night.SetActive(false);
        }

        else if (gameManager.time >= 91 && gameManager.time <= 120 || gameManager.time > 120)//если время >= 91 и <= 120 или время > 120
        {
            morning.SetActive(false);
            day.SetActive(false);
            evening.SetActive(false);
            night.SetActive(true);
        }
    }


    public void NewEnergy()//Обновление энергии персонажа
    {
        if (gameManager.maxEnergy == 0)//если макс. энергия = 0
        {
            if (gameManager.energy > 70)//если энергия > 70
            {
                gameManager.energy = 70;//то энергия = 70
            }
            else if (gameManager.energy <= 70 && gameManager.energy >= 52)//если энергия <= 70 и >= 52
            {
                energyText.text = "Энергия: Сила быка";//то выводи энергия: Много сил
            }
            else if (gameManager.energy <= 51 && gameManager.energy >= 36)//если энергия <= 51 и >= 36
            {
                energyText.text = "Энергия: Средне сил";//то выводи энергия: Средне сил
            }
            else if (gameManager.energy <= 35 && gameManager.energy >= 19)//если энергия <= 35 и >= 19
            {
                energyText.text = "Энергия: Чутка сил";//то выводи энергия: Мало сил
            }
            else if (gameManager.energy <= 18 && gameManager.energy >= 1)//если энергия <= 18 и >= 1
            {
                energyText.text = "Энергия: Скоро усну";//то выводи энергия: Скоро усну
            }
            else if (gameManager.energy <= 0 && gameManager.territorycamp == true)//если энергия <= 0
            {
                gameManager.territoryCamp.SetActive(true);
            }
            else if (gameManager.energy <= 0 && gameManager.territorynocamp == true)//если энергия <= 0
            {
                gameManager.territoryNoCamp.SetActive(true);
            }
        }



        else if (gameManager.maxEnergy == 1)//если макс. энергия = 1
        {
            if (gameManager.energy > 80)//если энергия > 80
            {
                gameManager.energy = 80;//то энергия = 80
            }
            else if (gameManager.energy <= 80 && gameManager.energy >= 61)//если энергия <= 80 и >= 61
            {
                energyText.text = "Энергия: Сила быка";//то выводи энергия: Много сил
            }
            else if (gameManager.energy <= 60 && gameManager.energy >= 41)//если энергия <= 60 и >= 41
            {
                energyText.text = "Энергия: Средне сил";//то выводи энергия: Средне сил
            }
            else if (gameManager.energy <= 40 && gameManager.energy >= 21)//если энергия <= 40 и >= 21
            {
                energyText.text = "Энергия: Чутка сил";//то выводи энергия: Мало сил
            }
            else if (gameManager.energy <= 20 && gameManager.energy >= 1)//если энергия <= 20 и >= 1
            {
                energyText.text = "Энергия: Скоро усну";//то выводи энергия: Скоро усну
            }
            else if (gameManager.energy <= 0)//если энергия <= 0
            {
                energyText.text = "Энергия: Умер";//то выводи энергия: Умер
            }
        }

        else if (gameManager.maxEnergy == 2)//если макс. энергия = 2
        {
            if (gameManager.energy > 90)//если энергия > 90
            {
                gameManager.energy = 90;//то энергия = 90
            }
            else if (gameManager.energy <= 90 && gameManager.energy >= 68)//если энергия <= 90 и >= 68
            {
                energyText.text = "Энергия: Сила быка";//то выводи энергия: Много сил
            }
            else if (gameManager.energy <= 67 && gameManager.energy >= 45)//если энергия <= 67 и >= 45
            {
                energyText.text = "Энергия: Средне сил";//то выводи энергия: Средне сил
            }
            else if (gameManager.energy <= 44 && gameManager.energy >= 23)//если энергия <= 44 и >= 23
            {
                energyText.text = "Энергия: Чутка сил";//то выводи энергия: Мало сил
            }
            else if (gameManager.energy <= 22 && gameManager.energy >= 1)//если энергия <= 22 и >= 1
            {
                energyText.text = "Энергия: Скоро усну";//то выводи энергия: Скоро усну
            }
            else if (gameManager.energy <= 0)//если энергия <= 0
            {
                energyText.text = "Энергия: Умер";//то выводи энергия: Умер
            }
        }

        else if (gameManager.maxEnergy == 3)//если макс. энергия = 3
        {
            if (gameManager.energy > 100)//если энергия > 100
            {
                gameManager.energy = 100;//то энергия = 100
            }
            else if (gameManager.energy <= 100 && gameManager.energy >= 76)//если энергия <= 100 и >= 76
            {
                energyText.text = "Энергия: Сила быка";//то выводи энергия: Много сил
            }
            else if (gameManager.energy <= 75 && gameManager.energy >= 51)//если энергия <= 75 и >= 51
            {
                energyText.text = "Энергия: Средне сил";//то выводи энергия: Средне сил
            }
            else if (gameManager.energy <= 50 && gameManager.energy >= 26)//если энергия <= 50 и >= 26
            {
                energyText.text = "Энергия: Чутка сил";//то выводи энергия: Мало сил
            }
            else if (gameManager.energy <= 25 && gameManager.energy >= 1)//если энергия <= 25 и >= 1
            {
                energyText.text = "Энергия: Скоро усну";//то выводи энергия: Скоро усну
            }
            else if (gameManager.energy <= 0)//если энергия <= 0
            {
                energyText.text = "Энергия: Умер";//то выводи энергия: Умер
            }
        }

        else if (gameManager.maxEnergy == 4)//если макс. энергия = 4
        {
            if (gameManager.energy > 110)//если энергия > 110
            {
                gameManager.energy = 110;//то энергия = 110
            }
            else if (gameManager.energy <= 110 && gameManager.energy >= 83)//если энергия <= 110 и >= 83
            {
                energyText.text = "Энергия: Сила быка";//то выводи энергия: Много сил
            }
            else if (gameManager.energy <= 82 && gameManager.energy >= 55)//если энергия <= 82 и >= 55
            {
                energyText.text = "Энергия: Средне сил";//то выводи энергия: Средне сил
            }
            else if (gameManager.energy <= 54 && gameManager.energy >= 28)//если энергия <= 54 и >= 28
            {
                energyText.text = "Энергия: Чутка сил";//то выводи энергия: Мало сил
            }
            else if (gameManager.energy <= 27 && gameManager.energy >= 1)//если энергия <= 27 и >= 1
            {
                energyText.text = "Энергия: Скоро усну";//то выводи энергия: Скоро усну
            }
            else if (gameManager.energy <= 0)//если энергия <= 0
            {
                energyText.text = "Энергия: Умер";//то выводи энергия: Умер
            }
        }

        else if (gameManager.maxEnergy == 5)//если макс. энергия = 5
        {
            if (gameManager.energy > 120)//если энергия > 120
            {
                gameManager.energy = 120;//то энергия = 120
            }
            else if (gameManager.energy <= 120 && gameManager.energy >= 91)//если энергия <= 120 и >= 91
            {
                energyText.text = "Энергия: Сила быка";//то выводи энергия: Много сил
            }
            else if (gameManager.energy <= 90 && gameManager.energy >= 61)//если энергия <= 90 и >= 61
            {
                energyText.text = "Энергия: Средне сил";//то выводи энергия: Средне сил
            }
            else if (gameManager.energy <= 60 && gameManager.energy >= 31)//если энергия <= 60 и >= 31
            {
                energyText.text = "Энергия: Чутка сил";//то выводи энергия: Мало сил
            }
            else if (gameManager.energy <= 30 && gameManager.energy >= 1)//если энергия <= 30 и >= 1
            {
                energyText.text = "Энергия: Скоро усну";//то выводи энергия: Скоро усну
            }
            else if (gameManager.energy <= 0)//если энергия <= 0
            {
                energyText.text = "Энергия: Умер";//то выводи энергия: Отлично
            }
        }
    }





    public void NewHunger()//Обновление голода персонажа
    {
        if (gameManager.hunger > 200)//если голод > 200
        {
            gameManager.hunger = 200;//то голод = 200
            hungerText.text = "Голод: Сытый";//то выводи голод: Сытый
        }

        else if (gameManager.hunger <= 200 && gameManager.hunger >= 150)//если голод <= 200 и >= 150
        {
            hungerText.text = "Голод: Сытый";//то выводи голод: Сытый
        }

        else if (gameManager.hunger <= 149 && gameManager.hunger >= 100)//если голод <= 149 и >= 100
        {
            hungerText.text = "Голод: Перекусил бы";//то выводи голод: Перекусил бы
        }

        else if (gameManager.hunger <= 99 && gameManager.hunger >= 50)//если голод <= 99 и >= 50
        {
            hungerText.text = "Голод: Голодный";//то выводи голод: Голодный
        }

        else if (gameManager.hunger <= 49 && gameManager.hunger >= 1)//если голод <= 49 и >= 1
        {
            hungerText.text = "Голод: Очень голодный";//то выводи голод: Очень голодный
        }

        else if (gameManager.hunger <= 0)//если голод <= 0 или
        {
            hungerText.text = "Голод: Умер от голода";//то выводи голод: Умер
        }
    }


    public void NewHealth()//Обновление здоровья персонажа
    {
        if (gameManager.health > 100)//если здоровье > 100
        {
            gameManager.health = 100;//то здоровье = 100
            healthText.text = "Здоровье: Отличное";//то выводи здоровье: Отличное
        }

        else if (gameManager.health <= 100 && gameManager.health >= 76)//если здоровье <= 100 и >= 76
        {
            healthText.text = "Здоровье: Отличное";//то выводи здоровье: Отличное
        }

        else if (gameManager.health <= 75 && gameManager.health >= 51)//если здоровье <= 75 и >= 51
        {
            healthText.text = "Здоровье: Хорошее";//то выводи здоровье: Хорошее
        }

        else if (gameManager.health <= 50 && gameManager.health >= 26)//если здоровье <= 50 и >= 26
        {
            healthText.text = "Здоровье: Плохое";//то выводи здоровье: Плохое
        }

        else if (gameManager.health <= 25 && gameManager.health >= 1)//если здоровье <= 25 и >= 1
        {
            healthText.text = "Здоровье: Очень плохое";//то выводи здоровье: Очень плохое
        }

        else if (gameManager.health <= 0)//если здоровье <= 0 или
        {
            healthText.text = "Здоровье: Умер";//то выводи здоровье: Умер
        }
    }
}
