using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] private ActiveMenu activeMenu;
    [SerializeField] private ActiveChapter activeChapter;
    [SerializeField] private MusicMenu _musicMenu;
    [SerializeField] private MusicCharter _musicCharter;
    //[SerializeField] private ActiveCamp activeCamp;
    //[SerializeField] private MusicCamp _musicCamp;
    //[SerializeField] private MusicForest _musicForest;

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

    [Header("ЭлементыUI Самолет")]
    [Tooltip("Самолет")] public int[] charter = new int[50];

    //[Header("ЭлементыUI Самолет")]
    //[Tooltip("Самолет")] public bool charter1UI = false;//S
    //[Tooltip("Самолет")] public bool charter2UI = false;//S
    //[Tooltip("Самолет")] public bool charter3UI = false;//S
    //[Tooltip("Самолет")] public bool charter4UI = false;//S
    //[Tooltip("Самолет")] public bool charter5UI = false;//S
    //[Tooltip("Самолет")] public bool charter6UI = false;//S
    //[Tooltip("Самолет")] public bool charter7UI = false;//S
    //[Tooltip("Самолет")] public bool charter8UI = false;//S
    //[Tooltip("Самолет")] public bool charter9UI = false;//S
    //[Tooltip("Самолет")] public bool charter10UI = false;//S
    //[Tooltip("Самолет")] public bool charter11UI = false;//S
    //[Tooltip("Самолет")] public bool charter12UI = false;//S
    //[Tooltip("Самолет")] public bool charter13UI = false;//S
    //[Tooltip("Самолет")] public bool charter14UI = false;//S
    //[Tooltip("Самолет")] public bool charter15UI = false;//S
    //[Tooltip("Самолет")] public bool charter16UI = false;//S
    //[Tooltip("Самолет")] public bool charter17UI = false;//S
    //[Tooltip("Самолет")] public bool charter18UI = false;//S
    //[Tooltip("Самолет")] public bool charter19UI = false;//S
    //[Tooltip("Самолет")] public bool charter20UI = false;//S
    //[Tooltip("Самолет")] public bool charter21UI = false;//S
    //[Tooltip("Самолет")] public bool charter22UI = false;//S
    //[Tooltip("Самолет")] public bool charter23UI = false;//S
    //[Tooltip("Самолет")] public bool charter24UI = false;//S
    //[Tooltip("Самолет")] public bool charter25UI = false;//S
    //[Tooltip("Самолет")] public bool charter26UI = false;//S
    //[Tooltip("Самолет")] public bool charter27UI = false;//S
    //[Tooltip("Самолет")] public bool charter28UI = false;//S
    //[Tooltip("Самолет")] public bool charter29UI = false;//S
    //[Tooltip("Самолет")] public bool charter30UI = false;//S
    //[Tooltip("Самолет")] public bool charter31UI = false;//S
    //[Tooltip("Самолет")] public bool charter32UI = false;//S
    //[Tooltip("Самолет")] public bool charter33UI = false;//S
    //[Tooltip("Самолет")] public bool charter34UI = false;//S
    //[Tooltip("Самолет")] public bool charter35UI = false;//S
    //[Tooltip("Самолет")] public bool charter36UI = false;//S
    //[Tooltip("Самолет")] public bool charter37UI = false;//S
    //[Tooltip("Самолет")] public bool charter38UI = false;//S
    //[Tooltip("Самолет")] public bool charter39UI = false;//S
    //[Tooltip("Самолет")] public bool charter40UI = false;//S
    //[Tooltip("Самолет")] public bool charter41UI = false;//S
    //[Tooltip("Самолет")] public bool charter42UI = false;//S
    //[Tooltip("Самолет")] public bool charter43UI = false;//S
    //[Tooltip("Самолет")] public bool charter44UI = false;//S
    //[Tooltip("Самолет")] public bool charter45UI = false;//S
    //[Tooltip("Самолет")] public bool charter46UI = false;//S
    //[Tooltip("Самолет")] public bool charter47UI = false;//S
    //[Tooltip("Самолет")] public bool charter48UI = false;//S
    //[Tooltip("Самолет")] public bool charter49UI = false;//S
    //[Tooltip("Самолет")] public bool charter50UI = false;//S

    [Header("Покупка")]
    [Tooltip("Сохраненки")] public int saveGo = 0;//S

    [Header("Переменные в главе")]
    [Tooltip("Алкоголь")] public int b_alcohol = 0;//S
    [Tooltip("Алкоголь")] public int b_ignore_it = 0;//S
    [Tooltip("Алкоголь")] public int b_any_other_flights = 0;//S
    [Tooltip("Алкоголь")] public int b_visit_the_cigar_bar = 0;//S
    [Tooltip("Алкоголь")] public int b_grab_some_food = 0;//S
    [Tooltip("Алкоголь")] public int b_ask_about_her_toys = 0;//S
    [Tooltip("Алкоголь")] public int b_make_conversation = 0;//S
    [Tooltip("Алкоголь")] public int b_try_to_find_her_parents = 0;//S
    [Tooltip("Алкоголь")] public int b_take_the_girl_to_an_officer = 0;//S
    [Tooltip("Алкоголь")] public int b_we_were_looking = 0;//S
    [Tooltip("Алкоголь")] public int b_go_to_the_bookstore = 0;//S
    [Tooltip("Алкоголь")] public int b_talk_with_a_stranger = 0;//S
    [Tooltip("Алкоголь")] public int b_buy_book = 0;//S
    [Tooltip("Алкоголь")] public int b_ignore_it_2 = 0;//S
    [Tooltip("Алкоголь")] public int b_too_much_of_a_risk = 0;//S
    [Tooltip("Алкоголь")] public int b_give_me_some_time = 0;//S
    [Tooltip("Алкоголь")] public int b_nevermind = 0;//S
    [Tooltip("Алкоголь")] public int b_check_the_weather = 0;//S
    [Tooltip("Алкоголь")] public int b_the_lounge = 0;//S
    [Tooltip("Алкоголь")] public int b_the_food_court = 0;//S
    [Tooltip("Алкоголь")] public int b_halls = 0;//S
    [Tooltip("Алкоголь")] public int b_gates = 0;//S
    [Tooltip("Алкоголь")] public int b_fight = 0;//S
    [Tooltip("Алкоголь")] public int b_looking_around = 0;//S
    [Tooltip("Алкоголь")] public int b_check_for_survivors = 0;//S
    [Tooltip("Алкоголь")] public int b_push_the_chair = 0;//S
    [Tooltip("Алкоголь")] public int climb_over = 0;//S
    [Tooltip("Алкоголь")] public int b_move_the_luggage = 0;//S
    [Tooltip("Алкоголь")] public int b_pick_up_the_tray_table = 0;//S
    [Tooltip("Алкоголь")] public int b_pick_up_the_bent_metal = 0;//S
    [Tooltip("Алкоголь")] public int b_tuck_in_the_loose_wires = 0;//S


    private void Awake()
    {
        LoadPlayer6();
    }

    //Сохраненка покупок
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

        for (int i = 0; i < data.charter.Length; i++)
        {
            charter[i] = data.charter[i];
        }

        b_alcohol = data.b_alcohol;
        b_ignore_it = data.b_ignore_it;
        b_any_other_flights = data.b_any_other_flights;
        b_visit_the_cigar_bar = data.b_visit_the_cigar_bar;
        b_grab_some_food = data.b_grab_some_food;
        b_ask_about_her_toys = data.b_ask_about_her_toys;
        b_make_conversation = data.b_make_conversation;
        b_try_to_find_her_parents = data.b_try_to_find_her_parents;
        b_take_the_girl_to_an_officer = data.b_take_the_girl_to_an_officer;
        b_we_were_looking = data.b_we_were_looking;
        b_go_to_the_bookstore = data.b_go_to_the_bookstore;
        b_talk_with_a_stranger = data.b_talk_with_a_stranger;
        b_buy_book = data.b_buy_book;
        b_ignore_it_2 = data.b_ignore_it_2;
        b_too_much_of_a_risk = data.b_too_much_of_a_risk;
        b_give_me_some_time = data.b_give_me_some_time;
        b_nevermind = data.b_nevermind;
        b_check_the_weather = data.b_check_the_weather;
        b_the_lounge = data.b_the_lounge;
        b_the_food_court = data.b_the_food_court;
        b_halls = data.b_halls;
        b_gates = data.b_gates;
        b_fight = data.b_fight;
        b_looking_around = data.b_looking_around;
        b_check_for_survivors = data.b_check_for_survivors;
        b_push_the_chair = data.b_push_the_chair;
        b_move_the_luggage = data.b_move_the_luggage;
        b_pick_up_the_tray_table = data.b_pick_up_the_tray_table;
        b_pick_up_the_bent_metal = data.b_pick_up_the_bent_metal;
        b_tuck_in_the_loose_wires = data.b_tuck_in_the_loose_wires;
        //charter1UI = data.charter1UI;
        //charter2UI = data.charter2UI;
        //charter3UI = data.charter3UI;
        //charter4UI = data.charter4UI;
        //charter5UI = data.charter5UI;
        //charter6UI = data.charter6UI;
        //charter7UI = data.charter7UI;
        //charter8UI = data.charter8UI;
        //charter9UI = data.charter9UI;
        //charter10UI = data.charter10UI;
        //charter11UI = data.charter11UI;
        //charter12UI = data.charter12UI;
        //charter13UI = data.charter13UI;
        //charter14UI = data.charter14UI;
        //charter15UI = data.charter15UI;
        //charter16UI = data.charter16UI;
        //charter17UI = data.charter17UI;
        //charter18UI = data.charter18UI;
        //charter19UI = data.charter19UI;
        //charter20UI = data.charter20UI;
        //charter21UI = data.charter21UI;
        //charter22UI = data.charter22UI;
        //charter23UI = data.charter23UI;
        //charter24UI = data.charter24UI;
        //charter25UI = data.charter25UI;
        //charter26UI = data.charter26UI;
        //charter27UI = data.charter27UI;
        //charter28UI = data.charter28UI;
        //charter29UI = data.charter29UI;
        //charter30UI = data.charter30UI;
        //charter31UI = data.charter31UI;
        //charter32UI = data.charter32UI;
        //charter33UI = data.charter33UI;
        //charter34UI = data.charter34UI;
        //charter35UI = data.charter35UI;
        //charter36UI = data.charter36UI;
        //charter37UI = data.charter37UI;
        //charter38UI = data.charter38UI;
        //charter39UI = data.charter39UI;
        //charter40UI = data.charter40UI;
        //charter41UI = data.charter41UI;
        //charter42UI = data.charter42UI;
        //charter43UI = data.charter43UI;
        //charter44UI = data.charter44UI;
        //charter45UI = data.charter45UI;
        //charter46UI = data.charter46UI;
        //charter47UI = data.charter47UI;
        //charter48UI = data.charter48UI;
        //charter49UI = data.charter49UI;
        //charter50UI = data.charter50UI;

        activeChapter.CharterActiveUpdate();
        _musicMenu.StopMusic();
        _musicCharter.PlayMusic(0);
        //activeCamp.CampActiveUpdate();
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

        for (int i = 0; i < data.charter.Length; i++)
        {
            charter[i] = data.charter[i];
        }


        b_alcohol = data.b_alcohol;
        b_ignore_it = data.b_ignore_it;
        b_any_other_flights = data.b_any_other_flights;
        b_visit_the_cigar_bar = data.b_visit_the_cigar_bar;
        b_grab_some_food = data.b_grab_some_food;
        b_ask_about_her_toys = data.b_ask_about_her_toys;
        b_make_conversation = data.b_make_conversation;
        b_try_to_find_her_parents = data.b_try_to_find_her_parents;
        b_take_the_girl_to_an_officer = data.b_take_the_girl_to_an_officer;
        b_we_were_looking = data.b_we_were_looking;
        b_go_to_the_bookstore = data.b_go_to_the_bookstore;
        b_talk_with_a_stranger = data.b_talk_with_a_stranger;
        b_buy_book = data.b_buy_book;
        b_ignore_it_2 = data.b_ignore_it_2;
        b_too_much_of_a_risk = data.b_too_much_of_a_risk;
        b_give_me_some_time = data.b_give_me_some_time;
        b_nevermind = data.b_nevermind;
        b_check_the_weather = data.b_check_the_weather;
        b_the_lounge = data.b_the_lounge;
        b_the_food_court = data.b_the_food_court;
        b_halls = data.b_halls;
        b_gates = data.b_gates;
        b_fight = data.b_fight;
        b_looking_around = data.b_looking_around;
        b_check_for_survivors = data.b_check_for_survivors;
        b_push_the_chair = data.b_push_the_chair;
        b_move_the_luggage = data.b_move_the_luggage;
        b_pick_up_the_tray_table = data.b_pick_up_the_tray_table;
        b_pick_up_the_bent_metal = data.b_pick_up_the_bent_metal;
        b_tuck_in_the_loose_wires = data.b_tuck_in_the_loose_wires;
        //charter1UI = data.charter1UI;
        //charter2UI = data.charter2UI;
        //charter3UI = data.charter3UI;
        //charter4UI = data.charter4UI;
        //charter5UI = data.charter5UI;
        //charter6UI = data.charter6UI;
        //charter7UI = data.charter7UI;
        //charter8UI = data.charter8UI;
        //charter9UI = data.charter9UI;
        //charter10UI = data.charter10UI;
        //charter11UI = data.charter11UI;
        //charter12UI = data.charter12UI;
        //charter13UI = data.charter13UI;
        //charter14UI = data.charter14UI;
        //charter15UI = data.charter15UI;
        //charter16UI = data.charter16UI;
        //charter17UI = data.charter17UI;
        //charter18UI = data.charter18UI;
        //charter19UI = data.charter19UI;
        //charter20UI = data.charter20UI;
        //charter21UI = data.charter21UI;
        //charter22UI = data.charter22UI;
        //charter23UI = data.charter23UI;
        //charter24UI = data.charter24UI;
        //charter25UI = data.charter25UI;
        //charter26UI = data.charter26UI;
        //charter27UI = data.charter27UI;
        //charter28UI = data.charter28UI;
        //charter29UI = data.charter29UI;
        //charter30UI = data.charter30UI;
        //charter31UI = data.charter31UI;
        //charter32UI = data.charter32UI;
        //charter33UI = data.charter33UI;
        //charter34UI = data.charter34UI;
        //charter35UI = data.charter35UI;
        //charter36UI = data.charter36UI;
        //charter37UI = data.charter37UI;
        //charter38UI = data.charter38UI;
        //charter39UI = data.charter39UI;
        //charter40UI = data.charter40UI;
        //charter41UI = data.charter41UI;
        //charter42UI = data.charter42UI;
        //charter43UI = data.charter43UI;
        //charter44UI = data.charter44UI;
        //charter45UI = data.charter45UI;
        //charter46UI = data.charter46UI;
        //charter47UI = data.charter47UI;
        //charter48UI = data.charter48UI;
        //charter49UI = data.charter49UI;
        //charter50UI = data.charter50UI;

        activeMenu.Load1();
        _musicMenu.StopMusic();
        activeChapter.CharterActiveUpdate();
        _musicCharter.PlayMusic(0);
        //activeCamp.CampActiveUpdate();
        //_musicCamp.CampMusicOnOff();
        //_musicForest.ForestMusicOnOff();
        SavePlayer();
        FireBaseAnalyticsEvents.EventsLoadGame1("LoadGame1");
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

        for (int i = 0; i < data.charter.Length; i++)
        {
            charter[i] = data.charter[i];
        }

        b_alcohol = data.b_alcohol;
        b_ignore_it = data.b_ignore_it;
        b_any_other_flights = data.b_any_other_flights;
        b_visit_the_cigar_bar = data.b_visit_the_cigar_bar;
        b_grab_some_food = data.b_grab_some_food;
        b_ask_about_her_toys = data.b_ask_about_her_toys;
        b_make_conversation = data.b_make_conversation;
        b_try_to_find_her_parents = data.b_try_to_find_her_parents;
        b_take_the_girl_to_an_officer = data.b_take_the_girl_to_an_officer;
        b_we_were_looking = data.b_we_were_looking;
        b_go_to_the_bookstore = data.b_go_to_the_bookstore;
        b_talk_with_a_stranger = data.b_talk_with_a_stranger;
        b_buy_book = data.b_buy_book;
        b_ignore_it_2 = data.b_ignore_it_2;
        b_too_much_of_a_risk = data.b_too_much_of_a_risk;
        b_give_me_some_time = data.b_give_me_some_time;
        b_nevermind = data.b_nevermind;
        b_check_the_weather = data.b_check_the_weather;
        b_the_lounge = data.b_the_lounge;
        b_the_food_court = data.b_the_food_court;
        b_halls = data.b_halls;
        b_gates = data.b_gates;
        b_fight = data.b_fight;
        b_looking_around = data.b_looking_around;
        b_check_for_survivors = data.b_check_for_survivors;
        b_push_the_chair = data.b_push_the_chair;
        b_move_the_luggage = data.b_move_the_luggage;
        b_pick_up_the_tray_table = data.b_pick_up_the_tray_table;
        b_pick_up_the_bent_metal = data.b_pick_up_the_bent_metal;
        b_tuck_in_the_loose_wires = data.b_tuck_in_the_loose_wires;
        //charter1UI = data.charter1UI;
        //charter2UI = data.charter2UI;
        //charter3UI = data.charter3UI;
        //charter4UI = data.charter4UI;
        //charter5UI = data.charter5UI;
        //charter6UI = data.charter6UI;
        //charter7UI = data.charter7UI;
        //charter8UI = data.charter8UI;
        //charter9UI = data.charter9UI;
        //charter10UI = data.charter10UI;
        //charter11UI = data.charter11UI;
        //charter12UI = data.charter12UI;
        //charter13UI = data.charter13UI;
        //charter14UI = data.charter14UI;
        //charter15UI = data.charter15UI;
        //charter16UI = data.charter16UI;
        //charter17UI = data.charter17UI;
        //charter18UI = data.charter18UI;
        //charter19UI = data.charter19UI;
        //charter20UI = data.charter20UI;
        //charter21UI = data.charter21UI;
        //charter22UI = data.charter22UI;
        //charter23UI = data.charter23UI;
        //charter24UI = data.charter24UI;
        //charter25UI = data.charter25UI;
        //charter26UI = data.charter26UI;
        //charter27UI = data.charter27UI;
        //charter28UI = data.charter28UI;
        //charter29UI = data.charter29UI;
        //charter30UI = data.charter30UI;
        //charter31UI = data.charter31UI;
        //charter32UI = data.charter32UI;
        //charter33UI = data.charter33UI;
        //charter34UI = data.charter34UI;
        //charter35UI = data.charter35UI;
        //charter36UI = data.charter36UI;
        //charter37UI = data.charter37UI;
        //charter38UI = data.charter38UI;
        //charter39UI = data.charter39UI;
        //charter40UI = data.charter40UI;
        //charter41UI = data.charter41UI;
        //charter42UI = data.charter42UI;
        //charter43UI = data.charter43UI;
        //charter44UI = data.charter44UI;
        //charter45UI = data.charter45UI;
        //charter46UI = data.charter46UI;
        //charter47UI = data.charter47UI;
        //charter48UI = data.charter48UI;
        //charter49UI = data.charter49UI;
        //charter50UI = data.charter50UI;

        activeMenu.Load1();
        _musicMenu.StopMusic();
        activeChapter.CharterActiveUpdate();
        _musicCharter.PlayMusic(0);
        //activeCamp.CampActiveUpdate();
        //_musicCamp.CampMusicOnOff();
        //_musicForest.ForestMusicOnOff();
        SavePlayer();
        FireBaseAnalyticsEvents.EventsLoadGame2("LoadGame2");
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

        for (int i = 0; i < data.charter.Length; i++)
        {
            charter[i] = data.charter[i];
        }

        b_alcohol = data.b_alcohol;
        b_ignore_it = data.b_ignore_it;
        b_any_other_flights = data.b_any_other_flights;
        b_visit_the_cigar_bar = data.b_visit_the_cigar_bar;
        b_grab_some_food = data.b_grab_some_food;
        b_ask_about_her_toys = data.b_ask_about_her_toys;
        b_make_conversation = data.b_make_conversation;
        b_try_to_find_her_parents = data.b_try_to_find_her_parents;
        b_take_the_girl_to_an_officer = data.b_take_the_girl_to_an_officer;
        b_we_were_looking = data.b_we_were_looking;
        b_go_to_the_bookstore = data.b_go_to_the_bookstore;
        b_talk_with_a_stranger = data.b_talk_with_a_stranger;
        b_buy_book = data.b_buy_book;
        b_ignore_it_2 = data.b_ignore_it_2;
        b_too_much_of_a_risk = data.b_too_much_of_a_risk;
        b_give_me_some_time = data.b_give_me_some_time;
        b_nevermind = data.b_nevermind;
        b_check_the_weather = data.b_check_the_weather;
        b_the_lounge = data.b_the_lounge;
        b_the_food_court = data.b_the_food_court;
        b_halls = data.b_halls;
        b_gates = data.b_gates;
        b_fight = data.b_fight;
        b_looking_around = data.b_looking_around;
        b_check_for_survivors = data.b_check_for_survivors;
        b_push_the_chair = data.b_push_the_chair;
        b_move_the_luggage = data.b_move_the_luggage;
        b_pick_up_the_tray_table = data.b_pick_up_the_tray_table;
        b_pick_up_the_bent_metal = data.b_pick_up_the_bent_metal;
        b_tuck_in_the_loose_wires = data.b_tuck_in_the_loose_wires;
        //charter1UI = data.charter1UI;
        //charter2UI = data.charter2UI;
        //charter3UI = data.charter3UI;
        //charter4UI = data.charter4UI;
        //charter5UI = data.charter5UI;
        //charter6UI = data.charter6UI;
        //charter7UI = data.charter7UI;
        //charter8UI = data.charter8UI;
        //charter9UI = data.charter9UI;
        //charter10UI = data.charter10UI;
        //charter11UI = data.charter11UI;
        //charter12UI = data.charter12UI;
        //charter13UI = data.charter13UI;
        //charter14UI = data.charter14UI;
        //charter15UI = data.charter15UI;
        //charter16UI = data.charter16UI;
        //charter17UI = data.charter17UI;
        //charter18UI = data.charter18UI;
        //charter19UI = data.charter19UI;
        //charter20UI = data.charter20UI;
        //charter21UI = data.charter21UI;
        //charter22UI = data.charter22UI;
        //charter23UI = data.charter23UI;
        //charter24UI = data.charter24UI;
        //charter25UI = data.charter25UI;
        //charter26UI = data.charter26UI;
        //charter27UI = data.charter27UI;
        //charter28UI = data.charter28UI;
        //charter29UI = data.charter29UI;
        //charter30UI = data.charter30UI;
        //charter31UI = data.charter31UI;
        //charter32UI = data.charter32UI;
        //charter33UI = data.charter33UI;
        //charter34UI = data.charter34UI;
        //charter35UI = data.charter35UI;
        //charter36UI = data.charter36UI;
        //charter37UI = data.charter37UI;
        //charter38UI = data.charter38UI;
        //charter39UI = data.charter39UI;
        //charter40UI = data.charter40UI;
        //charter41UI = data.charter41UI;
        //charter42UI = data.charter42UI;
        //charter43UI = data.charter43UI;
        //charter44UI = data.charter44UI;
        //charter45UI = data.charter45UI;
        //charter46UI = data.charter46UI;
        //charter47UI = data.charter47UI;
        //charter48UI = data.charter48UI;
        //charter49UI = data.charter49UI;
        //charter50UI = data.charter50UI;

        activeMenu.Load1();
        _musicMenu.StopMusic();
        activeChapter.CharterActiveUpdate();
        _musicCharter.PlayMusic(0);
        //activeCamp.CampActiveUpdate();
        //_musicCamp.CampMusicOnOff();
        //_musicForest.ForestMusicOnOff();
        SavePlayer();
        FireBaseAnalyticsEvents.EventsLoadGame3("LoadGame3");
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

        for (int i = 0; i < data.charter.Length; i++)
        {
            charter[i] = data.charter[i];
        }

        b_alcohol = data.b_alcohol;
        b_ignore_it = data.b_ignore_it;
        b_any_other_flights = data.b_any_other_flights;
        b_visit_the_cigar_bar = data.b_visit_the_cigar_bar;
        b_grab_some_food = data.b_grab_some_food;
        b_ask_about_her_toys = data.b_ask_about_her_toys;
        b_make_conversation = data.b_make_conversation;
        b_try_to_find_her_parents = data.b_try_to_find_her_parents;
        b_take_the_girl_to_an_officer = data.b_take_the_girl_to_an_officer;
        b_we_were_looking = data.b_we_were_looking;
        b_go_to_the_bookstore = data.b_go_to_the_bookstore;
        b_talk_with_a_stranger = data.b_talk_with_a_stranger;
        b_buy_book = data.b_buy_book;
        b_ignore_it_2 = data.b_ignore_it_2;
        b_too_much_of_a_risk = data.b_too_much_of_a_risk;
        b_give_me_some_time = data.b_give_me_some_time;
        b_nevermind = data.b_nevermind;
        b_check_the_weather = data.b_check_the_weather;
        b_the_lounge = data.b_the_lounge;
        b_the_food_court = data.b_the_food_court;
        b_halls = data.b_halls;
        b_gates = data.b_gates;
        b_fight = data.b_fight;
        b_looking_around = data.b_looking_around;
        b_check_for_survivors = data.b_check_for_survivors;
        b_push_the_chair = data.b_push_the_chair;
        b_move_the_luggage = data.b_move_the_luggage;
        b_pick_up_the_tray_table = data.b_pick_up_the_tray_table;
        b_pick_up_the_bent_metal = data.b_pick_up_the_bent_metal;
        b_tuck_in_the_loose_wires = data.b_tuck_in_the_loose_wires;
        //charter1UI = data.charter1UI;
        //charter2UI = data.charter2UI;
        //charter3UI = data.charter3UI;
        //charter4UI = data.charter4UI;
        //charter5UI = data.charter5UI;
        //charter6UI = data.charter6UI;
        //charter7UI = data.charter7UI;
        //charter8UI = data.charter8UI;
        //charter9UI = data.charter9UI;
        //charter10UI = data.charter10UI;
        //charter11UI = data.charter11UI;
        //charter12UI = data.charter12UI;
        //charter13UI = data.charter13UI;
        //charter14UI = data.charter14UI;
        //charter15UI = data.charter15UI;
        //charter16UI = data.charter16UI;
        //charter17UI = data.charter17UI;
        //charter18UI = data.charter18UI;
        //charter19UI = data.charter19UI;
        //charter20UI = data.charter20UI;
        //charter21UI = data.charter21UI;
        //charter22UI = data.charter22UI;
        //charter23UI = data.charter23UI;
        //charter24UI = data.charter24UI;
        //charter25UI = data.charter25UI;
        //charter26UI = data.charter26UI;
        //charter27UI = data.charter27UI;
        //charter28UI = data.charter28UI;
        //charter29UI = data.charter29UI;
        //charter30UI = data.charter30UI;
        //charter31UI = data.charter31UI;
        //charter32UI = data.charter32UI;
        //charter33UI = data.charter33UI;
        //charter34UI = data.charter34UI;
        //charter35UI = data.charter35UI;
        //charter36UI = data.charter36UI;
        //charter37UI = data.charter37UI;
        //charter38UI = data.charter38UI;
        //charter39UI = data.charter39UI;
        //charter40UI = data.charter40UI;
        //charter41UI = data.charter41UI;
        //charter42UI = data.charter42UI;
        //charter43UI = data.charter43UI;
        //charter44UI = data.charter44UI;
        //charter45UI = data.charter45UI;
        //charter46UI = data.charter46UI;
        //charter47UI = data.charter47UI;
        //charter48UI = data.charter48UI;
        //charter49UI = data.charter49UI;
        //charter50UI = data.charter50UI;

        activeMenu.Load1();
        _musicMenu.StopMusic();
        activeChapter.CharterActiveUpdate();
        _musicCharter.PlayMusic(0);
        //activeCamp.CampActiveUpdate();
        //_musicCamp.CampMusicOnOff();
        //_musicForest.ForestMusicOnOff();

        SavePlayer();
        FireBaseAnalyticsEvents.EventsLoadGame4("LoadGame4");
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

        for (int i = 0; i < data.charter.Length; i++)
        {
            charter[i] = data.charter[i];
        }

        b_alcohol = data.b_alcohol;
        b_ignore_it = data.b_ignore_it;
        b_any_other_flights = data.b_any_other_flights;
        b_visit_the_cigar_bar = data.b_visit_the_cigar_bar;
        b_grab_some_food = data.b_grab_some_food;
        b_ask_about_her_toys = data.b_ask_about_her_toys;
        b_make_conversation = data.b_make_conversation;
        b_try_to_find_her_parents = data.b_try_to_find_her_parents;
        b_take_the_girl_to_an_officer = data.b_take_the_girl_to_an_officer;
        b_we_were_looking = data.b_we_were_looking;
        b_go_to_the_bookstore = data.b_go_to_the_bookstore;
        b_talk_with_a_stranger = data.b_talk_with_a_stranger;
        b_buy_book = data.b_buy_book;
        b_ignore_it_2 = data.b_ignore_it_2;
        b_too_much_of_a_risk = data.b_too_much_of_a_risk;
        b_give_me_some_time = data.b_give_me_some_time;
        b_nevermind = data.b_nevermind;
        b_check_the_weather = data.b_check_the_weather;
        b_the_lounge = data.b_the_lounge;
        b_the_food_court = data.b_the_food_court;
        b_halls = data.b_halls;
        b_gates = data.b_gates;
        b_fight = data.b_fight;
        b_looking_around = data.b_looking_around;
        b_check_for_survivors = data.b_check_for_survivors;
        b_push_the_chair = data.b_push_the_chair;
        b_move_the_luggage = data.b_move_the_luggage;
        b_pick_up_the_tray_table = data.b_pick_up_the_tray_table;
        b_pick_up_the_bent_metal = data.b_pick_up_the_bent_metal;
        b_tuck_in_the_loose_wires = data.b_tuck_in_the_loose_wires;
        //charter1UI = data.charter1UI;
        //charter2UI = data.charter2UI;
        //charter3UI = data.charter3UI;
        //charter4UI = data.charter4UI;
        //charter5UI = data.charter5UI;
        //charter6UI = data.charter6UI;
        //charter7UI = data.charter7UI;
        //charter8UI = data.charter8UI;
        //charter9UI = data.charter9UI;
        //charter10UI = data.charter10UI;
        //charter11UI = data.charter11UI;
        //charter12UI = data.charter12UI;
        //charter13UI = data.charter13UI;
        //charter14UI = data.charter14UI;
        //charter15UI = data.charter15UI;
        //charter16UI = data.charter16UI;
        //charter17UI = data.charter17UI;
        //charter18UI = data.charter18UI;
        //charter19UI = data.charter19UI;
        //charter20UI = data.charter20UI;
        //charter21UI = data.charter21UI;
        //charter22UI = data.charter22UI;
        //charter23UI = data.charter23UI;
        //charter24UI = data.charter24UI;
        //charter25UI = data.charter25UI;
        //charter26UI = data.charter26UI;
        //charter27UI = data.charter27UI;
        //charter28UI = data.charter28UI;
        //charter29UI = data.charter29UI;
        //charter30UI = data.charter30UI;
        //charter31UI = data.charter31UI;
        //charter32UI = data.charter32UI;
        //charter33UI = data.charter33UI;
        //charter34UI = data.charter34UI;
        //charter35UI = data.charter35UI;
        //charter36UI = data.charter36UI;
        //charter37UI = data.charter37UI;
        //charter38UI = data.charter38UI;
        //charter39UI = data.charter39UI;
        //charter40UI = data.charter40UI;
        //charter41UI = data.charter41UI;
        //charter42UI = data.charter42UI;
        //charter43UI = data.charter43UI;
        //charter44UI = data.charter44UI;
        //charter45UI = data.charter45UI;
        //charter46UI = data.charter46UI;
        //charter47UI = data.charter47UI;
        //charter48UI = data.charter48UI;
        //charter49UI = data.charter49UI;
        //charter50UI = data.charter50UI;

        activeMenu.Load1();
        _musicMenu.StopMusic();
        activeChapter.CharterActiveUpdate();
        _musicCharter.PlayMusic(0);
        //activeCamp.CampActiveUpdate();
        //_musicCamp.CampMusicOnOff();
        //_musicForest.ForestMusicOnOff();
        SavePlayer();
        FireBaseAnalyticsEvents.EventsLoadGame5("LoadGame5");
    }
    public void ResetPlayer5()
    {
        SaveSystem.ResetPlayer5();
    }
}
