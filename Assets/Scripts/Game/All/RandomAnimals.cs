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
        if (gameManager.time >= 90 && gameManager.randomanimals == false)//���� ����� >= 90 � �������������� � ��������� �������� ����� = �� �������
        {
            int a = Random.Range(0, 11);// � = ������ �� 0 �� 10
            if (a == 5)//���� � = 5
            {
                if (gameManager.randomanimals == true)//���� ������ ���� = �������
                {
                    gameManager.nightwarning = true;//�� �������������� � ��������� �������� ����� = �������
                    gameManager.health -= 50;//�� �������� -50
                }

                else if (gameManager.knife == true)//���� ��� ���� = �������
                {
                    gameManager.nightwarning = true;//�� �������������� � ��������� �������� ����� = �������
                    gameManager.health -= 25;//�������� -25
                }

                else if (gameManager.gun == true)//���� �������� ���� = �������
                {
                    gameManager.nightwarning = true;//�� �������������� � ��������� �������� ����� = �������
                    gameManager.health += 0;//�������� �������� �������
                }
            }
        }
    }
}
