using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class ActiveChapter : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private ActiveMenu activeMenu;
    [SerializeField] private ActiveCamp activeCamp;
    [SerializeField] private TPCharter tPCharter;
    [SerializeField] private MusicMenu musicMenu;
    [SerializeField] private MusicCharter musicCharter;
    [SerializeField] private MusicCamp musicCamp;
    [SerializeField] private Achievements achievements;
    [SerializeField] private SaveAndLoad saveAndLoad;
    [SerializeField] private Animation anim;
    [SerializeField] private Theme theme;
    [SerializeField] private Camera camera1;

    public GameObject panel;
    public GameObject[] charter;

    [SerializeField] private Image imgBlackout;
    public TMP_Text toBeContinued;
    public GameObject rateUs;
    public Button star1;
    public Button star2;
    public Button star3;
    public Button star4;
    public Button star5;
    public Sprite starYes;
    public Sprite starNo;

    public void CharterActiveUpdate()
    {
        if (gameManager.charter1UI == true)
        {
            Charter1UI(0);
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }

        else if (gameManager.charter2UI == true)
        {
            Charter2UI(1);
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }

        else if (gameManager.charter3UI == true)
        {
            Charter3UI(2);
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }

        else if (gameManager.charter4UI == true)
        {
            Charter4UI(3);
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }

        else if (gameManager.charter5UI == true)
        {
            Charter5UI(4);
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }

        else if (gameManager.charter6UI == true)
        {
            Charter6UI(5);
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }

        else if (gameManager.charter7UI == true)
        {
            Charter7UI(6);
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }

        else if (gameManager.charter8UI == true)
        {
            Charter8UI(7);
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }

        else if (gameManager.charter9UI == true)
        {
            Charter9UI(8);
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }

        else if (gameManager.charter10UI == true)
        {
            Charter10UI(9);
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }

        else if (gameManager.charter11UI == true)
        {
            Charter11UI(10);
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }

        else if (gameManager.charter12UI == true)
        {
            Charter12UI(11);
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }

        else if (gameManager.charter13UI == true)
        {
            Charter13UI(12);
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.ToBeContinued == true)
        {
            ToBeContinued(13);
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else
        {
            gameManager.charter1UI = false;
            gameManager.charter2UI = false;
            gameManager.charter3UI = false;
            gameManager.charter4UI = false;
            gameManager.charter5UI = false;
            gameManager.charter6UI = false;
            gameManager.charter7UI = false;
            gameManager.charter8UI = false;
            gameManager.charter9UI = false;
            gameManager.charter10UI = false;
            gameManager.charter11UI = false;
            gameManager.charter13UI = false;
            gameManager.ToBeContinued = false;
        }
    }
    public void Charter1_1UI(int index)
    {
        gameManager.charter1UI = true;
        gameManager.charter2UI = false;
        gameManager.charter3UI = false;
        gameManager.charter4UI = false;
        gameManager.charter5UI = false;
        gameManager.charter6UI = false;
        gameManager.charter7UI = false;
        gameManager.charter8UI = false;
        gameManager.charter9UI = false;
        gameManager.charter10UI = false;
        gameManager.charter11UI = false;
        gameManager.charter12UI = false;
        gameManager.charter13UI = false;
        gameManager.ToBeContinued = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
        panel.gameObject.SetActive(true);
        tPCharter.C1();
        musicCharter.CharterMusic();
        gameManager.SavePlayer();
    }
    public void Charter1UI(int index)
    {
        gameManager.charter1UI = true;
        gameManager.charter2UI = false;
        gameManager.charter3UI = false;
        gameManager.charter4UI = false;
        gameManager.charter5UI = false;
        gameManager.charter6UI = false;
        gameManager.charter7UI = false;
        gameManager.charter8UI = false;
        gameManager.charter9UI = false;
        gameManager.charter10UI = false;
        gameManager.charter11UI = false;
        gameManager.charter12UI = false;
        gameManager.charter13UI = false;
        gameManager.ToBeContinued = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
        gameManager.SavePlayer();
    }

    public void ButtonC2()
    {
        imgBlackout.gameObject.SetActive(true);
        if (theme.theme == 0)
        {
            anim.Play("BlackoutDarkAnimation");
        }
        else
        {
            anim.Play("BlackoutLightAnimation");
        }
        Invoke("InvokerC2", 0.5f);
        Invoke("InvokerAchievements1", 1f);
    }
    public void InvokerC2()
    {
        Charter2UI(1);
    }
    public void InvokerAchievements1()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements1();
        gameManager.SavePlayer();
    }
    public void Charter2UI(int index)
    {
        gameManager.charter1UI = false;
        gameManager.charter2UI = true;
        gameManager.charter3UI = false;
        gameManager.charter4UI = false;
        gameManager.charter5UI = false;
        gameManager.charter6UI = false;
        gameManager.charter7UI = false;
        gameManager.charter8UI = false;
        gameManager.charter9UI = false;
        gameManager.charter10UI = false;
        gameManager.charter11UI = false;
        gameManager.charter12UI = false;
        gameManager.charter13UI = false;
        gameManager.ToBeContinued = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
    }

    public void ButtonC3()
    {
        imgBlackout.gameObject.SetActive(true);
        if (theme.theme == 0)
        {
            anim.Play("BlackoutDarkAnimation");
        }
        else
        {
            anim.Play("BlackoutLightAnimation");
        }
        Invoke("InvokerC3", 0.5f);
        Invoke("InvokerAchievements2", 1f);
    }
    public void InvokerC3()
    {
        Charter3UI(2);
    }
    public void InvokerAchievements2()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements2();
        gameManager.SavePlayer();
    }
    public void Charter3UI(int index)
    {
        gameManager.charter1UI = false;
        gameManager.charter2UI = false;
        gameManager.charter3UI = true;
        gameManager.charter4UI = false;
        gameManager.charter5UI = false;
        gameManager.charter6UI = false;
        gameManager.charter7UI = false;
        gameManager.charter8UI = false;
        gameManager.charter9UI = false;
        gameManager.charter10UI = false;
        gameManager.charter11UI = false;
        gameManager.charter12UI = false;
        gameManager.charter13UI = false;
        gameManager.ToBeContinued = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
    }

    public void ButtonC4()
    {
        imgBlackout.gameObject.SetActive(true);
        if (theme.theme == 0)
        {
            anim.Play("BlackoutDarkAnimation");
        }
        else
        {
            anim.Play("BlackoutLightAnimation");
        }
        Invoke("InvokerC4", 0.5f);
        Invoke("InvokerAchievements3", 1f);
    }
    public void InvokerC4()
    {
        Charter4UI(3);
    }
    public void InvokerAchievements3()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements3();
        gameManager.SavePlayer();
    }
    public void Charter4UI(int index)
    {
        gameManager.charter1UI = false;
        gameManager.charter2UI = false;
        gameManager.charter3UI = false;
        gameManager.charter4UI = true;
        gameManager.charter5UI = false;
        gameManager.charter6UI = false;
        gameManager.charter7UI = false;
        gameManager.charter8UI = false;
        gameManager.charter9UI = false;
        gameManager.charter10UI = false;
        gameManager.charter11UI = false;
        gameManager.charter12UI = false;
        gameManager.charter13UI = false;
        gameManager.ToBeContinued = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
    }

    public void ButtonC5()
    {
        imgBlackout.gameObject.SetActive(true);
        if (theme.theme == 0)
        {
            anim.Play("BlackoutDarkAnimation");
        }
        else
        {
            anim.Play("BlackoutLightAnimation");
        }
        Invoke("InvokerC5", 0.5f);
        Invoke("InvokerAchievements4", 1f);
    }
    public void InvokerC5()
    {
        Charter5UI(4);
    }
    public void InvokerAchievements4()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements4();
        gameManager.SavePlayer();
    }
    public void Charter5UI(int index)
    {
        gameManager.charter1UI = false;
        gameManager.charter2UI = false;
        gameManager.charter3UI = false;
        gameManager.charter4UI = false;
        gameManager.charter5UI = true;
        gameManager.charter6UI = false;
        gameManager.charter7UI = false;
        gameManager.charter8UI = false;
        gameManager.charter9UI = false;
        gameManager.charter10UI = false;
        gameManager.charter11UI = false;
        gameManager.charter12UI = false;
        gameManager.charter13UI = false;
        gameManager.ToBeContinued = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
    }

    public void ButtonC6()
    {
        imgBlackout.gameObject.SetActive(true);
        if (theme.theme == 0)
        {
            anim.Play("BlackoutDarkAnimation");
        }
        else
        {
            anim.Play("BlackoutLightAnimation");
        }
        Invoke("InvokerC6", 0.5f);
        Invoke("InvokerAchievements5", 1f);
    }
    public void InvokerC6()
    {
        Charter6UI(5);
    }
    public void InvokerAchievements5()
    {
        imgBlackout.gameObject.SetActive(false);
        gameManager.SavePlayer();
    }
    public void Charter6UI(int index)
    {
        gameManager.charter1UI = false;
        gameManager.charter2UI = false;
        gameManager.charter3UI = false;
        gameManager.charter4UI = false;
        gameManager.charter5UI = false;
        gameManager.charter6UI = true;
        gameManager.charter7UI = false;
        gameManager.charter8UI = false;
        gameManager.charter9UI = false;
        gameManager.charter10UI = false;
        gameManager.charter11UI = false;
        gameManager.charter12UI = false;
        gameManager.charter13UI = false;
        gameManager.ToBeContinued = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
    }

    public void ButtonC7()
    {
        imgBlackout.gameObject.SetActive(true);
        if (theme.theme == 0)
        {
            anim.Play("BlackoutDarkAnimation");
        }
        else
        {
            anim.Play("BlackoutLightAnimation");
        }
        Invoke("InvokerC7", 0.5f);
        Invoke("InvokerAchievements6", 1f);
    }
    public void InvokerC7()
    {
        Charter7UI(6);
    }
    public void InvokerAchievements6()
    {
        imgBlackout.gameObject.SetActive(false);
        gameManager.SavePlayer();
    }
    public void Charter7UI(int index)
    {
        gameManager.charter1UI = false;
        gameManager.charter2UI = false;
        gameManager.charter3UI = false;
        gameManager.charter4UI = false;
        gameManager.charter5UI = false;
        gameManager.charter6UI = false;
        gameManager.charter7UI = true;
        gameManager.charter8UI = false;
        gameManager.charter9UI = false;
        gameManager.charter10UI = false;
        gameManager.charter11UI = false;
        gameManager.charter12UI = false;
        gameManager.charter13UI = false;
        gameManager.ToBeContinued = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
    }

    public void MenuCharter7UI(int index)
    {
        gameManager.charter1UI = false;
        gameManager.charter2UI = false;
        gameManager.charter3UI = false;
        gameManager.charter4UI = false;
        gameManager.charter5UI = false;
        gameManager.charter6UI = false;
        gameManager.charter7UI = false;
        gameManager.charter8UI = false;
        gameManager.charter9UI = false;
        gameManager.charter10UI = false;
        gameManager.charter11UI = false;
        gameManager.charter12UI = false;
        gameManager.charter13UI = false;
        gameManager.ToBeContinued = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
        panel.gameObject.SetActive(false);
        saveAndLoad.continueGame = 0;
        PlayerPrefs.SetInt("continueGame", saveAndLoad.continueGame);
        PlayerPrefs.Save();
        musicCharter.CharterMusic();
        gameManager.ResetPlayer();
        activeMenu.BackMenu();
    }

    public void ButtonC8()
    {
        imgBlackout.gameObject.SetActive(true);
        if (theme.theme == 0)
        {
            anim.Play("BlackoutDarkAnimation");
        }
        else
        {
            anim.Play("BlackoutLightAnimation");
        }
        Invoke("InvokerC8", 0.5f);
        Invoke("InvokerAchievements7", 1f);
    }
    public void InvokerC8()
    {
        Charter8UI(7);
    }
    public void InvokerAchievements7()
    {
        imgBlackout.gameObject.SetActive(false);
        gameManager.SavePlayer();
    }
    public void Charter8UI(int index)
    {
        gameManager.charter1UI = false;
        gameManager.charter2UI = false;
        gameManager.charter3UI = false;
        gameManager.charter4UI = false;
        gameManager.charter5UI = false;
        gameManager.charter6UI = false;
        gameManager.charter7UI = false;
        gameManager.charter8UI = true;
        gameManager.charter9UI = false;
        gameManager.charter10UI = false;
        gameManager.charter11UI = false;
        gameManager.charter12UI = false;
        gameManager.charter13UI = false;
        gameManager.ToBeContinued = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
    }

    public void ButtonC9()
    {
        imgBlackout.gameObject.SetActive(true);
        if (theme.theme == 0)
        {
            anim.Play("BlackoutDarkAnimation");
        }
        else
        {
            anim.Play("BlackoutLightAnimation");
        }
        Invoke("InvokerC9", 0.5f);
        Invoke("InvokerAchievements8", 1f);
    }
    public void InvokerC9()
    {
        Charter9UI(8);
    }
    public void InvokerAchievements8()
    {
        imgBlackout.gameObject.SetActive(false);
        gameManager.SavePlayer();
    }
    public void Charter9UI(int index)
    {
        gameManager.charter1UI = false;
        gameManager.charter2UI = false;
        gameManager.charter3UI = false;
        gameManager.charter4UI = false;
        gameManager.charter5UI = false;
        gameManager.charter6UI = false;
        gameManager.charter7UI = false;
        gameManager.charter8UI = false;
        gameManager.charter9UI = true;
        gameManager.charter10UI = false;
        gameManager.charter11UI = false;
        gameManager.charter12UI = false;
        gameManager.charter13UI = false;
        gameManager.ToBeContinued = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
    }

    public void ButtonC10()
    {
        imgBlackout.gameObject.SetActive(true);
        if (theme.theme == 0)
        {
            anim.Play("BlackoutDarkAnimation");
        }
        else
        {
            anim.Play("BlackoutLightAnimation");
        }
        Invoke("InvokerC10", 0.5f);
        Invoke("InvokerAchievements9", 1f);
    }
    public void InvokerC10()
    {
        Charter10UI(9);
    }
    public void InvokerAchievements9()
    {
        imgBlackout.gameObject.SetActive(false);
        gameManager.SavePlayer();
    }
    public void Charter10UI(int index)
    {
        gameManager.charter1UI = false;
        gameManager.charter2UI = false;
        gameManager.charter3UI = false;
        gameManager.charter4UI = false;
        gameManager.charter5UI = false;
        gameManager.charter6UI = false;
        gameManager.charter7UI = false;
        gameManager.charter8UI = false;
        gameManager.charter9UI = false;
        gameManager.charter10UI = true;
        gameManager.charter11UI = false;
        gameManager.charter12UI = false;
        gameManager.charter13UI = false;
        gameManager.ToBeContinued = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
    }

    public void ButtonC11()
    {
        imgBlackout.gameObject.SetActive(true);
        if (theme.theme == 0)
        {
            anim.Play("BlackoutDarkAnimation");
        }
        else
        {
            anim.Play("BlackoutLightAnimation");
        }
        Invoke("InvokerC11", 0.5f);
        Invoke("InvokerAchievements10", 1f);
    }
    public void InvokerC11()
    {
        Charter11UI(10);
    }
    public void InvokerAchievements10()
    {
        imgBlackout.gameObject.SetActive(false);
        gameManager.SavePlayer();
    }
    public void Charter11UI(int index)
    {
        gameManager.charter1UI = false;
        gameManager.charter2UI = false;
        gameManager.charter3UI = false;
        gameManager.charter4UI = false;
        gameManager.charter5UI = false;
        gameManager.charter6UI = false;
        gameManager.charter7UI = false;
        gameManager.charter8UI = false;
        gameManager.charter9UI = false;
        gameManager.charter10UI = false;
        gameManager.charter11UI = true;
        gameManager.charter12UI = false;
        gameManager.charter13UI = false;
        gameManager.ToBeContinued = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
    }

    public void ButtonC12()
    {
        imgBlackout.gameObject.SetActive(true);
        if (theme.theme == 0)
        {
            anim.Play("BlackoutDarkAnimation");
        }
        else
        {
            anim.Play("BlackoutLightAnimation");
        }
        Invoke("InvokerC12", 0.5f);
        Invoke("InvokerAchievements11", 1f);
    }
    public void InvokerC12()
    {
        Charter12UI(11);
    }
    public void InvokerAchievements11()
    {
        imgBlackout.gameObject.SetActive(false);
        gameManager.SavePlayer();
    }
    public void Charter12UI(int index)
    {
        gameManager.charter1UI = false;
        gameManager.charter2UI = false;
        gameManager.charter3UI = false;
        gameManager.charter4UI = false;
        gameManager.charter5UI = false;
        gameManager.charter6UI = false;
        gameManager.charter7UI = false;
        gameManager.charter8UI = false;
        gameManager.charter9UI = false;
        gameManager.charter10UI = false;
        gameManager.charter11UI = false;
        gameManager.charter12UI = true;
        gameManager.charter13UI = false;
        gameManager.ToBeContinued = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
    }

    public void ButtonC13()
    {
        imgBlackout.gameObject.SetActive(true);
        if (theme.theme == 0)
        {
            anim.Play("BlackoutDarkAnimation");
        }
        else
        {
            anim.Play("BlackoutLightAnimation");
        }
        Invoke("InvokerC13", 0.5f);
        Invoke("InvokerAchievements12", 1f);
    }
    public void InvokerC13()
    {
        Charter13UI(12);
    }
    public void InvokerAchievements12()
    {
        imgBlackout.gameObject.SetActive(false);
        gameManager.SavePlayer();
    }
    public void Charter13UI(int index)
    {
        gameManager.charter1UI = false;
        gameManager.charter2UI = false;
        gameManager.charter3UI = false;
        gameManager.charter4UI = false;
        gameManager.charter5UI = false;
        gameManager.charter6UI = false;
        gameManager.charter7UI = false;
        gameManager.charter8UI = false;
        gameManager.charter9UI = false;
        gameManager.charter10UI = false;
        gameManager.charter11UI = false;
        gameManager.charter12UI = false;
        gameManager.charter13UI = true;
        gameManager.ToBeContinued = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
    }

    public void ButtonC14()
    {
        imgBlackout.gameObject.SetActive(true);
        if (theme.theme == 0)
        {
            anim.Play("BlackoutDarkAnimation");
        }
        else
        {
            anim.Play("BlackoutLightAnimation");
        }
        Invoke("ToBeContinuedEnd", 0.5f);
        Invoke("InvokerAchievements13", 1f);
    }
    public void ToBeContinuedEnd()
    {
        ToBeContinued(13);
    }
    public void InvokerAchievements13()
    {
        imgBlackout.gameObject.SetActive(false);
        gameManager.SavePlayer();
    }
    public void ToBeContinued(int index)
    {
        toBeContinued.text = "To be continued...";
        gameManager.charter1UI = false;
        gameManager.charter2UI = false;
        gameManager.charter3UI = false;
        gameManager.charter4UI = false;
        gameManager.charter5UI = false;
        gameManager.charter6UI = false;
        gameManager.charter7UI = false;
        gameManager.charter8UI = false;
        gameManager.charter9UI = false;
        gameManager.charter10UI = false;
        gameManager.charter11UI = false;
        gameManager.charter12UI = false;
        gameManager.charter13UI = false;
        gameManager.ToBeContinued = true;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
    }

    public void CampCharter13UI(int index)
    {
        gameManager.charter1UI = false;
        gameManager.charter2UI = false;
        gameManager.charter3UI = false;
        gameManager.charter4UI = false;
        gameManager.charter5UI = false;
        gameManager.charter6UI = false;
        gameManager.charter7UI = false;
        gameManager.charter8UI = false;
        gameManager.charter9UI = false;
        gameManager.charter10UI = false;
        gameManager.charter11UI = false;
        gameManager.charter12UI = false;
        gameManager.charter13UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }

        panel.gameObject.SetActive(false);
        saveAndLoad.continueGame = 0;
        PlayerPrefs.SetInt("continueGame", saveAndLoad.continueGame);
        PlayerPrefs.Save();
        musicCharter.CharterMusic();
        gameManager.ResetPlayer();
        activeMenu.BackMenu();
    }

    public void MenuCharterPanel(int index)
    {
        toBeContinued.text = "Chapter 1";
        gameManager.charter1UI = false;
        gameManager.charter2UI = false;
        gameManager.charter3UI = false;
        gameManager.charter4UI = false;
        gameManager.charter5UI = false;
        gameManager.charter6UI = false;
        gameManager.charter7UI = false;
        gameManager.charter8UI = false;
        gameManager.charter9UI = false;
        gameManager.charter10UI = false;
        gameManager.charter11UI = false;
        gameManager.charter12UI = false;
        gameManager.charter13UI = false;
        gameManager.ToBeContinued = false;

        for (int i = 0; i < charter.Length; i++)
        {
            if (i == index)
            {
                charter[i].SetActive(true);
            }
            else
            {
                charter[i].SetActive(false);
            }
        }
        panel.gameObject.SetActive(false);
        musicCharter.CharterMusic();
        activeMenu.BackMenu();
    }

    public void RateUs()
    {
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
        rateUs.gameObject.SetActive(true);
    }

    public void RateUsClose()
    {
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = false;
        rateUs.gameObject.SetActive(false);
        Star5();
    }

    public void Star1()
    {
        star1.image.sprite = starYes;
        star2.image.sprite = starNo;
        star3.image.sprite = starNo;
        star4.image.sprite = starNo;
        star5.image.sprite = starNo;
    }
    public void Star2()
    {
        star1.image.sprite = starYes;
        star2.image.sprite = starYes;
        star3.image.sprite = starNo;
        star4.image.sprite = starNo;
        star5.image.sprite = starNo;
    }
    public void Star3()
    {
        star1.image.sprite = starYes;
        star2.image.sprite = starYes;
        star3.image.sprite = starYes;
        star4.image.sprite = starNo;
        star5.image.sprite = starNo;
    }
    public void Star4()
    {
        star1.image.sprite = starYes;
        star2.image.sprite = starYes;
        star3.image.sprite = starYes;
        star4.image.sprite = starYes;
        star5.image.sprite = starNo;
    }
    public void Star5()
    {
        star1.image.sprite = starYes;
        star2.image.sprite = starYes;
        star3.image.sprite = starYes;
        star4.image.sprite = starYes;
        star5.image.sprite = starYes;
    }
}
