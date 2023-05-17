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

    [Header("Статистика игрока")]
    [Tooltip("Время дня")] public int time = 0;
    [Tooltip("Здоровье")] public int health = 100;
    [Tooltip("Энергия")] public int energy = 70;
    [Tooltip("Макс. энергия")] public int maxEnergy = 0;
    [Tooltip("Голод")] public int hunger = 200;
    [Tooltip("Дыхание")] public int breath = 0;

    [Header("Лагерь")]
    [Header("Кровать")]
    [Tooltip("Покрывало")] public bool coverlet = false;
    [Tooltip("Навес")] public bool canopy = false;
    [Tooltip("Обустроить спальное место")] public bool arrangeBedroom = false;
    [Tooltip("Улучшить до хижины")] public bool upgradeToHut = false;
    [Tooltip("Стена")] public bool wall = false;

    [Header("Костер")]
    [Tooltip("Здоровье костра")] public int bonfire = 0;

    [Header("Предметы")]
    [Tooltip("Лупа")] public bool magnifyingGlass = false;
    [Tooltip("Топор")] public bool axe = false;
    [Tooltip("Бумага")] public bool paper = false;
    [Tooltip("Дрова")] public int firewood = 0;
    [Tooltip("Бутылка")] public int bottle = 0;
    [Tooltip("Аптечка")] public int medicines = 0;
    [Tooltip("Деньги")] public int money = 0;

    [Header("Оружие")]
    [Tooltip("Нет оружия")] public bool noWeapons = true;
    [Tooltip("Нож")] public bool knife = false;
    [Tooltip("Пистолет")] public bool gun = false;

    [Header("Еда")]
    [Tooltip("Консерва")] public int cannedFood = 0;
    [Tooltip("Вода")] public int water = 0;
    [Tooltip("Ягоды")] public int berries = 0;
    [Tooltip("Сырое мясо")] public int rawMeat = 0;
    [Tooltip("Жареное мясо")] public int grilledMeat = 0;

    [Header("Локация")]
    [Tooltip("Локация лагеря")] public bool territorycamp = true;//Локация лагеря = активно
    [Tooltip("Предупреждение лечь спать")] public GameObject territoryCamp;
    [Tooltip("Локация вне лагеря")] public bool territorynocamp = false;//Локация лагеря = не активно
    [Tooltip("Предупреждение смерть вне лагеря 0 энр")] public GameObject territoryNoCamp;

    [Header("Предупреждения")]
    [Tooltip("Предупреждение о ночи")] public bool nightwarning = false;
    [Tooltip("Предупреждение о ночи")] public GameObject nightWarning;
    [Tooltip("Предупреждение о нападении животных ночью")] public bool randomanimals = false;
    [Tooltip("Предупреждение о нападении животных ночью")] public GameObject randomAnimals;

    [Header("ЭлементыUI Игра")]
    [Tooltip("Кэмп")] public bool campUI = false;
    [Tooltip("Костер1")] public bool bonfire1UI = false;
    [Tooltip("Костер2")] public bool bonfire2UI = false;
    [Tooltip("Дом")] public bool houseUI = false;
    [Tooltip("Спать")] public bool eatUI = false;
    [Tooltip("Го")] public bool goUI = false;
    [Tooltip("Лес")] public bool forestUI = false;
    [Tooltip("Озеро")] public bool lakeUI = false;



    [Header("Настройки")]
    [Tooltip("Музыка")] public bool musicMenu = true;//S
    [Tooltip("МузыкаСамолет")] public bool musicCharter = false;//S
    [Tooltip("МузыкаСамолет")] public bool musicCamp = false;//S
    [Tooltip("МузыкаСамолет")] public bool musicForest = false;//S

    //[Header("ЭлементыUI Самолет")]
    //[Tooltip("Самолет")] public bool[] charter;

    [Header("ЭлементыUI Самолет")]
    [Tooltip("Самолет")] public bool charter1UI = false;//S
    [Tooltip("Самолет")] public bool charter2UI = false;//S
    [Tooltip("Самолет")] public bool charter3UI = false;//S
    [Tooltip("Самолет")] public bool charter4UI = false;//S
    [Tooltip("Самолет")] public bool charter5UI = false;//S
    [Tooltip("Самолет")] public bool charter6UI = false;//S
    [Tooltip("Самолет")] public bool charter7UI = false;//S
    [Tooltip("Самолет")] public bool charter8UI = false;//S
    [Tooltip("Самолет")] public bool charter9UI = false;//S
    [Tooltip("Самолет")] public bool charter10UI = false;//S
    [Tooltip("Самолет")] public bool charter11UI = false;//S
    [Tooltip("Самолет")] public bool charter12UI = false;//S
    [Tooltip("Самолет")] public bool charter13UI = false;//S
    [Tooltip("Самолет")] public bool ToBeContinued = false;//S

    [Header("Покупка")]
    [Tooltip("Сохраненки")] public int saveGo = 0;//S

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
    //Сохраненка 0
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

    //Сохраненка 1

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

    //Сохраненка 2

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

    //Сохраненка 3

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

    //Сохраненка 4

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

    //Сохраненка 5

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
