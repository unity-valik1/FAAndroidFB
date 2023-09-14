//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ActiveCamp : MonoBehaviour
//{
//    [SerializeField] private GameManager gameManager;
//    [SerializeField] private ActiveMenu activeMenu;
//    //[SerializeField] private MusicCamp musicCamp;
//    //[SerializeField] private MusicForest musicForest;

//    public GameObject campUI;
//    public GameObject bonfire1UI;
//    public GameObject bonfire2UI;
//    public GameObject houseUI;
//    public GameObject eatUI;
//    public GameObject goUI;
//    public GameObject forestUI;
//    public GameObject lakeUI;

//    public void CampActiveUpdate()
//    {
//        if (gameManager.campUI == true)
//        {
//            campUI.gameObject.SetActive(true);
//            bonfire1UI.gameObject.SetActive(false);
//            bonfire2UI.gameObject.SetActive(false);
//            houseUI.gameObject.SetActive(false);
//            eatUI.gameObject.SetActive(false);
//            goUI.gameObject.SetActive(false);
//            forestUI.gameObject.SetActive(false);
//            lakeUI.gameObject.SetActive(false);

//            gameManager.bonfire1UI = false;
//            gameManager.bonfire2UI = false;
//            gameManager.houseUI = false;
//            gameManager.eatUI = false;
//            gameManager.goUI = false;
//            gameManager.forestUI = false;
//            gameManager.lakeUI = false;
//        }

//        else if (gameManager.bonfire1UI == true)
//        {
//            campUI.gameObject.SetActive(false);
//            bonfire1UI.gameObject.SetActive(true);
//            bonfire2UI.gameObject.SetActive(false);
//            houseUI.gameObject.SetActive(false);
//            eatUI.gameObject.SetActive(false);
//            goUI.gameObject.SetActive(false);
//            forestUI.gameObject.SetActive(false);
//            lakeUI.gameObject.SetActive(false);

//            gameManager.campUI = false;
//            gameManager.houseUI = false;
//            gameManager.eatUI = false;
//            gameManager.goUI = false;
//            gameManager.forestUI = false;
//            gameManager.lakeUI = false;
//        }

//        else if (gameManager.bonfire2UI == true)
//        {
//            campUI.gameObject.SetActive(false);
//            bonfire1UI.gameObject.SetActive(false);
//            bonfire2UI.gameObject.SetActive(true);
//            houseUI.gameObject.SetActive(false);
//            eatUI.gameObject.SetActive(false);
//            goUI.gameObject.SetActive(false);
//            forestUI.gameObject.SetActive(false);
//            lakeUI.gameObject.SetActive(false);

//            gameManager.campUI = false;
//            gameManager.bonfire1UI = false;
//            gameManager.houseUI = false;
//            gameManager.eatUI = false;
//            gameManager.goUI = false;
//            gameManager.forestUI = false;
//            gameManager.lakeUI = false;
//        }

//        else if (gameManager.houseUI == true)
//        {
//            campUI.gameObject.SetActive(false);
//            bonfire1UI.gameObject.SetActive(false);
//            bonfire2UI.gameObject.SetActive(false);
//            houseUI.gameObject.SetActive(true);
//            eatUI.gameObject.SetActive(false);
//            goUI.gameObject.SetActive(false);
//            forestUI.gameObject.SetActive(false);
//            lakeUI.gameObject.SetActive(false);

//            gameManager.campUI = false;
//            gameManager.bonfire1UI = false;
//            gameManager.bonfire2UI = false;
//            gameManager.eatUI = false;           
//            gameManager.goUI = false;
//            gameManager.forestUI = false;
//            gameManager.lakeUI = false;
//        }

//        else if (gameManager.eatUI == true)
//        {
//            campUI.gameObject.SetActive(false);
//            bonfire1UI.gameObject.SetActive(false);
//            bonfire2UI.gameObject.SetActive(false);
//            houseUI.gameObject.SetActive(false);
//            eatUI.gameObject.SetActive(true);
//            goUI.gameObject.SetActive(false);
//            forestUI.gameObject.SetActive(false);
//            lakeUI.gameObject.SetActive(false);

