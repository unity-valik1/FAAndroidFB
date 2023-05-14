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


    public void EatRawMeat1Unit()//������ ����� ���� 1 ��
    {
        gameManager.time += 3;//����� +3
        gameManager.hunger += 25;//������������ +25

        int a = Random.Range(1, 4);//��������� ����� 1-2-3
        if (a == 3)//���� ������ ����� = 3
        {
            gameManager.health -= 25;//�� �������� -25
        }
    }


    public void EatBerries()//���������� �������
    {
        gameManager.time += 3;//����� +3
        gameManager.hunger += 30;//������������ +30
    }
    
    
    public void EatCannedFood()//������ ��������
    {
        gameManager.time += 3;//����� +3
        gameManager.hunger += 100;//������������ +100
    }
}
