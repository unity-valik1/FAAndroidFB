using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] private ActiveMenu activeMenu;
    [SerializeField] private ActiveChapter activeChapter;
    [SerializeField] private MusicMenu _musicMenu;
    [SerializeField] private MusicCharter _musicCharter;

    [Header("ЭлементыUI Самолет")]
    [Tooltip("Самолет")] public int[] charter = new int[188];

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
    [Tooltip("Алкоголь")] public int b_take_the_knife = 0;//S
    [Tooltip("Алкоголь")] public int b_the_end = 0;//S
    [Tooltip("Алкоголь")] public int call_back = 0;//S

    public int numberMusic = 0;//S

    public int save_buy = 0;
    public int load_buy = 0;

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
        b_take_the_knife = data.b_take_the_knife;
        b_the_end = data.b_the_end;
        call_back = data.call_back;
        numberMusic = data.numberMusic;

        _musicMenu.StopMusic();
        activeChapter.CharterActiveUpdate();
        _musicCharter.PlayMusic(numberMusic);
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
        b_take_the_knife = data.b_take_the_knife;
        b_the_end = data.b_the_end;
        call_back = data.call_back;
        numberMusic = data.numberMusic;

        activeMenu.Load1();
        _musicMenu.StopMusic();
        activeChapter.CharterActiveUpdate();
        _musicCharter.PlayMusic(numberMusic);
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
        b_take_the_knife = data.b_take_the_knife;
        b_the_end = data.b_the_end;
        call_back = data.call_back;
        numberMusic = data.numberMusic;

        activeMenu.Load1();
        _musicMenu.StopMusic();
        activeChapter.CharterActiveUpdate();
        _musicCharter.PlayMusic(numberMusic);
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
        b_take_the_knife = data.b_take_the_knife;
        b_the_end = data.b_the_end;
        call_back = data.call_back;
        numberMusic = data.numberMusic;

        activeMenu.Load1();
        _musicMenu.StopMusic();
        activeChapter.CharterActiveUpdate();
        _musicCharter.PlayMusic(numberMusic);

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
        b_take_the_knife = data.b_take_the_knife;
        b_the_end = data.b_the_end;
        call_back = data.call_back;
        numberMusic = data.numberMusic;

        activeMenu.Load1();
        _musicMenu.StopMusic();
        activeChapter.CharterActiveUpdate();
        _musicCharter.PlayMusic(numberMusic);


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
        b_take_the_knife = data.b_take_the_knife;
        b_the_end = data.b_the_end;
        call_back = data.call_back;
        numberMusic = data.numberMusic;

        activeMenu.Load1();
        _musicMenu.StopMusic();
        activeChapter.CharterActiveUpdate();
        _musicCharter.PlayMusic(numberMusic);
        SavePlayer();
        FireBaseAnalyticsEvents.EventsLoadGame5("LoadGame5");
    }
    public void ResetPlayer5()
    {
        SaveSystem.ResetPlayer5();
    }

    public void Null()
    {
        b_alcohol = 0;//S
        b_ignore_it = 0;//S
        b_any_other_flights = 0;//S
        b_visit_the_cigar_bar = 0;//S
        b_grab_some_food = 0;//S
        b_ask_about_her_toys = 0;//S
        b_make_conversation = 0;//S
        b_try_to_find_her_parents = 0;//S
        b_take_the_girl_to_an_officer = 0;//S
        b_we_were_looking = 0;//S
       b_go_to_the_bookstore = 0;//S
        b_talk_with_a_stranger = 0;//S
        b_buy_book = 0;//S
        b_ignore_it_2 = 0;//S
        b_too_much_of_a_risk = 0;//S
        b_give_me_some_time = 0;//S
        b_nevermind = 0;//S
        b_check_the_weather = 0;//S
        b_the_lounge = 0;//S
        b_the_food_court = 0;//S
        b_halls = 0;//S
        b_gates = 0;//S
        b_fight = 0;//S
        b_looking_around = 0;//S
        b_check_for_survivors = 0;//S
        b_push_the_chair = 0;//S
        climb_over = 0;//S
        b_move_the_luggage = 0;//S
        b_pick_up_the_tray_table = 0;//S
        b_pick_up_the_bent_metal = 0;//S
        b_tuck_in_the_loose_wires = 0;//S
        b_take_the_knife = 0;//S
        b_the_end = 0;//S
        call_back = 0;
    }
}