//            gameManager.campUI = false;
//            gameManager.bonfire1UI = false;
//            gameManager.bonfire2UI = false;
//            gameManager.houseUI = false;
//            gameManager.goUI = false;
//            gameManager.forestUI = false;
//            gameManager.lakeUI = false;
//        }

//        else if (gameManager.goUI == true)
//        {
//            campUI.gameObject.SetActive(false);
//            bonfire1UI.gameObject.SetActive(false);
//            bonfire2UI.gameObject.SetActive(false);
//            houseUI.gameObject.SetActive(false);
//            eatUI.gameObject.SetActive(false);
//            goUI.gameObject.SetActive(true);
//            forestUI.gameObject.SetActive(false);
//            lakeUI.gameObject.SetActive(false);

//            gameManager.campUI = false;
//            gameManager.bonfire1UI = false;
//            gameManager.bonfire2UI = false;
//            gameManager.houseUI = false;
//            gameManager.eatUI = false;
//            gameManager.forestUI = false;
//            gameManager.lakeUI = false;
//        }

//        else if (gameManager.forestUI == true)
//        {
//            campUI.gameObject.SetActive(false);
//            bonfire1UI.gameObject.SetActive(false);
//            bonfire2UI.gameObject.SetActive(false);
//            houseUI.gameObject.SetActive(false);
//            eatUI.gameObject.SetActive(false);
//            goUI.gameObject.SetActive(false);
//            forestUI.gameObject.SetActive(true);
//            lakeUI.gameObject.SetActive(false);

//            gameManager.campUI = false;
//            gameManager.bonfire1UI = false;
//            gameManager.bonfire2UI = false;
//            gameManager.houseUI = false;
//            gameManager.eatUI = false;
//            gameManager.goUI= false;
//            gameManager.lakeUI = false;
//        }

//        else if (gameManager.lakeUI == true)
//        {
//            campUI.gameObject.SetActive(false);
//            bonfire1UI.gameObject.SetActive(false);
//            bonfire2UI.gameObject.SetActive(false);
//            houseUI.gameObject.SetActive(false);
//            eatUI.gameObject.SetActive(false);
//            goUI.gameObject.SetActive(false);
//            forestUI.gameObject.SetActive(false);
//            lakeUI.gameObject.SetActive(true);

//            gameManager.campUI = false;
//            gameManager.bonfire1UI = false;
//            gameManager.bonfire2UI = false;
//            gameManager.houseUI = false;
//            gameManager.eatUI = false;
//            gameManager.goUI = false;
//            gameManager.forestUI = false;
//        }

//        else
//        {
//            campUI.gameObject.SetActive(false);
//            bonfire1UI.gameObject.SetActive(false);
//            bonfire2UI.gameObject.SetActive(false);
//            houseUI.gameObject.SetActive(false);
//            eatUI.gameObject.SetActive(false);
//            goUI.gameObject.SetActive(false);
//            forestUI.gameObject.SetActive(false);
//            lakeUI.gameObject.SetActive(false);

//            gameManager.campUI = false;
//            gameManager.bonfire1UI = false;
//            gameManager.bonfire2UI = false;
//            gameManager.houseUI = false;
//            gameManager.eatUI = false;
//            gameManager.goUI = false;
//            gameManager.forestUI = false;
//            gameManager.lakeUI = false;
//        }
//    }

//    public void Camp()
//    {
//        campUI.gameObject.SetActive(true);
//        bonfire1UI.gameObject.SetActive(false);
//        bonfire2UI.gameObject.SetActive(false);
//        houseUI.gameObject.SetActive(false);
//        eatUI.gameObject.SetActive(false);
//        goUI.gameObject.SetActive(false);
//        forestUI.gameObject.SetActive(false);
//        lakeUI.gameObject.SetActive(false);

//        gameManager.campUI = true;
//        gameManager.bonfire1UI = false;
//        gameManager.bonfire2UI = false;
//        gameManager.houseUI = false;
//        gameManager.eatUI = false;
//        gameManager.goUI = false;
//        gameManager.forestUI = false;
//        gameManager.lakeUI = false;
        
//        musicCamp.CampMusic();
//        gameManager.SavePlayer();
//    }

