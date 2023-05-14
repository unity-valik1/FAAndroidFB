using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightWarning : MonoBehaviour
{
    GameManager gameManager;


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        Nightwarning();//� ������ �������� ����
    }


    public void Nightwarning()//�������� ����
    {
        if (gameManager.time >= 90 && gameManager.nightwarning == false)//���� ����� >= 90 � �������������� � ���� = �� �������
        {
            gameManager.nightwarning = true;//�� �������������� � ���� = �������
            gameManager.nightWarning.SetActive(true);//�� �������������� � ���� = �������
        }
    }
}
