using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    //public bool charter1UI;
    //public bool charter2UI;
    //public bool charter3UI;
    //public bool charter4UI;
    //public bool charter5UI;
    //public bool charter6UI;
    //public bool charter7UI;
    //public bool charter8UI;
    //public bool charter9UI;
    //public bool charter10UI;
    //public bool charter11UI;
    //public bool charter12UI;
    //public bool charter13UI;
    //public bool charter14UI;
    //public bool charter15UI;
    //public bool charter16UI;
    //public bool charter17UI;
    //public bool charter18UI;
    //public bool charter19UI;
    //public bool charter20UI;
    //public bool charter21UI;
    //public bool charter22UI;
    //public bool charter23UI;
    //public bool charter24UI;
    //public bool charter25UI;
    //public bool charter26UI;
    //public bool charter27UI;
    //public bool charter28UI;
    //public bool charter29UI;
    //public bool charter30UI;
    //public bool charter31UI;
    //public bool charter32UI;
    //public bool charter33UI;
    //public bool charter34UI;
    //public bool charter35UI;
    //public bool charter36UI;
    //public bool charter37UI;
    //public bool charter38UI;
    //public bool charter39UI;
    //public bool charter40UI;
    //public bool charter41UI;
    //public bool charter42UI;
    //public bool charter43UI;
    //public bool charter44UI;
    //public bool charter45UI;
    //public bool charter46UI;
    //public bool charter47UI;
    //public bool charter48UI;
    //public bool charter49UI;
    //public bool charter50UI;


    public int[] charter = new int[182];


    public int b_alcohol;//S
    public int b_ignore_it;//S
    public int b_any_other_flights;//S
    public int b_visit_the_cigar_bar;//S
    public int b_grab_some_food;//S
    public int b_ask_about_her_toys;//S
    public int b_make_conversation;//S
    public int b_try_to_find_her_parents;//S
    public int b_take_the_girl_to_an_officer;//S
    public int b_we_were_looking;//S
    public int b_go_to_the_bookstore;//S
    public int b_talk_with_a_stranger;//S
    public int b_buy_book;//S
    public int b_ignore_it_2;//S
    public int b_too_much_of_a_risk;//S
    public int b_give_me_some_time;//S
    public int b_nevermind;//S
    public int b_check_the_weather;//S
    public int b_the_lounge;//S
    public int b_the_food_court;//S
    public int b_halls;//S
    public int b_gates;//S
    public int b_fight;//S
    public int b_looking_around;//S
    public int b_check_for_survivors;//S
    public int b_push_the_chair;//S
    public int climb_over;//S
    public int b_move_the_luggage;
    public int b_pick_up_the_tray_table;
    public int b_pick_up_the_bent_metal;
    public int b_tuck_in_the_loose_wires;
    public int b_take_the_knife;

    public int numberMusic;
    public PlayerData(GameManager gameManager)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            charter[i] = gameManager.charter[i];
        }

        b_alcohol = gameManager.b_alcohol;
        b_ignore_it = gameManager.b_ignore_it;
        b_any_other_flights = gameManager.b_any_other_flights;
        b_visit_the_cigar_bar = gameManager.b_visit_the_cigar_bar;
        b_grab_some_food = gameManager.b_grab_some_food;
        b_ask_about_her_toys = gameManager.b_ask_about_her_toys;
        b_make_conversation = gameManager.b_make_conversation;
        b_try_to_find_her_parents = gameManager.b_try_to_find_her_parents;
        b_take_the_girl_to_an_officer = gameManager.b_take_the_girl_to_an_officer;
        b_we_were_looking = gameManager.b_we_were_looking;
        b_go_to_the_bookstore = gameManager.b_go_to_the_bookstore;
        b_talk_with_a_stranger = gameManager.b_talk_with_a_stranger;
        b_buy_book = gameManager.b_buy_book;
        b_ignore_it_2 = gameManager.b_ignore_it_2;
        b_too_much_of_a_risk = gameManager.b_too_much_of_a_risk;
        b_give_me_some_time = gameManager.b_give_me_some_time;
        b_nevermind = gameManager.b_nevermind;
        b_check_the_weather = gameManager.b_check_the_weather;
        b_the_lounge = gameManager.b_the_lounge;
        b_the_food_court = gameManager.b_the_food_court;
        b_halls = gameManager.b_halls;
        b_gates = gameManager.b_gates;
        b_fight = gameManager.b_fight;
        b_looking_around = gameManager.b_looking_around;
        b_check_for_survivors = gameManager.b_check_for_survivors;
        b_push_the_chair = gameManager.b_push_the_chair;
        b_move_the_luggage = gameManager.b_move_the_luggage;
        b_pick_up_the_tray_table = gameManager.b_pick_up_the_tray_table;
        b_pick_up_the_bent_metal = gameManager.b_pick_up_the_bent_metal;
        b_tuck_in_the_loose_wires = gameManager.b_tuck_in_the_loose_wires;
        b_take_the_knife = gameManager.b_take_the_knife;
        numberMusic = gameManager.numberMusic;

    //charter1UI = gameManager.charter1UI;
    //charter2UI = gameManager.charter2UI;
    //charter3UI = gameManager.charter3UI;
    //charter4UI = gameManager.charter4UI;
    //charter5UI = gameManager.charter5UI;
    //charter6UI = gameManager.charter6UI;
    //charter7UI = gameManager.charter7UI;
    //charter8UI = gameManager.charter8UI;
    //charter9UI = gameManager.charter9UI;
    //charter10UI = gameManager.charter10UI;
    //charter11UI = gameManager.charter11UI;
    //charter12UI = gameManager.charter12UI;
    //charter13UI = gameManager.charter13UI;
    //charter14UI = gameManager.charter14UI;
    //charter15UI = gameManager.charter15UI;
    //charter16UI = gameManager.charter16UI;
    //charter17UI = gameManager.charter17UI;
    //charter18UI = gameManager.charter18UI;
    //charter19UI = gameManager.charter19UI;
    //charter20UI = gameManager.charter20UI;
    //charter21UI = gameManager.charter21UI;
    //charter22UI = gameManager.charter22UI;
    //charter23UI = gameManager.charter23UI;
    //charter24UI = gameManager.charter24UI;
    //charter25UI = gameManager.charter25UI;
    //charter26UI = gameManager.charter26UI;
    //charter27UI = gameManager.charter27UI;
    //charter28UI = gameManager.charter28UI;
    //charter29UI = gameManager.charter29UI;
    //charter30UI = gameManager.charter30UI;
    //charter31UI = gameManager.charter31UI;
    //charter32UI = gameManager.charter32UI;
    //charter33UI = gameManager.charter33UI;
    //charter34UI = gameManager.charter34UI;
    //charter35UI = gameManager.charter35UI;
    //charter36UI = gameManager.charter36UI;
    //charter37UI = gameManager.charter37UI;
    //charter38UI = gameManager.charter38UI;
    //charter39UI = gameManager.charter39UI;
    //charter40UI = gameManager.charter40UI;
    //charter41UI = gameManager.charter41UI;
    //charter42UI = gameManager.charter42UI;
    //charter43UI = gameManager.charter43UI;
    //charter44UI = gameManager.charter44UI;
    //charter45UI = gameManager.charter45UI;
    //charter46UI = gameManager.charter46UI;
    //charter47UI = gameManager.charter47UI;
    //charter48UI = gameManager.charter48UI;
    //charter49UI = gameManager.charter49UI;
    //charter50UI = gameManager.charter50UI;
}
}