//    public void BackCamp()
//    {
//        campUI.gameObject.SetActive(true);
//        bonfire1UI.gameObject.SetActive(false);
//        bonfire2UI.gameObject.SetActive(false);
//        houseUI.gameObject.SetActive(false);
//        eatUI.gameObject.SetActive(false);
//        goUI.gameObject.SetActive(false);
//        forestUI.gameObject.SetActive(false);
//        lakeUI.gameObject.SetActive(false);

//        gameManager.campUI = true;
//        gameManager.bonfire1UI = false;
//        gameManager.bonfire2UI = false;
//        gameManager.houseUI = false;
//        gameManager.eatUI = false;
//        gameManager.goUI = false;
//        gameManager.forestUI = false;
//        gameManager.lakeUI = false;

//        gameManager.SavePlayer();
//    }

//    public void BackToCampInForestandLake()//Возвращение в Лагерь из Леса или Озера
//    {
//        campUI.gameObject.SetActive(true);
//        bonfire1UI.gameObject.SetActive(false);
//        bonfire2UI.gameObject.SetActive(false);
//        houseUI.gameObject.SetActive(false);
//        eatUI.gameObject.SetActive(false);
//        goUI.gameObject.SetActive(false);
//        forestUI.gameObject.SetActive(false);
//        lakeUI.gameObject.SetActive(false);

//        gameManager.campUI = true;
//        gameManager.bonfire1UI = false;
//        gameManager.bonfire2UI = false;
//        gameManager.houseUI = false;
//        gameManager.eatUI = false;
//        gameManager.goUI = false;
//        gameManager.forestUI = false;
//        gameManager.lakeUI = false;

//        musicForest.ForestMusic();
//        Camp();
//    }

//    public void Bonfire1()
//    {
//        campUI.gameObject.SetActive(false);
//        bonfire1UI.gameObject.SetActive(true);
//        bonfire2UI.gameObject.SetActive(false);
//        houseUI.gameObject.SetActive(false);
//        eatUI.gameObject.SetActive(false);
//        goUI.gameObject.SetActive(false);
//        forestUI.gameObject.SetActive(false);
//        lakeUI.gameObject.SetActive(false);

//        gameManager.campUI = false;
//        gameManager.bonfire1UI = true;
//        gameManager.bonfire2UI = false;
//        gameManager.houseUI = false;
//        gameManager.eatUI = false;
//        gameManager.goUI = false;
//        gameManager.forestUI = false;
//        gameManager.lakeUI = false;

//        gameManager.SavePlayer();
//    }

//    public void Bonfire2()
//    {
//        campUI.gameObject.SetActive(false);
//        bonfire1UI.gameObject.SetActive(false);
//        bonfire2UI.gameObject.SetActive(true);
//        houseUI.gameObject.SetActive(false);
//        eatUI.gameObject.SetActive(false);
//        goUI.gameObject.SetActive(false);
//        forestUI.gameObject.SetActive(false);
//        lakeUI.gameObject.SetActive(false);

//        gameManager.campUI = false;
//        gameManager.bonfire1UI = false;
//        gameManager.bonfire2UI = true;
//        gameManager.houseUI = false;
//        gameManager.eatUI = false;
//        gameManager.goUI = false;
//        gameManager.forestUI = false;
//        gameManager.lakeUI = false;

//        gameManager.SavePlayer();
//    }

//    public void House()
//    {
//        campUI.gameObject.SetActive(false);
//        bonfire1UI.gameObject.SetActive(false);
//        bonfire2UI.gameObject.SetActive(false);
//        houseUI.gameObject.SetActive(true);
//        eatUI.gameObject.SetActive(false);
//        goUI.gameObject.SetActive(false);
//        forestUI.gameObject.SetActive(false);
//        lakeUI.gameObject.SetActive(false);

//        gameManager.campUI = false;
//        gameManager.bonfire1UI = false;
//        gameManager.bonfire2UI = false;
//        gameManager.houseUI = true;
//        gameManager.eatUI = false;
//        gameManager.goUI = false;
//        gameManager.forestUI = false;
//        gameManager.lakeUI = false;

//        gameManager.SavePlayer();
//    }

