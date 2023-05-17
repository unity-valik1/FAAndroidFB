using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] private ActiveMenu activeMenu;
    [SerializeField] private ActiveChapter activeChapter;
    [SerializeField] private ActiveCamp activeCamp;
    [SerializeField] private MusicMenu _musicMenu;
    [SerializeField] private MusicCamp _musicCamp;
    [SerializeField] private MusicCharter _musicCharter;
    [SerializeField] private MusicForest _musicForest;

    [Header("���������� ������")]
    [Tooltip("����� ���")] public int time = 0;
    [Tooltip("��������")] public int health = 100;
    [Tooltip("�������")] public int energy = 70;
    [Tooltip("����. �������")] public int maxEnergy = 0;
    [Tooltip("�����")] public int hunger = 200;
    [Tooltip("�������")] public int breath = 0;

    [Header("������")]
    [Header("�������")]
    [Tooltip("���������")] public bool coverlet = false;
    [Tooltip("�����")] public bool canopy = false;
    [Tooltip("���������� �������� �����")] public bool arrangeBedroom = false;
    [Tooltip("�������� �� ������")] public bool upgradeToHut = false;
    [Tooltip("�����")] public bool wall = false;

    [Header("������")]
    [Tooltip("�������� ������")] public int bonfire = 0;

    [Header("��������")]
    [Tooltip("����")] public bool magnifyingGlass = false;
    [Tooltip("�����")] public bool axe = false;
    [Tooltip("������")] public bool paper = false;
    [Tooltip("�����")] public int firewood = 0;
    [Tooltip("�������")] public int bottle = 0;
    [Tooltip("�������")] public int medicines = 0;
    [Tooltip("������")] public int money = 0;

    [Header("������")]
    [Tooltip("��� ������")] public bool noWeapons = true;
    [Tooltip("���")] public bool knife = false;
    [Tooltip("��������")] public bool gun = false;

    [Header("���")]
    [Tooltip("��������")] public int cannedFood = 0;
    [Tooltip("����")] public int water = 0;
    [Tooltip("�����")] public int berries = 0;
    [Tooltip("����� ����")] public int rawMeat = 0;
    [Tooltip("������� ����")] public int grilledMeat = 0;

    [Header("�������")]
    [Tooltip("������� ������")] public bool territorycamp = true;//������� ������ = �������
    [Tooltip("�������������� ���� �����")] public GameObject territoryCamp;
    [Tooltip("������� ��� ������")] public bool territorynocamp = false;//������� ������ = �� �������
    [Tooltip("�������������� ������ ��� ������ 0 ���")] public GameObject territoryNoCamp;

    [Header("��������������")]
    [Tooltip("�������������� � ����")] public bool nightwarning = false;
    [Tooltip("�������������� � ����")] public GameObject nightWarning;
    [Tooltip("�������������� � ��������� �������� �����")] public bool randomanimals = false;
    [Tooltip("�������������� � ��������� �������� �����")] public GameObject randomAnimals;

    [Header("��������UI ����")]
    [Tooltip("����")] public bool campUI = false;
    [Tooltip("������1")] public bool bonfire1UI = false;
    [Tooltip("������2")] public bool bonfire2UI = false;
    [Tooltip("���")] public bool houseUI = false;
    [Tooltip("�����")] public bool eatUI = false;
    [Tooltip("��")] public bool goUI = false;
    [Tooltip("���")] public bool forestUI = false;
    [Tooltip("�����")] public bool lakeUI = false;



    [Header("���������")]
    [Tooltip("������")] public bool musicMenu = true;//S
    [Tooltip("�������������")] public bool musicCharter = false;//S
    [Tooltip("�������������")] public bool musicCamp = false;//S
    [Tooltip("�������������")] public bool musicForest = false;//S

    //[Header("��������UI �������")]
    //[Tooltip("�������")] public bool[] charter;

    [Header("��������UI �������")]
    [Tooltip("�������")] public bool charter1UI = false;//S
    [Tooltip("�������")] public bool charter2UI = false;//S
    [Tooltip("�������")] public bool charter3UI = false;//S
    [Tooltip("�������")] public bool charter4UI = false;//S
    [Tooltip("�������")] public bool charter5UI = false;//S
    [Tooltip("�������")] public bool charter6UI = false;//S
    [Tooltip("�������")] public bool charter7UI = false;//S
    [Tooltip("�������")] public bool charter8UI = false;//S
    [Tooltip("�������")] public bool charter9UI = false;//S
    [Tooltip("�������")] public bool charter10UI = false;//S
    [Tooltip("�������")] public bool charter11UI = false;//S
    [Tooltip("�������")] public bool charter12UI = false;//S
    [Tooltip("�������")] public bool charter13UI = false;//S
    [Tooltip("�������")] public bool ToBeContinued = false;//S

    [Header("�������")]
    [Tooltip("����������")] public int saveGo = 0;//S

    private void Awake()
    {
        LoadPlayer6();
    }
    public void SavePlayer6()
    {
        SaveSystem.SavePlayer6(this);
    }
    public void LoadPlayer6()
    {
        PlayerIAP data = SaveSystem.LoadPlayer6();

        saveGo = data.saveGo;

    }
    public void ResetPlayer6()
    {
        SaveSystem.ResetPlayer6();
    }
    //���������� 0
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        //for (int i = 0; i < charter.Length; i++)
        //{
        //    charter[i] = data.charter[i];
        //}
        //charter[0] = data.charter[0];
        //charter[1] = data.charter[1];
        //charter[2] = data.charter[2];
        //charter[3] = data.charter[3];
        //charter[4] = data.charter[4];
        charter1UI = data.charter1UI;
        charter2UI = data.charter2UI;
        charter3UI = data.charter3UI;
        charter4UI = data.charter4UI;
        charter5UI = data.charter5UI;
        charter6UI = data.charter6UI;
        charter7UI = data.charter7UI;
        charter8UI = data.charter8UI;
        charter9UI = data.charter9UI;
        charter10UI = data.charter10UI;
        charter11UI = data.charter11UI;
        charter12UI = data.charter12UI;
        charter13UI = data.charter13UI;
        ToBeContinued = data.ToBeContinued;

        musicMenu = data.musicMenu;
        musicCharter = data.musicCharter;
        musicCamp = data.musicCamp;
        musicForest = data.musicForest;

        activeChapter.CharterActiveUpdate();    
        //activeCamp.CampActiveUpdate();
        //activeMenu.Load();
        _musicMenu.MenuMusicOnOff();
        _musicCharter.CharterMusicOnOff();
        //_musicCamp.CampMusicOnOff();
        //_musicForest.ForestMusicOnOff();
    }

    public void ResetPlayer()
    {
        SaveSystem.ResetPlayer();
    }

    //���������� 1

    public void SavePlayer1()
    {
        SaveSystem.SavePlayer1(this);
    }

    public void LoadPlayer1()
    {
        PlayerData data = SaveSystem.LoadPlayer1();

        //for (int i = 0; i < charter.Length; i++)
        //{
        //    charter[i] = data.charter[i];
        //}

        charter1UI = data.charter1UI;
        charter2UI = data.charter2UI;
        charter3UI = data.charter3UI;
        charter4UI = data.charter4UI;
        charter5UI = data.charter5UI;
        charter6UI = data.charter6UI;
        charter7UI = data.charter7UI;
        charter8UI = data.charter8UI;
        charter9UI = data.charter9UI;
        charter10UI = data.charter10UI;
        charter11UI = data.charter11UI;
        charter12UI = data.charter12UI;
        charter13UI = data.charter13UI;

        musicMenu = data.musicMenu;
        musicCharter = data.musicCharter;
        musicCamp = data.musicCamp;
        musicForest = data.musicForest;

        activeChapter.CharterActiveUpdate();
        //activeCamp.CampActiveUpdate();
        activeMenu.Load();
        _musicMenu.MenuMusicOnOff();
        _musicCharter.CharterMusicOnOff();
        //_musicCamp.CampMusicOnOff();
        //_musicForest.ForestMusicOnOff();
        SavePlayer();
    }

    public void ResetPlayer1()
    {
        SaveSystem.ResetPlayer1();
    }

    //���������� 2

    public void SavePlayer2()
    {
        SaveSystem.SavePlayer2(this);
    }

    public void LoadPlayer2()
    {
        PlayerData data = SaveSystem.LoadPlayer2();

        //for (int i = 0; i < charter.Length; i++)
        //{
        //    charter[i] = data.charter[i];
        //}

        charter1UI = data.charter1UI;
        charter2UI = data.charter2UI;
        charter3UI = data.charter3UI;
        charter4UI = data.charter4UI;
        charter5UI = data.charter5UI;
        charter6UI = data.charter6UI;
        charter7UI = data.charter7UI;
        charter8UI = data.charter8UI;
        charter9UI = data.charter9UI;
        charter10UI = data.charter10UI;
        charter11UI = data.charter11UI;
        charter12UI = data.charter12UI;
        charter13UI = data.charter13UI;

        musicMenu = data.musicMenu;
        musicCharter = data.musicCharter;
        musicCamp = data.musicCamp;
        musicForest = data.musicForest;

        activeChapter.CharterActiveUpdate();
        //activeCamp.CampActiveUpdate();
        activeMenu.Load();
        _musicMenu.MenuMusicOnOff();
        _musicCharter.CharterMusicOnOff();
        //_musicCamp.CampMusicOnOff();
        //_musicForest.ForestMusicOnOff();
        SavePlayer();
    }

    public void ResetPlayer2()
    {
        SaveSystem.ResetPlayer2();
    }

    //���������� 3

    public void SavePlayer3()
    {
        SaveSystem.SavePlayer3(this);
    }

    public void LoadPlayer3()
    {
        PlayerData data = SaveSystem.LoadPlayer3();

        //for (int i = 0; i < charter.Length; i++)
        //{
        //    charter[i] = data.charter[i];
        //}

        charter1UI = data.charter1UI;
        charter2UI = data.charter2UI;
        charter3UI = data.charter3UI;
        charter4UI = data.charter4UI;
        charter5UI = data.charter5UI;
        charter6UI = data.charter6UI;
        charter7UI = data.charter7UI;
        charter8UI = data.charter8UI;
        charter9UI = data.charter9UI;
        charter10UI = data.charter10UI;
        charter11UI = data.charter11UI;
        charter12UI = data.charter12UI;
        charter13UI = data.charter13UI;

        musicMenu = data.musicMenu;
        musicCharter = data.musicCharter;
        musicCamp = data.musicCamp;
        musicForest = data.musicForest;

        activeChapter.CharterActiveUpdate();
        //activeCamp.CampActiveUpdate();
        activeMenu.Load();
        _musicMenu.MenuMusicOnOff();
        _musicCharter.CharterMusicOnOff();
        //_musicCamp.CampMusicOnOff();
        //_musicForest.ForestMusicOnOff();
        SavePlayer();
    }

    public void ResetPlayer3()
    {
        SaveSystem.ResetPlayer3();
    }

    //���������� 4

    public void SavePlayer4()
    {
        SaveSystem.SavePlayer4(this);
    }

    public void LoadPlayer4()
    {
        PlayerData data = SaveSystem.LoadPlayer4();

        //for (int i = 0; i < charter.Length; i++)
        //{
        //    charter[i] = data.charter[i];
        //}

        charter1UI = data.charter1UI;
        charter2UI = data.charter2UI;
        charter3UI = data.charter3UI;
        charter4UI = data.charter4UI;
        charter5UI = data.charter5UI;
        charter6UI = data.charter6UI;
        charter7UI = data.charter7UI;
        charter8UI = data.charter8UI;
        charter9UI = data.charter9UI;
        charter10UI = data.charter10UI;
        charter11UI = data.charter11UI;
        charter12UI = data.charter12UI;
        charter13UI = data.charter13UI;

        musicMenu = data.musicMenu;
        musicCharter = data.musicCharter;
        musicCamp = data.musicCamp;
        musicForest = data.musicForest;

        activeChapter.CharterActiveUpdate();
        //activeCamp.CampActiveUpdate();
        activeMenu.Load();
        _musicMenu.MenuMusicOnOff();
        _musicCharter.CharterMusicOnOff();
        //_musicCamp.CampMusicOnOff();
        //_musicForest.ForestMusicOnOff();
        SavePlayer();
    }

    public void ResetPlayer4()
    {
        SaveSystem.ResetPlayer4();
    }

    //���������� 5

    public void SavePlayer5()
    {
        SaveSystem.SavePlayer5(this);
    }

    public void LoadPlayer5()
    {
        PlayerData data = SaveSystem.LoadPlayer5();

        //for (int i = 0; i < charter.Length; i++)
        //{
        //    charter[i] = data.charter[i];
        //}

        charter1UI = data.charter1UI;
        charter2UI = data.charter2UI;
        charter3UI = data.charter3UI;
        charter4UI = data.charter4UI;
        charter5UI = data.charter5UI;
        charter6UI = data.charter6UI;
        charter7UI = data.charter7UI;
        charter8UI = data.charter8UI;
        charter9UI = data.charter9UI;
        charter10UI = data.charter10UI;
        charter11UI = data.charter11UI;
        charter12UI = data.charter12UI;
        charter13UI = data.charter13UI;

        musicMenu = data.musicMenu;
        musicCharter = data.musicCharter;
        musicCamp = data.musicCamp;
        musicForest = data.musicForest;

        activeChapter.CharterActiveUpdate();
        //activeCamp.CampActiveUpdate();
        activeMenu.Load();
        _musicMenu.MenuMusicOnOff();
        _musicCharter.CharterMusicOnOff();
        //_musicCamp.CampMusicOnOff();
        //_musicForest.ForestMusicOnOff();
        SavePlayer();
    }

    public void ResetPlayer5()
    {
        SaveSystem.ResetPlayer5();
    }
}
