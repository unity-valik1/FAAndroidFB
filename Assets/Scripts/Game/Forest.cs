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


    public void BigGameHunting()//����� �� ������� ����
    {
        gameManager.time += 50;//����� +50
        gameManager.energy -= 50;//��������� -50
        gameManager.hunger -= 50;//������������ -50
    }


    public void SmallGameHunting()//����� �� ������ ����
    {
        gameManager.time += 30;//����� +30
        gameManager.energy -= 30;//��������� -30
        gameManager.hunger -= 30;//������������ -30
    }


    public void LookForFirewood()//������ �����
    {
        gameManager.time += 10;//����� +10
        gameManager.energy -= 10;//��������� -10
        gameManager.hunger -= 10;//������������ -10

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


    public void PickingBerries()//�������� �����
    {
        gameManager.time += 10;//����� +10
        gameManager.energy -= 3;//��������� -3
        gameManager.hunger -= 3;//������������ -3
    }
}
