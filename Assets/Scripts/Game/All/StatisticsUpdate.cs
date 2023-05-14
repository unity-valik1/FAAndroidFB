using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class StatisticsUpdate : MonoBehaviour
{
    GameManager gameManager;

    [Header("���������� ������")]
    [Tooltip("�����")] public TMP_Text timeText;//�������� ������� � ����
    [Tooltip("��������")] public TMP_Text healthText;//�������� �������� � ����
    [Tooltip("�������")] public TMP_Text energyText;//�������� ��������� � ����
    [Tooltip("�����")] public TMP_Text hungerText;//�������� ������ � ����
    [Tooltip("�������")] public TMP_Text breathText;//�������� ������� � ����

    [Header("����� �����")]
    [Tooltip("����")] public GameObject morning;//���� ����
    [Tooltip("����")] public GameObject day;//���� ���
    [Tooltip("�����")] public GameObject evening;//���� ������
    [Tooltip("����")] public GameObject night;//���� ����

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        NewTime();
        NewEnergy();
        NewHunger();
        NewHealth();
    }


    public void NewTime()//���������� ������� �����
    {

        if (gameManager.time >= 0 && gameManager.time <= 20)//���� ����� >= 0 � <= 20
        {
            morning.SetActive(true);
            day.SetActive(false);
            evening.SetActive(false);
            night.SetActive(false);
        }

        else if (gameManager.time >= 21 && gameManager.time <= 70)//���� ����� >= 21 � <= 70
        {
            morning.SetActive(false);
            day.SetActive(true);
            evening.SetActive(false);
            night.SetActive(false);
        }

        else if (gameManager.time >= 71 && gameManager.time <= 90)//���� ����� >= 71 � <= 90
        {
            morning.SetActive(false);
            day.SetActive(false);
            evening.SetActive(true);
            night.SetActive(false);
        }

        else if (gameManager.time >= 91 && gameManager.time <= 120 || gameManager.time > 120)//���� ����� >= 91 � <= 120 ��� ����� > 120
        {
            morning.SetActive(false);
            day.SetActive(false);
            evening.SetActive(false);
            night.SetActive(true);
        }
    }


    public void NewEnergy()//���������� ������� ���������
    {
        if (gameManager.maxEnergy == 0)//���� ����. ������� = 0
        {
            if (gameManager.energy > 70)//���� ������� > 70
            {
                gameManager.energy = 70;//�� ������� = 70
            }
            else if (gameManager.energy <= 70 && gameManager.energy >= 52)//���� ������� <= 70 � >= 52
            {
                energyText.text = "�������: ���� ����";//�� ������ �������: ����� ���
            }
            else if (gameManager.energy <= 51 && gameManager.energy >= 36)//���� ������� <= 51 � >= 36
            {
                energyText.text = "�������: ������ ���";//�� ������ �������: ������ ���
            }
            else if (gameManager.energy <= 35 && gameManager.energy >= 19)//���� ������� <= 35 � >= 19
            {
                energyText.text = "�������: ����� ���";//�� ������ �������: ���� ���
            }
            else if (gameManager.energy <= 18 && gameManager.energy >= 1)//���� ������� <= 18 � >= 1
            {
                energyText.text = "�������: ����� ����";//�� ������ �������: ����� ����
            }
            else if (gameManager.energy <= 0 && gameManager.territorycamp == true)//���� ������� <= 0
            {
                gameManager.territoryCamp.SetActive(true);
            }
            else if (gameManager.energy <= 0 && gameManager.territorynocamp == true)//���� ������� <= 0
            {
                gameManager.territoryNoCamp.SetActive(true);
            }
        }



        else if (gameManager.maxEnergy == 1)//���� ����. ������� = 1
        {
            if (gameManager.energy > 80)//���� ������� > 80
            {
                gameManager.energy = 80;//�� ������� = 80
            }
            else if (gameManager.energy <= 80 && gameManager.energy >= 61)//���� ������� <= 80 � >= 61
            {
                energyText.text = "�������: ���� ����";//�� ������ �������: ����� ���
            }
            else if (gameManager.energy <= 60 && gameManager.energy >= 41)//���� ������� <= 60 � >= 41
            {
                energyText.text = "�������: ������ ���";//�� ������ �������: ������ ���
            }
            else if (gameManager.energy <= 40 && gameManager.energy >= 21)//���� ������� <= 40 � >= 21
            {
                energyText.text = "�������: ����� ���";//�� ������ �������: ���� ���
            }
            else if (gameManager.energy <= 20 && gameManager.energy >= 1)//���� ������� <= 20 � >= 1
            {
                energyText.text = "�������: ����� ����";//�� ������ �������: ����� ����
            }
            else if (gameManager.energy <= 0)//���� ������� <= 0
            {
                energyText.text = "�������: ����";//�� ������ �������: ����
            }
        }

        else if (gameManager.maxEnergy == 2)//���� ����. ������� = 2
        {
            if (gameManager.energy > 90)//���� ������� > 90
            {
                gameManager.energy = 90;//�� ������� = 90
            }
            else if (gameManager.energy <= 90 && gameManager.energy >= 68)//���� ������� <= 90 � >= 68
            {
                energyText.text = "�������: ���� ����";//�� ������ �������: ����� ���
            }
            else if (gameManager.energy <= 67 && gameManager.energy >= 45)//���� ������� <= 67 � >= 45
            {
                energyText.text = "�������: ������ ���";//�� ������ �������: ������ ���
            }
            else if (gameManager.energy <= 44 && gameManager.energy >= 23)//���� ������� <= 44 � >= 23
            {
                energyText.text = "�������: ����� ���";//�� ������ �������: ���� ���
            }
            else if (gameManager.energy <= 22 && gameManager.energy >= 1)//���� ������� <= 22 � >= 1
            {
                energyText.text = "�������: ����� ����";//�� ������ �������: ����� ����
            }
            else if (gameManager.energy <= 0)//���� ������� <= 0
            {
                energyText.text = "�������: ����";//�� ������ �������: ����
            }
        }

        else if (gameManager.maxEnergy == 3)//���� ����. ������� = 3
        {
            if (gameManager.energy > 100)//���� ������� > 100
            {
                gameManager.energy = 100;//�� ������� = 100
            }
            else if (gameManager.energy <= 100 && gameManager.energy >= 76)//���� ������� <= 100 � >= 76
            {
                energyText.text = "�������: ���� ����";//�� ������ �������: ����� ���
            }
            else if (gameManager.energy <= 75 && gameManager.energy >= 51)//���� ������� <= 75 � >= 51
            {
                energyText.text = "�������: ������ ���";//�� ������ �������: ������ ���
            }
            else if (gameManager.energy <= 50 && gameManager.energy >= 26)//���� ������� <= 50 � >= 26
            {
                energyText.text = "�������: ����� ���";//�� ������ �������: ���� ���
            }
            else if (gameManager.energy <= 25 && gameManager.energy >= 1)//���� ������� <= 25 � >= 1
            {
                energyText.text = "�������: ����� ����";//�� ������ �������: ����� ����
            }
            else if (gameManager.energy <= 0)//���� ������� <= 0
            {
                energyText.text = "�������: ����";//�� ������ �������: ����
            }
        }

        else if (gameManager.maxEnergy == 4)//���� ����. ������� = 4
        {
            if (gameManager.energy > 110)//���� ������� > 110
            {
                gameManager.energy = 110;//�� ������� = 110
            }
            else if (gameManager.energy <= 110 && gameManager.energy >= 83)//���� ������� <= 110 � >= 83
            {
                energyText.text = "�������: ���� ����";//�� ������ �������: ����� ���
            }
            else if (gameManager.energy <= 82 && gameManager.energy >= 55)//���� ������� <= 82 � >= 55
            {
                energyText.text = "�������: ������ ���";//�� ������ �������: ������ ���
            }
            else if (gameManager.energy <= 54 && gameManager.energy >= 28)//���� ������� <= 54 � >= 28
            {
                energyText.text = "�������: ����� ���";//�� ������ �������: ���� ���
            }
            else if (gameManager.energy <= 27 && gameManager.energy >= 1)//���� ������� <= 27 � >= 1
            {
                energyText.text = "�������: ����� ����";//�� ������ �������: ����� ����
            }
            else if (gameManager.energy <= 0)//���� ������� <= 0
            {
                energyText.text = "�������: ����";//�� ������ �������: ����
            }
        }

        else if (gameManager.maxEnergy == 5)//���� ����. ������� = 5
        {
            if (gameManager.energy > 120)//���� ������� > 120
            {
                gameManager.energy = 120;//�� ������� = 120
            }
            else if (gameManager.energy <= 120 && gameManager.energy >= 91)//���� ������� <= 120 � >= 91
            {
                energyText.text = "�������: ���� ����";//�� ������ �������: ����� ���
            }
            else if (gameManager.energy <= 90 && gameManager.energy >= 61)//���� ������� <= 90 � >= 61
            {
                energyText.text = "�������: ������ ���";//�� ������ �������: ������ ���
            }
            else if (gameManager.energy <= 60 && gameManager.energy >= 31)//���� ������� <= 60 � >= 31
            {
                energyText.text = "�������: ����� ���";//�� ������ �������: ���� ���
            }
            else if (gameManager.energy <= 30 && gameManager.energy >= 1)//���� ������� <= 30 � >= 1
            {
                energyText.text = "�������: ����� ����";//�� ������ �������: ����� ����
            }
            else if (gameManager.energy <= 0)//���� ������� <= 0
            {
                energyText.text = "�������: ����";//�� ������ �������: �������
            }
        }
    }





    public void NewHunger()//���������� ������ ���������
    {
        if (gameManager.hunger > 200)//���� ����� > 200
        {
            gameManager.hunger = 200;//�� ����� = 200
            hungerText.text = "�����: �����";//�� ������ �����: �����
        }

        else if (gameManager.hunger <= 200 && gameManager.hunger >= 150)//���� ����� <= 200 � >= 150
        {
            hungerText.text = "�����: �����";//�� ������ �����: �����
        }

        else if (gameManager.hunger <= 149 && gameManager.hunger >= 100)//���� ����� <= 149 � >= 100
        {
            hungerText.text = "�����: ��������� ��";//�� ������ �����: ��������� ��
        }

        else if (gameManager.hunger <= 99 && gameManager.hunger >= 50)//���� ����� <= 99 � >= 50
        {
            hungerText.text = "�����: ��������";//�� ������ �����: ��������
        }

        else if (gameManager.hunger <= 49 && gameManager.hunger >= 1)//���� ����� <= 49 � >= 1
        {
            hungerText.text = "�����: ����� ��������";//�� ������ �����: ����� ��������
        }

        else if (gameManager.hunger <= 0)//���� ����� <= 0 ���
        {
            hungerText.text = "�����: ���� �� ������";//�� ������ �����: ����
        }
    }


    public void NewHealth()//���������� �������� ���������
    {
        if (gameManager.health > 100)//���� �������� > 100
        {
            gameManager.health = 100;//�� �������� = 100
            healthText.text = "��������: ��������";//�� ������ ��������: ��������
        }

        else if (gameManager.health <= 100 && gameManager.health >= 76)//���� �������� <= 100 � >= 76
        {
            healthText.text = "��������: ��������";//�� ������ ��������: ��������
        }

        else if (gameManager.health <= 75 && gameManager.health >= 51)//���� �������� <= 75 � >= 51
        {
            healthText.text = "��������: �������";//�� ������ ��������: �������
        }

        else if (gameManager.health <= 50 && gameManager.health >= 26)//���� �������� <= 50 � >= 26
        {
            healthText.text = "��������: ������";//�� ������ ��������: ������
        }

        else if (gameManager.health <= 25 && gameManager.health >= 1)//���� �������� <= 25 � >= 1
        {
            healthText.text = "��������: ����� ������";//�� ������ ��������: ����� ������
        }

        else if (gameManager.health <= 0)//���� �������� <= 0 ���
        {
            healthText.text = "��������: ����";//�� ������ ��������: ����
        }
    }
}