//    public void Eat()
//    {
//        campUI.gameObject.SetActive(false);
//        bonfire1UI.gameObject.SetActive(false);
//        bonfire2UI.gameObject.SetActive(false);
//        houseUI.gameObject.SetActive(false);
//        eatUI.gameObject.SetActive(true);
//        goUI.gameObject.SetActive(false);
//        forestUI.gameObject.SetActive(false);
//        lakeUI.gameObject.SetActive(false);

//        gameManager.campUI = false;
//        gameManager.bonfire1UI = false;
//        gameManager.bonfire2UI = false;
//        gameManager.houseUI = false;
//        gameManager.eatUI = true;
//        gameManager.goUI = false;
//        gameManager.forestUI = false;
//        gameManager.lakeUI = false;

//        gameManager.SavePlayer();
//    }

//    public void Go()
//    {
//        campUI.gameObject.SetActive(false);
//        bonfire1UI.gameObject.SetActive(false);
//        bonfire2UI.gameObject.SetActive(false);
//        houseUI.gameObject.SetActive(false);
//        eatUI.gameObject.SetActive(false);
//        goUI.gameObject.SetActive(true);
//        forestUI.gameObject.SetActive(false);
//        lakeUI.gameObject.SetActive(false);

//        gameManager.campUI = false;
//        gameManager.bonfire1UI = false;
//        gameManager.bonfire2UI = false;
//        gameManager.houseUI = false;
//        gameManager.eatUI = false;
//        gameManager.goUI = true;
//        gameManager.forestUI = false;
//        gameManager.lakeUI = false;

//        gameManager.SavePlayer();
//    }

//    public void Forest()
//    {
//        campUI.gameObject.SetActive(false);
//        bonfire1UI.gameObject.SetActive(false);
//        bonfire2UI.gameObject.SetActive(false);
//        houseUI.gameObject.SetActive(false);
//        eatUI.gameObject.SetActive(false);
//        goUI.gameObject.SetActive(false);
//        forestUI.gameObject.SetActive(true);
//        lakeUI.gameObject.SetActive(false);

//        gameManager.campUI = false;
//        gameManager.bonfire1UI = false;
//        gameManager.bonfire2UI = false;
//        gameManager.houseUI = false;
//        gameManager.eatUI = false;
//        gameManager.goUI = false;
//        gameManager.forestUI = true;
//        gameManager.lakeUI = false;

//        musicCamp.CampMusic();
//        musicForest.ForestMusic();

//        gameManager.SavePlayer();
//    }

//    public void Lake()
//    {
//        campUI.gameObject.SetActive(false);
//        bonfire1UI.gameObject.SetActive(false);
//        bonfire2UI.gameObject.SetActive(false);
//        houseUI.gameObject.SetActive(false);
//        eatUI.gameObject.SetActive(false);
//        goUI.gameObject.SetActive(false);
//        forestUI.gameObject.SetActive(false);
//        lakeUI.gameObject.SetActive(true);

//        gameManager.campUI = false;
//        gameManager.bonfire1UI = false;
//        gameManager.bonfire2UI = false;
//        gameManager.houseUI = false;
//        gameManager.eatUI = false;
//        gameManager.goUI = false;
//        gameManager.forestUI = false;
//        gameManager.lakeUI = true;

//        musicCamp.CampMusic();
//        musicForest.ForestMusic();

//        gameManager.SavePlayer();
//    }

//    public void MenuCamp()
//    {
//        campUI.gameObject.SetActive(false);
//        bonfire1UI.gameObject.SetActive(false);
//        bonfire2UI.gameObject.SetActive(false);
//        houseUI.gameObject.SetActive(false);
//        eatUI.gameObject.SetActive(false);
//        goUI.gameObject.SetActive(false);
//        forestUI.gameObject.SetActive(false);
//        lakeUI.gameObject.SetActive(false);

//        gameManager.campUI = false;
//        gameManager.bonfire1UI = false;
//        gameManager.bonfire2UI = false;
//        gameManager.houseUI = false;
//        gameManager.eatUI = false;
//        gameManager.goUI = false;
//        gameManager.forestUI = false;
//        gameManager.lakeUI = false;

//        musicCamp.OffMusic();
//        musicForest.OffMusic();
//        activeMenu.BackMenu();
//    }
//}
