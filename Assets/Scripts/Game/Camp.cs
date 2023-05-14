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

    //������
    public void StartFireWithFriction()//������� ������ �������
    {
        if (gameManager.energy < 21)
        {
            //�������� �������� �������
        }
        if (gameManager.hunger < 21)
        {
            //�������� �������� ������
        }
        else
        {
            gameManager.time += 20;//����� +20
            gameManager.energy -= 20;//������� -20
            gameManager.hunger -= 20;//����� -20
        }
    }

    //������
    public void LightFireWithMagnifyingGlass()//������� ������ �����
    {
        if (gameManager.energy < 6)
        {
            //�������� �������� �������
        }
        if (gameManager.hunger < 6)
        {
            //�������� �������� ������
        }
        else
        {
            gameManager.time += 5;//����� +5
            gameManager.energy -= 5;//������� -5
            gameManager.hunger -= 5;//����� -5
        }
    }


    public void BoilWater()//���������� ����
    {
        if (gameManager.energy < 6)
        {
            //�������� �������� �������
        }
        if (gameManager.hunger < 6)
        {
            //�������� �������� ������
        }
        else
        {
            gameManager.time += 5;//����� +5
            gameManager.energy -= 5;//������� -5
            gameManager.hunger -= 5;//����� -5
        }
    }


    public void CookMeat1Unit()//����������� ���� �� ������ 1 ��
    {
        gameManager.time += 5;//����� +5
        gameManager.energy -= 5;//������� -5
        gameManager.hunger += 50;//����� +50
    }


    public void CookMeat2Unit()//����������� ���� �� ������ 2 ��
    {
        gameManager.time += 5;//����� +5
        gameManager.energy -= 5;//������� -5
        gameManager.hunger += 100;//����� +100
    }


    //���������� �����
    public void MakeCanopy()//������� �����
    {
        gameManager.time += 30;//����� +30
        gameManager.energy -= 30;//������� -30
        gameManager.hunger -= 30;//����� -30
        gameManager.canopy = true;
        gameManager.maxEnergy += 1;
    }


    public void UpgradeToHut()//�������� �� ������
    {
        gameManager.time += 50;//����� +50
        gameManager.energy -= 50;//������� -50
        gameManager.hunger -= 50;//����� -50
        gameManager.upgradeToHut = true;
        gameManager.maxEnergy += 2;
    }
    
    
    public void ArrangeBedroom()//���������� �������� �����
    {
        //gameManager.time += 50;//����� +50
        //gameManager.fatigue -= 50;//������� -50                                                 //TODO
        //gameManager.satiety -= 50;//����� -50
        gameManager.arrangeBedroom = true;
        gameManager.maxEnergy += 1;
    }


    public void BuildWall()//��������� �����
    {
        gameManager.time += 30;//����� +30
        gameManager.energy -= 30;//������� -30
        gameManager.hunger -= 30;//����� -30
        gameManager.wall = true;//����� = ����
    }


    //���� � �������
    public void BedSleep()
    {
        gameManager.time = 0;//����� = 0
        gameManager.nightwarning = false;//�������������� � ���� = �� �������
        gameManager.nightwarning = true;//�� �������������� � ��������� �������� ����� = �� �������

        gameManager.energy = 70;//������� = 70
        if (gameManager.canopy == true)//���� ����� = 1
        {
            gameManager.energy += 10;//�� ������� +10
        }

        if (gameManager.coverlet == true)//���� ������ = 1
        {
            gameManager.energy += 10;//�� ������� +10
        }

        if (gameManager.arrangeBedroom == true)//���� ���������� �������� ����� = 1
        {
            gameManager.energy += 10;//�� ������� +10
        }

        if (gameManager.upgradeToHut == true)//���� �������� �� ������ = 2
        {
            gameManager.energy += 20;//�� ������� +20
        }

        gameManager.health += 25;//�������� += 25
        if(gameManager.health >= 100)
        {
            gameManager.health = 100;
        }

        //�����

        int a = Random.Range(0, 10);
        if (gameManager.wall == false)
        {
            if (a == 5)
            {
                if (gameManager.noWeapons == true)//���� ������ ���� = 1
                {
                    gameManager.health -= 75;//�� �������� -75
                }

                else if (gameManager.knife == true)//���� ��� = 1
                {
                    gameManager.health -= 50;//�������� -50
                }

                else if (gameManager.gun == true)//���� �������� = 1
                {
                    gameManager.health -= 25;//�������� -25
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
