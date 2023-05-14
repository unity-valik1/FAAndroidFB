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


    public void Time()//������� �����
    {
        if (gameManager.time >= 0)//���� ����� >= 0
        {
            gameManager.time += 1;//�� �� ������� +1
        }
    }

    public void Energy()//������� ���������
    {
        if (gameManager.energy > 0 && gameManager.health <= 100 && gameManager.health >= 76)//���� ������� > 0 � �������� <= 100 ��� >= 76
        {
            gameManager.energy -= 1;//�� �� ������� -1
        }

        else if (gameManager.energy > 0 && gameManager.health <= 75 && gameManager.health >= 51)//���� ������� > 0 � �������� <= 75 ��� >= 51
        {
            gameManager.energy -= 2;//�� �� ������� -2
        }

        else if (gameManager.energy > 0 && gameManager.health <= 50 && gameManager.health >= 26)//���� ������� > 0 � �������� <= 50 ��� >= 26
        {
            gameManager.energy -= 3;//�� �� ������� -3
        }

        else if (gameManager.energy > 0 && gameManager.health <= 25 && gameManager.health >= 1)//���� ������� > 0 � �������� <= 25 ��� >= 1
        {
            gameManager.energy -= 4;//�� �� ������� -4
        }
    }


    public void Hunger()//����� ���������
    {
        if (gameManager.hunger > 0)//���� ����� > 0
        {
            gameManager.hunger -= 1;//�� �� ������ -1
        }
    }
}
