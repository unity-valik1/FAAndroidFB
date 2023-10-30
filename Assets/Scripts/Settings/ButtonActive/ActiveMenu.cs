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
    public int _howToPlayNewGame = 0;

    public int ActiveOrNot = 0;

    //public Image menuBgImg;

    //public Sprite[] spriteMenuBg;



    [SerializeField] private Image imgMenuAnim;
    public string gg;
    //public List<GameObject> buttons;


    public void Start()
    {
        imgMenuAnim.gameObject.SetActive(true);
        anim.Play("LoadingMenuAnim");
        Invoke("Invoker1_1", 1f);
        if (PlayerPrefs.HasKey("continueGame"))
        {
            saveAndLoad.continueGame = PlayerPrefs.GetInt("continueGame");
        }
        if (PlayerPrefs.HasKey("howToPlayNewGame"))
        {
            _howToPlayNewGame = PlayerPrefs.GetInt("howToPlayNewGame");
        }
        Menu();
        //ImgRandom();
    }

    //public void ImgRandom()
    //{
    //    int a = UnityEngine.Random.Range(0, 4);
    //    if (a == 0)
    //    {
    //        menuBgImg.sprite = spriteMenuBg[a];
    //    }
    //    else if (a == 1)
    //    {
    //        menuBgImg.sprite = spriteMenuBg[a];
    //    }
    //    else if (a == 2)
    //    {
    //        menuBgImg.sprite = spriteMenuBg[a];
    //    }
    //    else if (a == 3)
    //    {
    //        menuBgImg.sprite = spriteMenuBg[a];
    //    }

    //}
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
            if (_howToPlayNewGame == 0)
            {
                _howToPlayNewGame = 1;
                PlayerPrefs.SetInt("howToPlayNewGame", _howToPlayNewGame);
                PlayerPrefs.Save();
                HowToPlayNewGame();
            }
            else if (_howToPlayNewGame == 1)
            {
                YesNewGameButton();
            }
        }
        else
        {
            saveAndLoad.lossGameStart.gameObject.SetActive(true);
        }
    }
    public void StartButton_EndGame()
    {
        FireBaseAnalyticsEvents.EventsNewGame1("NewGame", gg);
        saveName.NewGameNameSave();
        Invoke("OffAllScrenes", 0.9f);
        if (_howToPlayNewGame == 0)
        {
            _howToPlayNewGame = 1;
            PlayerPrefs.SetInt("howToPlayNewGame", _howToPlayNewGame);
            PlayerPrefs.Save();
            HowToPlayNewGame();
        }
        else if (_howToPlayNewGame == 1)
        {
            YesNewGameButton();
        }
    }
    private void OffAllScrenes()
    {
        for (int i = 0; i < activeChapter.charter.Length; i++)
        {
            activeChapter.charter[i].SetActive(false);
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
        Invoke("Invoker5", 7f);
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
        activeChapter.imgBlackout.gameObject.SetActive(true);
    }
    public void Invoker5()
    {
        activeChapter.imgBlackout.gameObject.SetActive(false);
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
        Invoke("Invoker5", 7f);
    }
    public void Invoker()
    {
        gameManager.ResetPlayer();
        gameManager.Null();
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
        activeChapter.imgBlackout.gameObject.SetActive(true);
    }
    public void Invoker1_1()
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

        for (int i = 0; i < activeChapter.charter.Length; i++)
        {
            if(gameManager.charter[i] == 1)
            {
                ActiveOrNot = 1;
            }
        }
        if(ActiveOrNot == 0)
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
        else if(ActiveOrNot == 1)
        {
            loadUI.gameObject.SetActive(false);
        }
        ActiveOrNot = 0;
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
        gameManager.load_buy = 1;
        gameManager.save_buy = 0;
        //menuUI.gameObject.SetActive(false);
        //loadUI.gameObject.SetActive(true);
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
        Invoke("Invoker5", 7f);
    }
    public void Invoker2()
    {
        FireBaseAnalyticsEvents.EventsContinueGame("ContinueGame");
        menuUI.gameObject.SetActive(false);
        loadUI.gameObject.SetActive(false);
        musicMenu.StopMusic();
        gameManager.LoadPlayer();
    }
    public void Load1()
    {
        imgMenuAnim.gameObject.SetActive(true);
        anim.Play("MenuStartAnim");
        Invoke("Invoker2_1", 0.5f);
        Invoke("Invoker1", 2f);
        Invoke("Invoker5", 7f);
    }
    public void Invoker2_1()
    {
        menuUI.gameObject.SetActive(false);
        loadUI.gameObject.SetActive(false);
    }
    public void Web()
    {
        Application.OpenURL("https://textbased.app/");
    }
    public void Mail()
    {
        Application.OpenURL("mailto:support@textbased.app");
    }
    public void Inst()
    {
        Application.OpenURL("https://www.instagram.com/textbasedapp/");
    }
    public void FaceBook()
    {
        Application.OpenURL("https://www.facebook.com/textbasedapp/");
    }

}
