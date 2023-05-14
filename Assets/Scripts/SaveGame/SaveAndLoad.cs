using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class SaveAndLoad : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Camera camera1;


    [Tooltip("Меню")] public int continueGame = 0;//PP

    [Header("Загрузка и сохранение")]
    [Tooltip("СЗ1")] public int SL1 = 0;//PP
    [Tooltip("СЗ2")] public int SL2 = 0;//PP
    [Tooltip("СЗ3")] public int SL3 = 0;//PP
    [Tooltip("СЗ4")] public int SL4 = 0;//PP
    [Tooltip("СЗ5")] public int SL5 = 0;//PP

    [Header("Канвас загрузки")]
    public GameObject lossGameStart;
    public GameObject lossGameLoad;
    public GameObject ButtonLoad1;
    public GameObject ButtonLoad2;
    public GameObject ButtonLoad3;
    public GameObject ButtonLoad4;
    public GameObject ButtonLoad5;

    [Header("Сохраненки")]
    public GameObject saveSave;
    public GameObject money;


    [Header("Канвас сохранения и удаления")]
    public GameObject saveGame;
    public GameObject resetGame;

    [Header("Кнопки сохранения и удаления игры")]
    public GameObject ButtonSave1;
    public GameObject ButtonSave2;
    public GameObject ButtonSave3;
    public GameObject ButtonSave4;
    public GameObject ButtonSave5;
    public GameObject ButtonReset1;
    public GameObject ButtonReset2;
    public GameObject ButtonReset3;
    public GameObject ButtonReset4;
    public GameObject ButtonReset5;
    public GameObject ButtonReset1Canvas;
    public GameObject ButtonReset2Canvas;
    public GameObject ButtonReset3Canvas;
    public GameObject ButtonReset4Canvas;
    public GameObject ButtonReset5Canvas;

    [Header("Текст сохранения и загрузки игры")]
    public TMP_Text save1Text;
    public TMP_Text save2Text;
    public TMP_Text save3Text;
    public TMP_Text save4Text;
    public TMP_Text save5Text;
    public TMP_Text load1Text;
    public TMP_Text load2Text;
    public TMP_Text load3Text;
    public TMP_Text load4Text;
    public TMP_Text load5Text;
    public TMP_Text nameLocation1;
    public TMP_Text nameLocation2;
    public TMP_Text nameLocation3;
    public TMP_Text nameLocation4;
    public TMP_Text nameLocation5;
    public TMP_Text nameLocation1Load;
    public TMP_Text nameLocation2Load;
    public TMP_Text nameLocation3Load;
    public TMP_Text nameLocation4Load;
    public TMP_Text nameLocation5Load;
    public TMP_Text display;
    public TMP_Text display2;
    public TMP_Text display3;
    public TMP_Text display4;
    public TMP_Text display5;
    public TMP_Text displayLoad;
    public TMP_Text display2Load;
    public TMP_Text display3Load;
    public TMP_Text display4Load;
    public TMP_Text display5Load;
    public int hour;
    public int minutes;
    public int day;
    public int month;
    public int year;

    public Button[] loadBatton;


    private void Start()
    {
        if (PlayerPrefs.HasKey("saveGame1"))
        {
            save1Text.text = PlayerPrefs.GetString("saveGame1");
        }
        if (PlayerPrefs.HasKey("saveGame2"))
        {
            save2Text.text = PlayerPrefs.GetString("saveGame2");
        }
        if (PlayerPrefs.HasKey("saveGame3"))
        {
            save3Text.text = PlayerPrefs.GetString("saveGame3");
        }
        if (PlayerPrefs.HasKey("saveGame4"))
        {
            save4Text.text = PlayerPrefs.GetString("saveGame4");
        }
        if (PlayerPrefs.HasKey("saveGame5"))
        {
            save5Text.text = PlayerPrefs.GetString("saveGame5");
        }
        if (PlayerPrefs.HasKey("loadGame1"))
        {
            load1Text.text = PlayerPrefs.GetString("loadGame1");
        }
        if (PlayerPrefs.HasKey("loadGame2"))
        {
            load2Text.text = PlayerPrefs.GetString("loadGame2");
        }
        if (PlayerPrefs.HasKey("loadGame3"))
        {
            load3Text.text = PlayerPrefs.GetString("loadGame3");
        }
        if (PlayerPrefs.HasKey("loadGame4"))
        {
            load4Text.text = PlayerPrefs.GetString("loadGame4");
        }
        if (PlayerPrefs.HasKey("loadGame5"))
        {
            load5Text.text = PlayerPrefs.GetString("loadGame5");
        }
        if (PlayerPrefs.HasKey("sl1"))
        {
            SL1 = PlayerPrefs.GetInt("sl1");
        }
        if (PlayerPrefs.HasKey("sl2"))
        {
            SL2 = PlayerPrefs.GetInt("sl2");
        }
        if (PlayerPrefs.HasKey("sl3"))
        {
            SL3 = PlayerPrefs.GetInt("sl3");
        }
        if (PlayerPrefs.HasKey("sl4"))
        {
            SL4 = PlayerPrefs.GetInt("sl4");
        }
        if (PlayerPrefs.HasKey("sl5"))
        {
            SL5 = PlayerPrefs.GetInt("sl5");
        }
        if (PlayerPrefs.HasKey("nameLocation1"))
        {
            nameLocation1.text = PlayerPrefs.GetString("nameLocation1");
        }
        if (PlayerPrefs.HasKey("nameLocation2"))
        {
            nameLocation2.text = PlayerPrefs.GetString("nameLocation2");
        }
        if (PlayerPrefs.HasKey("nameLocation3"))
        {
            nameLocation3.text = PlayerPrefs.GetString("nameLocation3");
        }
        if (PlayerPrefs.HasKey("nameLocation4"))
        {
            nameLocation4.text = PlayerPrefs.GetString("nameLocation4");
        }
        if (PlayerPrefs.HasKey("nameLocation5"))
        {
            nameLocation5.text = PlayerPrefs.GetString("nameLocation5");
        }
        if (PlayerPrefs.HasKey("nameLocation1Load"))
        {
            nameLocation1Load.text = PlayerPrefs.GetString("nameLocation1Load");
        }
        if (PlayerPrefs.HasKey("nameLocation2Load"))
        {
            nameLocation2Load.text = PlayerPrefs.GetString("nameLocation2Load");
        }
        if (PlayerPrefs.HasKey("nameLocation3Load"))
        {
            nameLocation3Load.text = PlayerPrefs.GetString("nameLocation3Load");
        }
        if (PlayerPrefs.HasKey("nameLocation4Load"))
        {
            nameLocation4Load.text = PlayerPrefs.GetString("nameLocation4Load");
        }
        if (PlayerPrefs.HasKey("nameLocation5Load"))
        {
            nameLocation5Load.text = PlayerPrefs.GetString("nameLocation5Load");
        }
        if (PlayerPrefs.HasKey("display"))
        {
            display.text = PlayerPrefs.GetString("display");
        }
        if (PlayerPrefs.HasKey("display2"))
        {
            display2.text = PlayerPrefs.GetString("display2");
        }
        if (PlayerPrefs.HasKey("display3"))
        {
            display3.text = PlayerPrefs.GetString("display3");
        }
        if (PlayerPrefs.HasKey("display4"))
        {
            display4.text = PlayerPrefs.GetString("display4");
        }
        if (PlayerPrefs.HasKey("display5"))
        {
            display5.text = PlayerPrefs.GetString("display5");
        }
        if (PlayerPrefs.HasKey("displayLoad"))
        {
            displayLoad.text = PlayerPrefs.GetString("displayLoad");
        }
        if (PlayerPrefs.HasKey("display2Load"))
        {
            display2Load.text = PlayerPrefs.GetString("display2Load");
        }
        if (PlayerPrefs.HasKey("display3Load"))
        {
            display3Load.text = PlayerPrefs.GetString("display3Load");
        }
        if (PlayerPrefs.HasKey("display4Load"))
        {
            display4Load.text = PlayerPrefs.GetString("display4Load");
        }
        if (PlayerPrefs.HasKey("display5Load"))
        {
            display5Load.text = PlayerPrefs.GetString("display5Load");
        }
        for (int i = 0; i < loadBatton.Length; i++)
        {
            if (SL1 == 0)
            {
                loadBatton[0].interactable = false;
                loadBatton[5].gameObject.SetActive(false);
                loadBatton[10].gameObject.SetActive(false);
            }
            else
            {
                loadBatton[0].interactable = true;
                loadBatton[5].gameObject.SetActive(true);
                loadBatton[10].gameObject.SetActive(true);
            }
            if (SL2 == 0)
            {
                loadBatton[1].interactable = false;
                loadBatton[6].gameObject.SetActive(false);
                loadBatton[11].gameObject.SetActive(false);
            }
            else
            {
                loadBatton[1].interactable = true;
                loadBatton[6].gameObject.SetActive(true);
                loadBatton[11].gameObject.SetActive(true);
            }
            if (SL3 == 0)
            {
                loadBatton[2].interactable = false;
                loadBatton[7].gameObject.SetActive(false);
                loadBatton[12].gameObject.SetActive(false);
            }
            else
            {
                loadBatton[2].interactable = true;
                loadBatton[7].gameObject.SetActive(true);
                loadBatton[12].gameObject.SetActive(true);
            }
            if (SL4 == 0)
            {
                loadBatton[3].interactable = false;
                loadBatton[8].gameObject.SetActive(false);
                loadBatton[13].gameObject.SetActive(false);
            }
            else
            {
                loadBatton[3].interactable = true;
                loadBatton[8].gameObject.SetActive(true);
                loadBatton[13].gameObject.SetActive(true);
            }
            if (SL5 == 0)
            {
                loadBatton[4].interactable = false;
                loadBatton[9].gameObject.SetActive(false);
                loadBatton[14].gameObject.SetActive(false);
            }
            else
            {
                loadBatton[4].interactable = true;
                loadBatton[9].gameObject.SetActive(true);
                loadBatton[14].gameObject.SetActive(true);
            }
        }
    }

    public void LoadGame1()
    {
        if (continueGame == 0)
        {
            gameManager.LoadPlayer1();
        }
        else
        {
            camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
            lossGameLoad.gameObject.SetActive(true);
            ButtonLoad1.gameObject.SetActive(true);
            ButtonLoad2.gameObject.SetActive(false);
            ButtonLoad3.gameObject.SetActive(false);
            ButtonLoad4.gameObject.SetActive(false);
            ButtonLoad5.gameObject.SetActive(false);
        }
    }
    public void LoadGame2()
    {
        if (continueGame == 0)
        {
            gameManager.LoadPlayer2();
        }
        else
        {
            camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
            lossGameLoad.gameObject.SetActive(true);
            ButtonLoad1.gameObject.SetActive(false);
            ButtonLoad2.gameObject.SetActive(true);
            ButtonLoad3.gameObject.SetActive(false);
            ButtonLoad4.gameObject.SetActive(false);
            ButtonLoad5.gameObject.SetActive(false);
        }
    }
    public void LoadGame3()
    {
        if (continueGame == 0)
        {
            gameManager.LoadPlayer3();
        }
        else
        {
            camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
            lossGameLoad.gameObject.SetActive(true);
            ButtonLoad1.gameObject.SetActive(false);
            ButtonLoad2.gameObject.SetActive(false);
            ButtonLoad3.gameObject.SetActive(true);
            ButtonLoad4.gameObject.SetActive(false);
            ButtonLoad5.gameObject.SetActive(false);
        }
    }
    public void LoadGame4()
    {
        if (continueGame == 0)
        {
            gameManager.LoadPlayer4();
        }
        else
        {
            camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
            lossGameLoad.gameObject.SetActive(true);
            ButtonLoad1.gameObject.SetActive(false);
            ButtonLoad2.gameObject.SetActive(false);
            ButtonLoad3.gameObject.SetActive(false);
            ButtonLoad4.gameObject.SetActive(true);
            ButtonLoad5.gameObject.SetActive(false);
        }
    }
    public void LoadGame5()
    {
        if (continueGame == 0)
        {
            gameManager.LoadPlayer5();
        }
        else
        {
            camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
            lossGameLoad.gameObject.SetActive(true);
            ButtonLoad1.gameObject.SetActive(false);
            ButtonLoad2.gameObject.SetActive(false);
            ButtonLoad3.gameObject.SetActive(false);
            ButtonLoad4.gameObject.SetActive(false);
            ButtonLoad5.gameObject.SetActive(true);
        }
    }

    public void SaveGame1Button()
    {
        if (SL1 == 0)
        {
            DateTime now = DateTime.Now;
            display.text = now.ToString("dd.MM.yyyy HH:mm");
            displayLoad.text = display.text;
            //hour = System.DateTime.Now.Hour;
            //minutes = System.DateTime.Now.Minute;
            //day = System.DateTime.Now.Day;
            //month = System.DateTime.Now.Month;
            //year = System.DateTime.Now.Year;
            //display.text = day + "." + month + "." + year + " " + hour + ":" + minutes;
            //displayLoad.text = display.text;
            nameLocation1.text = "1";
            nameLocation1Load.text = nameLocation1.text;
            save1Text.text = "";
            load1Text.text = save1Text.text;
            SL1 = 1;
            PlayerPrefs.SetInt("sl1", SL1);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("saveGame1", save1Text.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("loadGame1", load1Text.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("nameLocation1", nameLocation1.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("nameLocation1Load", nameLocation1Load.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("display", display.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("displayLoad", displayLoad.text);
            PlayerPrefs.Save();
            gameManager.SavePlayer1();
            for (int i = 0; i < loadBatton.Length; i++)
            {
                loadBatton[0].interactable = true;
                loadBatton[5].gameObject.SetActive(true);
                loadBatton[10].gameObject.SetActive(true);
            }
        }
        else if (SL1 == 1)
        {
            camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
            saveGame.gameObject.SetActive(true);

            ButtonSave1.gameObject.SetActive(true);
            ButtonSave2.gameObject.SetActive(false);
            ButtonSave3.gameObject.SetActive(false);
            ButtonSave4.gameObject.SetActive(false);
            ButtonSave5.gameObject.SetActive(false);
        }
    }
    public void SaveGame2Button()
    {
        if (SL2 == 0)
        {
            DateTime now = DateTime.Now;
            display2.text = now.ToString("dd.MM.yyyy HH:mm");
            display2Load.text = display2.text;
            //hour = System.DateTime.Now.Hour;
            //minutes = System.DateTime.Now.Minute;
            //day = System.DateTime.Now.Day;
            //month = System.DateTime.Now.Month;
            //year = System.DateTime.Now.Year;
            //display2.text = day + "." + month + "." + year + " " + hour + ":" + minutes;
            //display2Load.text = display2.text;
            nameLocation2.text = "2";
            nameLocation2Load.text = nameLocation2.text;
            save2Text.text = "";
            load2Text.text = save2Text.text;
            SL2 = 1;
            PlayerPrefs.SetInt("sl2", SL2);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("saveGame2", save2Text.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("loadGame2", load2Text.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("nameLocation2", nameLocation2.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("nameLocation2Load", nameLocation2Load.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("display2", display2.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("display2Load", display2Load.text);
            PlayerPrefs.Save();
            gameManager.SavePlayer2();
            for (int i = 0; i < loadBatton.Length; i++)
            {
                loadBatton[1].interactable = true;
                loadBatton[6].gameObject.SetActive(true);
                loadBatton[11].gameObject.SetActive(true);
            }
        }
        else if (SL2 == 1)
        {
            camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
            saveGame.gameObject.SetActive(true);

            ButtonSave1.gameObject.SetActive(false);
            ButtonSave2.gameObject.SetActive(true);
            ButtonSave3.gameObject.SetActive(false);
            ButtonSave4.gameObject.SetActive(false);
            ButtonSave5.gameObject.SetActive(false);
        }
    }
    public void SaveGame3Button()
    {
        if (SL3 == 0)
        {
            DateTime now = DateTime.Now;
            display3.text = now.ToString("dd.MM.yyyy HH:mm");
            display3Load.text = display3.text;
            //hour = System.DateTime.Now.Hour;
            //minutes = System.DateTime.Now.Minute;
            //day = System.DateTime.Now.Day;
            //month = System.DateTime.Now.Month;
            //year = System.DateTime.Now.Year;
            //display3.text = day + "." + month + "." + year + " " + hour + ":" + minutes;
            //display3Load.text = display3.text;
            nameLocation3.text = "3";
            nameLocation3Load.text = nameLocation3.text;
            save3Text.text = "";
            load3Text.text = save3Text.text;
            SL3 = 1;
            PlayerPrefs.SetInt("sl3", SL3);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("saveGame3", save3Text.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("loadGame3", load3Text.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("nameLocation3", nameLocation3.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("nameLocation3Load", nameLocation3Load.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("display3", display3.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("display3Load", display3Load.text);
            PlayerPrefs.Save();
            gameManager.SavePlayer3();
            for (int i = 0; i < loadBatton.Length; i++)
            {
                loadBatton[2].interactable = true;
                loadBatton[7].gameObject.SetActive(true);
                loadBatton[12].gameObject.SetActive(true);
            }
        }
        else if (SL3 == 1)
        {
            camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
            saveGame.gameObject.SetActive(true);

            ButtonSave1.gameObject.SetActive(false);
            ButtonSave2.gameObject.SetActive(false);
            ButtonSave3.gameObject.SetActive(true);
            ButtonSave4.gameObject.SetActive(false);
            ButtonSave5.gameObject.SetActive(false);
        }
    }
    public void SaveGame4Button()
    {
        if (SL4 == 0)
        {
            DateTime now = DateTime.Now;
            display4.text = now.ToString("dd.MM.yyyy HH:mm");
            display4Load.text = display4.text;
            //hour = System.DateTime.Now.Hour;
            //minutes = System.DateTime.Now.Minute;
            //day = System.DateTime.Now.Day;
            //month = System.DateTime.Now.Month;
            //year = System.DateTime.Now.Year;
            //display4.text = day + "." + month + "." + year + " " + hour + ":" + minutes;
            //display4Load.text = display4.text;
            nameLocation4.text = "4";
            nameLocation4Load.text = nameLocation4.text;
            save4Text.text = "";
            load4Text.text = save4Text.text;
            SL4 = 1;
            PlayerPrefs.SetInt("sl4", SL4);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("saveGame4", save4Text.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("loadGame4", load4Text.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("nameLocation4", nameLocation4.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("nameLocation4Load", nameLocation4Load.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("display4", display4.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("display4Load", display4Load.text);
            PlayerPrefs.Save();
            gameManager.SavePlayer4();
            for (int i = 0; i < loadBatton.Length; i++)
            {
                loadBatton[3].interactable = true;
                loadBatton[8].gameObject.SetActive(true);
                loadBatton[13].gameObject.SetActive(true);
            }
        }
        else if (SL4 == 1)
        {
            camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
            saveGame.gameObject.SetActive(true);

            ButtonSave1.gameObject.SetActive(false);
            ButtonSave2.gameObject.SetActive(false);
            ButtonSave3.gameObject.SetActive(false);
            ButtonSave4.gameObject.SetActive(true);
            ButtonSave5.gameObject.SetActive(false);
        }
    }
    public void SaveGame5Button()
    {
        if (SL5 == 0)
        {
            DateTime now = DateTime.Now;
            display5.text = now.ToString("dd.MM.yyyy HH:mm");
            display5Load.text = display5.text;
            //hour = System.DateTime.Now.Hour;
            //minutes = System.DateTime.Now.Minute;
            //day = System.DateTime.Now.Day;
            //month = System.DateTime.Now.Month;
            //year = System.DateTime.Now.Year;
            //display5.text = day + "." + month + "." + year + " " + hour + ":" + minutes;
            //display5Load.text = display5.text;
            nameLocation5.text = "5";
            nameLocation5Load.text = nameLocation5.text;
            save5Text.text = "";
            load5Text.text = save5Text.text;
            SL5 = 1;
            PlayerPrefs.SetInt("sl5", SL5);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("saveGame5", save5Text.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("loadGame5", load5Text.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("nameLocation5", nameLocation5.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("nameLocation5Load", nameLocation5Load.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("display5", display5.text);
            PlayerPrefs.Save();
            PlayerPrefs.SetString("display5Load", display5Load.text);
            PlayerPrefs.Save();
            gameManager.SavePlayer5();
            for (int i = 0; i < loadBatton.Length; i++)
            {
                loadBatton[4].interactable = true;
                loadBatton[9].gameObject.SetActive(true);
                loadBatton[14].gameObject.SetActive(true);
            }
        }
        else if (SL5 == 1)
        {
            camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
            saveGame.gameObject.SetActive(true);

            ButtonSave1.gameObject.SetActive(false);
            ButtonSave2.gameObject.SetActive(false);
            ButtonSave3.gameObject.SetActive(false);
            ButtonSave4.gameObject.SetActive(false);
            ButtonSave5.gameObject.SetActive(true);
        }
    }

    public void SaveGame1()
    {
        DateTime now = DateTime.Now;
        display.text = now.ToString("dd.MM.yyyy HH:mm");
        displayLoad.text = display.text;
        nameLocation1.text = "1";
        nameLocation1Load.text = nameLocation1.text;
        save1Text.text = "";
        load1Text.text = save1Text.text;
        SL1 = 1;
        PlayerPrefs.SetInt("sl1", SL1);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("saveGame1", save1Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("loadGame1", load1Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation1", nameLocation1.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation1Load", nameLocation1Load.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display", display.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("displayLoad", displayLoad.text);
        PlayerPrefs.Save();
        saveGame.gameObject.SetActive(false);
        gameManager.SavePlayer1();
        for (int i = 0; i < loadBatton.Length; i++)
        {
            loadBatton[0].interactable = true;
            loadBatton[5].gameObject.SetActive(true);
            loadBatton[10].gameObject.SetActive(true);
        }
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = false;
    }
    public void SaveGame2()
    {
        DateTime now = DateTime.Now;
        display2.text = now.ToString("dd.MM.yyyy HH:mm");
        display2Load.text = display2.text;
        //hour = System.DateTime.Now.Hour;
        //minutes = System.DateTime.Now.Minute;
        //day = System.DateTime.Now.Day;
        //month = System.DateTime.Now.Month;
        //year = System.DateTime.Now.Year;
        //display2.text = day + "." + month + "." + year + " " + hour + ":" + minutes;
        //display2Load.text = display2.text;
        nameLocation2.text = "2";
        nameLocation2Load.text = nameLocation2.text;
        save2Text.text = "";
        load2Text.text = save2Text.text;
        SL2 = 1;
        PlayerPrefs.SetInt("sl2", SL2);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("saveGame2", save2Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("loadGame2", load2Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation2", nameLocation2.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation2Load", nameLocation2Load.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display2", display2.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display2Load", display2Load.text);
        PlayerPrefs.Save();
        saveGame.gameObject.SetActive(false);
        gameManager.SavePlayer2();
        for (int i = 0; i < loadBatton.Length; i++)
        {
            loadBatton[1].interactable = true;
            loadBatton[6].gameObject.SetActive(true);
            loadBatton[11].gameObject.SetActive(true);
        }
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = false;
    }
    public void SaveGame3()
    {
        DateTime now = DateTime.Now;
        display3.text = now.ToString("dd.MM.yyyy HH:mm");
        display3Load.text = display3.text;
        //hour = System.DateTime.Now.Hour;
        //minutes = System.DateTime.Now.Minute;
        //day = System.DateTime.Now.Day;
        //month = System.DateTime.Now.Month;
        //year = System.DateTime.Now.Year;
        //display3.text = day + "." + month + "." + year + " " + hour + ":" + minutes;
        //display3Load.text = display3.text;
        nameLocation3.text = "3";
        nameLocation3Load.text = nameLocation3.text;
        save3Text.text = "";
        load3Text.text = save3Text.text;
        SL3 = 1;
        PlayerPrefs.SetInt("sl3", SL3);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("saveGame3", save3Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("loadGame3", load3Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation3", nameLocation3.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation3Load", nameLocation3Load.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display3", display3.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display3Load", display3Load.text);
        PlayerPrefs.Save();
        saveGame.gameObject.SetActive(false);
        gameManager.SavePlayer3();
        for (int i = 0; i < loadBatton.Length; i++)
        {
            loadBatton[2].interactable = true;
            loadBatton[7].gameObject.SetActive(true);
            loadBatton[12].gameObject.SetActive(true);
        }
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = false;
    }
    public void SaveGame4()
    {
        DateTime now = DateTime.Now;
        display4.text = now.ToString("dd.MM.yyyy HH:mm");
        display4Load.text = display4.text;
        //hour = System.DateTime.Now.Hour;
        //minutes = System.DateTime.Now.Minute;
        //day = System.DateTime.Now.Day;
        //month = System.DateTime.Now.Month;
        //year = System.DateTime.Now.Year;
        //display4.text = day + "." + month + "." + year + " " + hour + ":" + minutes;
        //display4Load.text = display4.text;
        nameLocation4.text = "4";
        nameLocation4Load.text = nameLocation4.text;
        save4Text.text = "";
        load4Text.text = save4Text.text;
        SL4 = 1;
        PlayerPrefs.SetInt("sl4", SL4);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("saveGame4", save4Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("loadGame4", load4Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation4", nameLocation4.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation4Load", nameLocation4Load.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display4", display4.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display4Load", display4Load.text);
        PlayerPrefs.Save();
        saveGame.gameObject.SetActive(false);
        gameManager.SavePlayer4();
        for (int i = 0; i < loadBatton.Length; i++)
        {
            loadBatton[3].interactable = true;
            loadBatton[8].gameObject.SetActive(true);
            loadBatton[13].gameObject.SetActive(true);
        }
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = false;
    }
    public void SaveGame5()
    {
        DateTime now = DateTime.Now;
        display5.text = now.ToString("dd.MM.yyyy HH:mm");
        display5Load.text = display5.text;
        //hour = System.DateTime.Now.Hour;
        //minutes = System.DateTime.Now.Minute;
        //day = System.DateTime.Now.Day;
        //month = System.DateTime.Now.Month;
        //year = System.DateTime.Now.Year;
        //display5.text = day + "." + month + "." + year + " " + hour + ":" + minutes;
        //display5Load.text = display5.text;
        nameLocation5.text = "5";
        nameLocation5Load.text = nameLocation5.text;
        save5Text.text = "";
        load5Text.text = save5Text.text;
        SL5 = 1;
        PlayerPrefs.SetInt("sl5", SL5);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("saveGame5", save5Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("loadGame5", load5Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation5", nameLocation5.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation5Load", nameLocation5Load.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display5", display5.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display5Load", display5Load.text);
        PlayerPrefs.Save();
        saveGame.gameObject.SetActive(false);
        gameManager.SavePlayer5();
        for (int i = 0; i < loadBatton.Length; i++)
        {
            loadBatton[4].interactable = true;
            loadBatton[9].gameObject.SetActive(true);
            loadBatton[14].gameObject.SetActive(true);
        }
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = false;
    }

    public void Reset1()
    {
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
        resetGame.gameObject.SetActive(true);

        ButtonReset1Canvas.gameObject.SetActive(true);
        ButtonReset2Canvas.gameObject.SetActive(false);
        ButtonReset3Canvas.gameObject.SetActive(false);
        ButtonReset4Canvas.gameObject.SetActive(false);
        ButtonReset5Canvas.gameObject.SetActive(false);
    }
    public void Reset2()
    {
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
        resetGame.gameObject.SetActive(true);

        ButtonReset1Canvas.gameObject.SetActive(false);
        ButtonReset2Canvas.gameObject.SetActive(true);
        ButtonReset3Canvas.gameObject.SetActive(false);
        ButtonReset4Canvas.gameObject.SetActive(false);
        ButtonReset5Canvas.gameObject.SetActive(false);
    }
    public void Reset3()
    {
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
        resetGame.gameObject.SetActive(true);

        ButtonReset1Canvas.gameObject.SetActive(false);
        ButtonReset2Canvas.gameObject.SetActive(false);
        ButtonReset3Canvas.gameObject.SetActive(true);
        ButtonReset4Canvas.gameObject.SetActive(false);
        ButtonReset5Canvas.gameObject.SetActive(false);
    }
    public void Reset4()
    {
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
        resetGame.gameObject.SetActive(true);

        ButtonReset1Canvas.gameObject.SetActive(false);
        ButtonReset2Canvas.gameObject.SetActive(false);
        ButtonReset3Canvas.gameObject.SetActive(false);
        ButtonReset4Canvas.gameObject.SetActive(true);
        ButtonReset5Canvas.gameObject.SetActive(false);
    }
    public void Reset5()
    {
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
        resetGame.gameObject.SetActive(true);

        ButtonReset1Canvas.gameObject.SetActive(false);
        ButtonReset2Canvas.gameObject.SetActive(false);
        ButtonReset3Canvas.gameObject.SetActive(false);
        ButtonReset4Canvas.gameObject.SetActive(false);
        ButtonReset5Canvas.gameObject.SetActive(true);
    }
    public void ResetGame1()
    {
        save1Text.text = "Empty slot";
        load1Text.text = save1Text.text;
        nameLocation1.text = "";
        nameLocation1Load.text = nameLocation1.text;
        display.text = "";
        displayLoad.text = display.text;
        SL1 = 0;
        PlayerPrefs.SetInt("sl1", SL1);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("saveGame1", save1Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("loadGame1", load1Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation1", nameLocation1.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation1Load", nameLocation1Load.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display", display.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("displayLoad", displayLoad.text);
        PlayerPrefs.Save();
        gameManager.ResetPlayer1();
        for (int i = 0; i < loadBatton.Length; i++)
        {
            loadBatton[0].interactable = false;
            loadBatton[5].gameObject.SetActive(false);
            loadBatton[10].gameObject.SetActive(false);
        }
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = false;
        resetGame.gameObject.SetActive(false);
    }
    public void ResetGame2()
    {
        save2Text.text = "Empty slot";
        load2Text.text = save2Text.text;
        nameLocation2.text = "";
        nameLocation2Load.text = nameLocation2.text;
        display2.text = "";
        display2Load.text = display2.text;
        SL2 = 0;
        PlayerPrefs.SetInt("sl2", SL2);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("saveGame2", save2Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("loadGame2", load2Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation2", nameLocation2.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation2Load", nameLocation2Load.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display2", display2.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display2Load", display2Load.text);
        PlayerPrefs.Save();
        gameManager.ResetPlayer2();
        for (int i = 0; i < loadBatton.Length; i++)
        {
            loadBatton[1].interactable = false;
            loadBatton[6].gameObject.SetActive(false);
            loadBatton[11].gameObject.SetActive(false);
        }
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = false;
        resetGame.gameObject.SetActive(false);
    }
    public void ResetGame3()
    {
        save3Text.text = "Empty slot";
        load3Text.text = save3Text.text;
        nameLocation3.text = "";
        nameLocation3Load.text = nameLocation3.text;
        display3.text = "";
        display3Load.text = display3.text;
        SL3 = 0;
        PlayerPrefs.SetInt("sl3", SL3);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("saveGame3", save3Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("loadGame3", load3Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation3", nameLocation3.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation3Load", nameLocation3Load.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display3", display3.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display3Load", display3Load.text);
        PlayerPrefs.Save();
        gameManager.ResetPlayer3();
        for (int i = 0; i < loadBatton.Length; i++)
        {
            loadBatton[2].interactable = false;
            loadBatton[7].gameObject.SetActive(false);
            loadBatton[12].gameObject.SetActive(false);
        }
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = false;
        resetGame.gameObject.SetActive(false);
    }
    public void ResetGame4()
    {
        save4Text.text = "Empty slot";
        load4Text.text = save4Text.text;
        nameLocation4.text = "";
        nameLocation4Load.text = nameLocation4.text;
        display4.text = "";
        display4Load.text = display4.text;
        SL4 = 0;
        PlayerPrefs.SetInt("sl4", SL4);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("saveGame4", save4Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("loadGame4", load4Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation4", nameLocation4.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation4Load", nameLocation4Load.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display4", display4.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display4Load", display4Load.text);
        PlayerPrefs.Save();
        gameManager.ResetPlayer4();
        for (int i = 0; i < loadBatton.Length; i++)
        {
            loadBatton[3].interactable = false;
            loadBatton[8].gameObject.SetActive(false);
            loadBatton[13].gameObject.SetActive(false);
        }
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = false;
        resetGame.gameObject.SetActive(false);
    }
    public void ResetGame5()
    {
        save5Text.text = "Empty slot";
        load5Text.text = save5Text.text;
        nameLocation5.text = "";
        nameLocation5Load.text = nameLocation5.text;
        display5.text = "";
        display5Load.text = display5.text;
        SL5 = 0;
        PlayerPrefs.SetInt("sl5", SL5);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("saveGame5", save5Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("loadGame5", load5Text.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation5", nameLocation5.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("nameLocation5Load", nameLocation5Load.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display5", display5.text);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("display5Load", display5Load.text);
        PlayerPrefs.Save();
        gameManager.ResetPlayer5();
        for (int i = 0; i < loadBatton.Length; i++)
        {
            loadBatton[4].interactable = false;
            loadBatton[9].gameObject.SetActive(false);
            loadBatton[14].gameObject.SetActive(false);
        }
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = false;
        resetGame.gameObject.SetActive(false);
    }

    public void BackSaveGame()
    {
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = false;
        saveGame.gameObject.SetActive(false);
        resetGame.gameObject.SetActive(false);
    }

    public void SaveGo()
    {
        if(gameManager.saveGo == 1)
        {
            saveSave.gameObject.SetActive(true);
        }
        else
        {
            money.gameObject.SetActive(true);
        }
    }
}
