using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{


    public int[] charter = new int[188];


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
    public int b_the_end;
    public int call_back;

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
        b_the_end = gameManager.b_the_end;
        call_back = gameManager.call_back;
        numberMusic = gameManager.numberMusic;

    }
}