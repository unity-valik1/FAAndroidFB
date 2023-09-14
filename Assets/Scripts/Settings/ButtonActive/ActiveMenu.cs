using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class ActiveMenu : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private ActiveChapter activeChapter;
    //[SerializeField] private ActiveCamp activeCamp;
    [SerializeField] private MusicMenu musicMenu;
    [SerializeField] private MusicCharter musicCharter;
    [SerializeField] private SaveAndLoad saveAndLoad;
    [SerializeField] private Animation anim;
    [SerializeField] private Stopwatch stopwatch;
    [SerializeField] private SaveName saveName;
    [SerializeField] private AnimContent animContent;

    public GameObject menuUI;
    public GameObject buttonContinueGame;
    public GameObject loadUI;
    public GameObject settingsUI;
    public GameObject achievementsUI;
    public GameObject typographyUI;
    public GameObject soundsUI;
    public GameObject aboutUI;
    public GameObject howToPlayUI;
    public GameObject aboutUsUI;

    public GameObject howToPlayNewGame;

    public Image menuBgImg;

    public Sprite[] spriteMenuBg;



    [SerializeField] private Image imgMenuAnim;
    public string gg;
    //public List<GameObject> buttons;


    public void Start()
    {
        imgMenuAnim.gameObject.SetActive(true);
        anim.Play("LoadingMenuAnim");
        Invoke("Invoker1", 1f);
        if (PlayerPrefs.HasKey("continueGame"))
        {
            saveAndLoad.continueGame = PlayerPrefs.GetInt("continueGame");
        }
        Menu();
        ImgRandom();
    }

    public void ImgRandom()
    {
        int a = UnityEngine.Random.Range(0, 4);
        if (a == 0)
        {
            menuBgImg.sprite = spriteMenuBg[a];
        }
        else if (a == 1)
        {
            menuBgImg.sprite = spriteMenuBg[a];
        }
        else if (a == 2)
        {
            menuBgImg.sprite = spriteMenuBg[a];
        }
        else if (a == 3)
        {
            menuBgImg.sprite = spriteMenuBg[a];
        }

    }
    public void StartButton()
    {
        stopwatch.StopTimer();
        gg = stopwatch.timerText;
        FireBaseAnalyticsEvents.EventsNewGame1("NewGame", gg);
        stopwatch.ResetTimer();
        stopwatch.gameObject.SetActive(false);
        saveName.NewGameNameSave();
        if (saveAndLoad.continueGame == 0)
        {
            HowToPlayNewGame();
        }
        else
        {
            //camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
            saveAndLoad.lossGameStart.gameObject.SetActive(true);
        }
    }
    public void HowToPlayNewGame()
    {
        FireBaseAnalyticsEvents.EventsNewGameStart("NewGameStart");
        imgMenuAnim.gameObject.SetActive(true);
        anim.Play("MenuStartAnim");

        saveAndLoad.lossGameStart.gameObject.SetActive(false);

        Invoke("Invoker3", 1f);
        Invoke("Invoker4", 2f);
        saveName.NewGameNameSave();
    }
    public void Invoker3()
    {
        menuUI.gameObject.SetActive(false);
        howToPlayNewGame.gameObject.SetActive(true);
        animContent.AllAnim();
    }
    public void Invoker4()
    {
        imgMenuAnim.gameObject.SetActive(false);
    }
    //public void YesStartButton()
    //{
    //    //FireBaseAnalyticsEvents.EventsCharter("жопа");
    //    menuUI.gameObject.SetActive(false);

    //    saveAndLoad.continueGame = 1;
    //    PlayerPrefs.SetInt("continueGame", saveAndLoad.continueGame);
    //    PlayerPrefs.Save();

    //    musicMenu.MenuMusic();
    //    activeChapter.Charter1_1UI(0);

    //    camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = false;
    //    saveAndLoad.lossGameStart.gameObject.SetActive(false);
    //}
    public void YesNewGameButton()
    {
        imgMenuAnim.gameObject.SetActive(true);
        anim.Play("MenuStartAnim");

        saveAndLoad.lossGameStart.gameObject.SetActive(false);

        Invoke("Invoker", 1f);
        Invoke("Invoker1", 2f);
    }
    public void Invoker()
    {
        saveAndLoad.continueGame = 1;
        PlayerPrefs.SetInt("continueGame", saveAndLoad.continueGame);
        PlayerPrefs.Save();
        menuUI.gameObject.SetActive(false);
        howToPlayNewGame.gameObject.SetActive(false);
        musicMenu.StopMusic();
        activeChapter.Charter1_1UI(0);
    }
    public void Invoker1()
    {
        imgMenuAnim.gameObject.SetActive(false);
    }

    public void BackLossGame()
    {
        FireBaseAnalyticsEvents.EventsNewGameClose("NewGameClose");
        saveAndLoad.lossGameStart.gameObject.SetActive(false);
        saveAndLoad.lossGameLoad.gameObject.SetActive(false);
    }
    public void BackLoadGame()
    {
        saveAndLoad.lossGameStart.gameObject.SetActive(false);
        saveAndLoad.lossGameLoad.gameObject.SetActive(false);
    }

    public void Menu()
    {
        menuUI.gameObject.SetActive(true);
        loadUI.gameObject.SetActive(false);
        settingsUI.gameObject.SetActive(false);
        achievementsUI.gameObject.SetActive(false);
        typographyUI.gameObject.SetActive(false);
        soundsUI.gameObject.SetActive(false);
        aboutUI.gameObject.SetActive(false);
        howToPlayUI.gameObject.SetActive(false);
        aboutUsUI.gameObject.SetActive(false);

        if (saveAndLoad.continueGame == 0)
        {
            buttonContinueGame.SetActive(false);
        }
        else if (saveAndLoad.continueGame == 1)
        {
            buttonContinueGame.SetActive(true);
        }
    }

    public void BackMenu()
    {
        menuUI.gameObject.SetActive(true);
        loadUI.gameObject.SetActive(false);

        musicMenu.PlayMusic();

        if (saveAndLoad.continueGame == 0)
        {
            buttonContinueGame.SetActive(false);
        }
        else if (saveAndLoad.continueGame == 1)
        {
            buttonContinueGame.SetActive(true);
        }
    }

    public void LoadMenu()
    {
        if (gameManager.saveGo == 1)
        {
            menuUI.gameObject.SetActive(false);
            loadUI.gameObject.SetActive(true);
        }
        else
        {
            saveAndLoad.money.SetActive(true);
        }
    }

    public void YesLoadGame()
    {
        saveAndLoad.lossGameLoad.gameObject.SetActive(false);
    }

    public void Settings()
    {
        FireBaseAnalyticsEvents.EventsSettings("Settings");
        menuUI.gameObject.SetActive(false);
        loadUI.gameObject.SetActive(false);
        settingsUI.gameObject.SetActive(true);
        typographyUI.gameObject.SetActive(false);
        soundsUI.gameObject.SetActive(false);
    }
    public void About()
    {
        FireBaseAnalyticsEvents.EventsAbout("About");
        menuUI.gameObject.SetActive(false);
        aboutUI.gameObject.SetActive(true);
        howToPlayUI.gameObject.SetActive(false);
        aboutUsUI.gameObject.SetActive(false);
    }
    public void HowToPlay()
    {
        aboutUI.gameObject.SetActive(false);
        howToPlayUI.gameObject.SetActive(true);
    }
    public void AboutUs()
    {
        aboutUI.gameObject.SetActive(false);
        aboutUsUI.gameObject.SetActive(true);
    }
    public void Achievements()
    {
        FireBaseAnalyticsEvents.EventsAchievements("Achievements");
        menuUI.gameObject.SetActive(false);
        achievementsUI.gameObject.SetActive(true);
    }

    public void Typography()
    {
        FireBaseAnalyticsEvents.EventsTyphography("Typhography");
        settingsUI.gameObject.SetActive(false);
        typographyUI.gameObject.SetActive(true);

    }

    public void Sounds()
    {
        FireBaseAnalyticsEvents.EventsMusicSounds("MusicSounds");
        settingsUI.gameObject.SetActive(false);
        soundsUI.gameObject.SetActive(true);
    }

    public void Load()
    {
        imgMenuAnim.gameObject.SetActive(true);
        anim.Play("MenuStartAnim");
        Invoke("Invoker2", 1f);
        Invoke("Invoker1", 2f);
    }
    public void Invoker2()
    {
        FireBaseAnalyticsEvents.EventsContinueGame("ContinueGame");
        menuUI.gameObject.SetActive(false);
        loadUI.gameObject.SetActive(false);
        musicMenu.StopMusic();
        musicCharter.PlayMusic(0);
        gameManager.LoadPlayer();
    }
    public void Load1()
    {
        imgMenuAnim.gameObject.SetActive(true);
        anim.Play("MenuStartAnim");
        Invoke("Invoker2_1", 1f);
        Invoke("Invoker1", 2f);
    }
    public void Invoker2_1()
    {
        menuUI.gameObject.SetActive(false);
        loadUI.gameObject.SetActive(false);
    }
}
