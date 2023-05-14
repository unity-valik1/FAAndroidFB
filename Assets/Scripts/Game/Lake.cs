using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lake : MonoBehaviour
{
    GameManager gameManager;


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }


    public void Breath()//����������� ����������� ������� ��� �����
    {
        //TODO ������� �� 0 �� 10
    }


    public void PracticeHoldingYourBreath()//������������� ����������� �������
    {
        gameManager.time += 10;//����� +10
        gameManager.energy -= 15;//��������� -15
        gameManager.hunger -= 15;//������������ -15
    }


    public void DiveIntoThePlane()//������� � �������
    {
        gameManager.time += 15;//����� +15
        gameManager.energy -= 15;//��������� -15
        gameManager.hunger -= 15;//������������ -15
    }
}
