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
    [SerializeField] private TPCharter tPCharter;
    [SerializeField] private MusicMenu musicMenu;
    [SerializeField] private MusicCharter musicCharter;
    [SerializeField] private Sound sound;
    [SerializeField] private Achievements achievements;
    [SerializeField] private SaveAndLoad saveAndLoad;
    [SerializeField] private Animation anim;
    [SerializeField] private AnimContent[] animContent;
    [SerializeField] private LogicValuesChapters logicValuesChapters;
    [SerializeField] private GameObject[] buttonIf;
    //[SerializeField] private ActiveCamp activeCamp;
    //[SerializeField] private MusicCamp musicCamp;

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
    public GameObject rateUsNot;
    public GameObject Img2;

    //Загрузка места сохранения
    public void CharterActiveUpdate()
    {
        if (gameManager.charter[0] == 1)
        {
            Charter1UI(0);
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[1] == 1)
        {
            ButtonC2();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[2] == 1)
        {
            ButtonC3();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[3] == 1)
        {
            ButtonC4();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[4] == 1)
        {
            ButtonC5();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[5] == 1)
        {
            ButtonC6();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[6] == 1)
        {
            ButtonC7();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[7] == 1)
        {
            ButtonC8();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[8] == 1)
        {
            ButtonC9();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[9] == 1)
        {
            ButtonC10();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[10] == 1)
        {
            ButtonC11();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[11] == 1)
        {
            ButtonC12();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[12] == 1)
        {
            ButtonC13();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[13] == 1)
        {
            ButtonC14();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[14] == 1)
        {
            ButtonC15();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[15] == 1)
        {
            ButtonC16();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[16] == 1)
        {
            ButtonC17();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[17] == 1)
        {
            ButtonC18();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[18] == 1)
        {
            ButtonC19();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[19] == 1)
        {
            ButtonC20();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[20] == 1)
        {
            ButtonC21();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[21] == 1)
        {
            ButtonC22();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[22] == 1)
        {
            ButtonC23();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[23] == 1)
        {
            ButtonC24();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[24] == 1)
        {
            ButtonC25();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[25] == 1)
        {
            ButtonC26();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[26] == 1)
        {
            ButtonC27();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[27] == 1)
        {
            ButtonC28();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[28] == 1)
        {
            ButtonC29();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[29] == 1)
        {
            ButtonC30();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[30] == 1)
        {
            ButtonC31();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[31] == 1)
        {
            ButtonC32();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[32] == 1)
        {
            ButtonC33();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[33] == 1)
        {
            ButtonC34();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[34] == 1)
        {
            ButtonC35();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[35] == 1)
        {
            ButtonC36();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[36] == 1)
        {
            ButtonC37();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[37] == 1)
        {
            ButtonC38();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[38] == 1)
        {
            ButtonC39();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[39] == 1)
        {
            ButtonC40();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[40] == 1)
        {
            ButtonC41();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[41] == 1)
        {
            ButtonC42();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[42] == 1)
        {
            ButtonC43();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else if (gameManager.charter[43] == 1)
        {
            ButtonC44();
            panel.gameObject.SetActive(true);
            tPCharter.C1();
        }
        else
        {
            for (int i = 0; i < gameManager.charter.Length; i++)
            {
                gameManager.charter[i] = 0;
            }
        }




        //if (gameManager.charter1UI == true)
        //{
        //    Charter1UI(0);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter2UI == true)
        //{
        //    Charter2UI(1);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter3UI == true)
        //{
        //    Charter3UI(2);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter4UI == true)
        //{
        //    Charter4UI(3);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter5UI == true)
        //{
        //    Charter5UI(4);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter6UI == true)
        //{
        //    Charter6UI(5);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter7UI == true)
        //{
        //    Charter7UI(6);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter8UI == true)
        //{
        //    Charter8UI(7);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter9UI == true)
        //{
        //    Charter9UI(8);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter10UI == true)
        //{
        //    Charter10UI(9);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter11UI == true)
        //{
        //    Charter11UI(10);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter12UI == true)
        //{
        //    Charter12UI(11);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter13UI == true)
        //{
        //    Charter13UI(12);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter14UI == true)
        //{
        //    Charter14UI(13);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter15UI == true)
        //{
        //    Charter15UI(14);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter16UI == true)
        //{
        //    Charter16UI(15);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter17UI == true)
        //{
        //    Charter17UI(16);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter18UI == true)
        //{
        //    Charter18UI(17);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter19UI == true)
        //{
        //    Charter19UI(18);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter20UI == true)
        //{
        //    Charter20UI(19);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter21UI == true)
        //{
        //    Charter21UI(20);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter22UI == true)
        //{
        //    Charter22UI(21);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter23UI == true)
        //{
        //    Charter23UI(22);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter24UI == true)
        //{
        //    Charter24UI(23);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter25UI == true)
        //{
        //    Charter25UI(24);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter26UI == true)
        //{
        //    Charter26UI(25);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter27UI == true)
        //{
        //    Charter27UI(26);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter28UI == true)
        //{
        //    Charter28UI(27);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter29UI == true)
        //{
        //    Charter29UI(28);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else if (gameManager.charter30UI == true)
        //{
        //    Charter30UI(29);
        //    panel.gameObject.SetActive(true);
        //    tPCharter.C1();
        //}
        //else
        //{
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //}
    }

    //1
    public void Charter1_1UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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
        musicCharter.PlayMusic(0);
        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[0].AllAnim();
        }
        gameManager.SavePlayer();
    }
    public void Charter1UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[0].AllAnim();
        }
        gameManager.SavePlayer();
    }

    //2
    public void ButtonC2()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC2", 0.5f);
        Invoke("InvokerAchievements1", 6.5f);
    }
    public void InvokerC2()
    {
        Charter2UI(1);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements1()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter2UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            if (i == index)
            {
                animContent[i].AllAnim();
            }
        }
        sound.PlaySound(0);
    }

    //2_2
    public void ButtonC2_2()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("ActiveImg", 0.5f);
        Invoke("Bda", 6.0f);
        Invoke("InvokerC2_2", 6.5f);
        Invoke("InvokerAchievements1_2", 11.5f);
    }
    public void ActiveImg()
    {
        Img2.gameObject.SetActive(true);
        charter[0].SetActive(false);
        animContent[182].AllAnim_2();
    }
    public void Bda()
    {
        anim.Play("BlackoutDarkAnimation");
    }
    public void InvokerC2_2()
    {
        Charter2_2UI(1);
        Img2.gameObject.SetActive(false);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements1_2()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter2_2UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            if (i == index)
            {
                animContent[i].AllAnim();
            }
        }
        sound.PlaySound(0);
    }

    //3
    public void ButtonC3()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC3", 0.5f);
        Invoke("InvokerAchievements2", 6.5f);
    }
    public void InvokerC3()
    {
        Charter3UI(2);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements2()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter3UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Alcohol();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[2].AllAnim();
        }

        sound.PlaySound(1);
    }

    //4
    public void ButtonC4()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC4", 0.5f);
        Invoke("InvokerAchievements3", 6.5f);
    }
    public void InvokerC4()
    {
        Charter4UI(3);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements3()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter4UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = true;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[3].AllAnim();
        }
    }

    //5
    public void ButtonC5()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC5", 0.5f);
        Invoke("InvokerAchievements4", 1f);
    }
    public void InvokerC5()
    {
        Charter5UI(4);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements4()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter5UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = true;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[4].AllAnim();
        }
    }

    //6
    public void ButtonC6()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC6", 0.5f);
        Invoke("InvokerAchievements5", 1f);
    }
    public void InvokerC6()
    {
        Charter6UI(5);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements5()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter6UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = true;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

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

        logicValuesChapters.B_Ignore_It();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[5].AllAnim();
        }
    }

    //7
    public void ButtonC7()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC7", 0.5f);
        Invoke("InvokerAchievements6", 1f);
    }
    public void InvokerC7()
    {
        Charter7UI(6);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements6()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter7UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = true;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[6].AllAnim();
        }
    }

    //Проигрышь
    public void MenuCharter7UI()
    {
        sound.StopSound();
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            gameManager.charter[i] = 0;
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

        for (int i = 0; i < charter.Length; i++)
        {
            charter[i].SetActive(false);
        }
        panel.gameObject.SetActive(false);
        saveAndLoad.continueGame = 0;
        PlayerPrefs.SetInt("continueGame", saveAndLoad.continueGame);
        PlayerPrefs.Save();
        musicCharter.StopMusic();
        gameManager.ResetPlayer();
        activeMenu.BackMenu();
    }

    //8
    public void ButtonC8()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC8", 0.5f);
        Invoke("InvokerAchievements7", 1f);
    }
    public void InvokerC8()
    {
        Charter8UI(7);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements7()
    {
        imgBlackout.gameObject.SetActive(false);
        gameManager.SavePlayer();
    }
    public void Charter8UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = true;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[7].AllAnim();
        }
    }

    //9
    public void ButtonC9()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC9", 0.5f);
        Invoke("InvokerAchievements8", 1f);
    }
    public void InvokerC9()
    {
        Charter9UI(8);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements8()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter9UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = true;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[8].AllAnim();
        }
    }

    //10
    public void ButtonC10()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC10", 0.5f);
        Invoke("InvokerAchievements9", 1f);
    }
    public void InvokerC10()
    {
        Charter10UI(9);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements9()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter10UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = true;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[9].AllAnim();
        }
    }

    //11
    public void ButtonC11()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC11", 0.5f);
        Invoke("InvokerAchievements10", 1f);
    }
    public void InvokerC11()
    {
        Charter11UI(10);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements10()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter11UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = true;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

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

        logicValuesChapters.B_Any_Other_Flights();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[10].AllAnim();
        }
    }

    //12
    public void ButtonC12()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC12", 0.5f);
        Invoke("InvokerAchievements11", 1f);
    }
    public void InvokerC12()
    {
        Charter12UI(11);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements11()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter12UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = true;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

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

        logicValuesChapters.B_Visit_The_Cigar_Bar();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[11].AllAnim();
        }
    }

    //13
    public void ButtonC13()
    {
        //FireBaseAnalyticsEvents.EventsWinGame("WinGame");
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC13", 0.5f);
        Invoke("InvokerAchievements12", 1f);
    }
    public void InvokerC13()
    {
        Charter13UI(12);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements12()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter13UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = true;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

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

        if (gameManager.b_any_other_flights == 0)
        {
            buttonIf[0].gameObject.SetActive(true);
        }
        else if(gameManager.b_any_other_flights == 1)
        {
            buttonIf[0].gameObject.SetActive(false);
        }

            for (int i = 0; i < animContent.Length; i++)
        {
            animContent[12].AllAnim();
        }
    }

    //14
    public void ButtonC14()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC14", 0.5f);
        Invoke("InvokerAchievements13", 1f);
    }
    public void InvokerC14()
    {
        Charter14UI(13);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements13()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter14UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //toBeContinued.text = "To be continued...";


        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = true;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

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

        logicValuesChapters.B_Alcohol();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[13].AllAnim();
        }
    }

    //15
    public void ButtonC15()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC15", 0.5f);
        Invoke("InvokerAchievements14", 1f);
    }
    public void InvokerC15()
    {
        Charter15UI(14);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements14()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter15UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = true;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[14].AllAnim();
        }
    }

    //16
    public void ButtonC16()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC16", 0.5f);
        Invoke("InvokerAchievements15", 1f);
    }
    public void InvokerC16()
    {
        Charter16UI(15);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements15()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter16UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = true;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[15].AllAnim();
        }
    }

    //17
    public void ButtonC17()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC17", 0.5f);
        Invoke("InvokerAchievements16", 1f);
    }
    public void InvokerC17()
    {
        Charter17UI(16);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements16()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter17UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = true;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

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

        logicValuesChapters.B_Grab_Some_Food();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[16].AllAnim();
        }
    }

    //18
    public void ButtonC18()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC18", 0.5f);
        Invoke("InvokerAchievements17", 1f);
    }
    public void InvokerC18()
    {
        Charter18UI(17);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements17()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter18UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = true;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[17].AllAnim();
        }
    }

    //19
    public void ButtonC19()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC19", 0.5f);
        Invoke("InvokerAchievements18", 1f);
    }
    public void InvokerC19()
    {
        Charter19UI(18);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements18()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter19UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = true;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;
        //gameManager.charter31UI = false;
        //gameManager.charter32UI = false;
        //gameManager.charter33UI = false;
        //gameManager.charter34UI = false;
        //gameManager.charter35UI = false;
        //gameManager.charter36UI = false;
        //gameManager.charter37UI = false;
        //gameManager.charter38UI = false;
        //gameManager.charter39UI = false;
        //gameManager.charter40UI = false;
        //gameManager.charter41UI = false;
        //gameManager.charter42UI = false;
        //gameManager.charter43UI = false;
        //gameManager.charter44UI = false;
        //gameManager.charter45UI = false;
        //gameManager.charter46UI = false;
        //gameManager.charter47UI = false;
        //gameManager.charter48UI = false;
        //gameManager.charter49UI = false;
        //gameManager.charter50UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[18].AllAnim();
        }
    }

    //20
    public void ButtonC20()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC20", 0.5f);
        Invoke("InvokerAchievements19", 1f);
    }
    public void InvokerC20()
    {
        Charter20UI(19);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements19()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter20UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = true;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[19].AllAnim();
        }
    }

    //21
    public void ButtonC21()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC21", 0.5f);
        Invoke("InvokerAchievements20", 1f);
    }
    public void InvokerC21()
    {
        Charter21UI(20);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements20()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter21UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = true;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[20].AllAnim();
        }
    }

    //22
    public void ButtonC22()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC22", 0.5f);
        Invoke("InvokerAchievements21", 1f);
    }
    public void InvokerC22()
    {
        Charter22UI(21);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements21()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter22UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = true;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[21].AllAnim();
        }
    }

    //23
    public void ButtonC23()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC23", 0.5f);
        Invoke("InvokerAchievements22", 1f);
    }
    public void InvokerC23()
    {
        Charter23UI(22);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements22()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter23UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = true;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[22].AllAnim();
        }
    }

    //24
    public void ButtonC24()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC24", 0.5f);
        Invoke("InvokerAchievements23", 1f);
    }
    public void InvokerC24()
    {
        Charter24UI(23);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements23()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter24UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = true;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[23].AllAnim();
        }
    }

    //25
    public void ButtonC25()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC25", 0.5f);
        Invoke("InvokerAchievements24", 1f);
    }
    public void InvokerC25()
    {
        Charter25UI(24);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements24()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter25UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = true;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[24].AllAnim();
        }
    }

    //26
    public void ButtonC26()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC26", 0.5f);
        Invoke("InvokerAchievements25", 1f);
    }
    public void InvokerC26()
    {
        Charter26UI(25);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements25()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter26UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = true;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[25].AllAnim();
        }
    }

    //27
    public void ButtonC27()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC27", 0.5f);
        Invoke("InvokerAchievements26", 1f);
    }
    public void InvokerC27()
    {
        Charter27UI(26);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements26()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter27UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = true;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[26].AllAnim();
        }
    }

    //28
    public void ButtonC28()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC28", 0.5f);
        Invoke("InvokerAchievements27", 1f);
    }
    public void InvokerC28()
    {
        Charter28UI(27);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements27()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter28UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = true;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[27].AllAnim();
        }
    }

    //29
    public void ButtonC29()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC29", 0.5f);
        Invoke("InvokerAchievements28", 1f);
    }
    public void InvokerC29()
    {
        Charter29UI(28);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements28()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter29UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = true;
        //gameManager.charter30UI = false;

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[28].AllAnim();
        }
    }

    //30
    public void ButtonC30()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC30", 0.5f);
        Invoke("InvokerAchievements29", 1f);
    }
    public void InvokerC30()
    {
        Charter30UI(29);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements29()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter30UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[29].AllAnim();
        }
    }

    //31
    public void ButtonC31()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC31", 0.5f);
        Invoke("InvokerAchievements30", 1f);
    }
    public void InvokerC31()
    {
        Charter31UI(30);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements30()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter31UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[30].AllAnim();
        }
    }

    //32
    public void ButtonC32()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC32", 0.5f);
        Invoke("InvokerAchievements31", 1f);
    }
    public void InvokerC32()
    {
        Charter32UI(31);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements31()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter32UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[31].AllAnim();
        }
    }

    //33
    public void ButtonC33()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC33", 0.5f);
        Invoke("InvokerAchievements32", 1f);
    }
    public void InvokerC33()
    {
        Charter33UI(32);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements32()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter33UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[32].AllAnim();
        }
    }

    //34
    public void ButtonC34()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC34", 0.5f);
        Invoke("InvokerAchievements33", 1f);
    }
    public void InvokerC34()
    {
        Charter34UI(33);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements33()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter34UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[33].AllAnim();
        }
    }

    //35
    public void ButtonC35()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC35", 0.5f);
        Invoke("InvokerAchievements34", 1f);
    }
    public void InvokerC35()
    {
        Charter35UI(34);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements34()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter35UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Ask_About_Her_Toys();

        if (gameManager.b_make_conversation == 0)
        {
            buttonIf[1].gameObject.SetActive(true);
        }
        else if (gameManager.b_make_conversation == 1)
        {
            buttonIf[1].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[34].AllAnim();
        }
    }

    //36
    public void ButtonC36()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC36", 0.5f);
        Invoke("InvokerAchievements35", 1f);
    }
    public void InvokerC36()
    {
        Charter36UI(35);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements35()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter36UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Make_Conversation();

        if (gameManager.b_ask_about_her_toys == 0)
        {
            buttonIf[2].gameObject.SetActive(true);
        }
        else if (gameManager.b_ask_about_her_toys == 1)
        {
            buttonIf[2].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[35].AllAnim();
        }
    }

    //37
    public void ButtonC37()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC37", 0.5f);
        Invoke("InvokerAchievements36", 1f);
    }
    public void InvokerC37()
    {
        Charter37UI(36);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements36()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter37UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Try_To_Find_Her_Parents();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[36].AllAnim();
        }
    }

    //38
    public void ButtonC38()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC38", 0.5f);
        Invoke("InvokerAchievements37", 1f);
    }
    public void InvokerC38()
    {
        Charter38UI(37);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements37()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter38UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[37].AllAnim();
        }
    }

    //39
    public void ButtonC39()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC39", 0.5f);
        Invoke("InvokerAchievements38", 1f);
    }
    public void InvokerC39()
    {
        Charter39UI(38);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements38()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements1();
    }
    public void Charter39UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_We_Were_Looking();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[38].AllAnim();
        }
    }

    //40
    public void ButtonC40()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC40", 0.5f);
        Invoke("InvokerAchievements39", 1f);
    }
    public void InvokerC40()
    {
        Charter40UI(39);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements39()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter40UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[39].AllAnim();
        }
    }

    //41
    public void ButtonC41()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC41", 0.5f);
        Invoke("InvokerAchievements40", 1f);
    }
    public void InvokerC41()
    {
        Charter41UI(40);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements40()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter41UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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


        logicValuesChapters.B_Take_The_Girl_To_An_Officer();
        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[40].AllAnim();
        }
    }

    //42
    public void ButtonC42()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC42", 0.5f);
        Invoke("InvokerAchievements41", 1f);
    }
    public void InvokerC42()
    {
        Charter42UI(41);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements41()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter42UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[41].AllAnim();
        }
    }

    //43
    public void ButtonC43()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC43", 0.5f);
        Invoke("InvokerAchievements42", 1f);
    }
    public void InvokerC43()
    {
        Charter43UI(42);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements42()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter43UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        if (gameManager.b_ask_about_her_toys == 1 && gameManager.b_make_conversation == 1)
        {
            buttonIf[3].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[3].gameObject.SetActive(false);
        }

        if (gameManager.b_ask_about_her_toys == 0 || gameManager.b_make_conversation == 0)
        {
            buttonIf[4].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[4].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[42].AllAnim();
        }
    }

    //44
    public void ButtonC44()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC44", 0.5f);
        Invoke("InvokerAchievements43", 1f);
    }
    public void InvokerC44()
    {
        Charter44UI(43);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements43()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements2();
    }
    public void Charter44UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[43].AllAnim();
        }
    }

    //45
    public void ButtonC45()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC45", 0.5f);
        Invoke("InvokerAchievements44", 1f);
    }
    public void InvokerC45()
    {
        Charter45UI(44);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements44()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter45UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        if (gameManager.b_grab_some_food == 0)
        {
            buttonIf[5].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[5].gameObject.SetActive(false);
        }

        if (gameManager.b_grab_some_food == 1)
        {
            buttonIf[6].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[6].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[44].AllAnim();
        }
    }

    //46
    public void ButtonC46()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC46", 0.5f);
        Invoke("InvokerAchievements45", 1f);
    }
    public void InvokerC46()
    {
        Charter46UI(45);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements45()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter46UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Go_To_The_Bookstore();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[45].AllAnim();
        }
    }

    //47
    public void ButtonC47()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC47", 0.5f);
        Invoke("InvokerAchievements46", 1f);
    }
    public void InvokerC47()
    {
        Charter47UI(46);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements46()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter47UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Buy_Book();



        if (gameManager.b_talk_with_a_stranger == 0)
        {
            buttonIf[7].gameObject.SetActive(true);
        }
        else if (gameManager.b_talk_with_a_stranger == 1)
        {
            buttonIf[7].gameObject.SetActive(false);
        }


        if (gameManager.b_grab_some_food == 0)
        {
            buttonIf[8].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[8].gameObject.SetActive(false);
        }

        if (gameManager.b_grab_some_food == 1)
        {
            buttonIf[9].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[9].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[46].AllAnim();
        }
    }

    //48
    public void ButtonC48()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC48", 0.5f);
        Invoke("InvokerAchievements47", 1f);
    }
    public void InvokerC48()
    {
        Charter48UI(47);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements47()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter48UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        if (gameManager.b_talk_with_a_stranger == 0)
        {
            buttonIf[10].gameObject.SetActive(true);
        }
        else if (gameManager.b_talk_with_a_stranger == 1)
        {
            buttonIf[10].gameObject.SetActive(false);
        }

        if (gameManager.b_grab_some_food == 0)
        {
            buttonIf[11].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[11].gameObject.SetActive(false);
        }

        if (gameManager.b_grab_some_food == 1)
        {
            buttonIf[12].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[12].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[47].AllAnim();
        }
    }

    //49
    public void ButtonC49()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC49", 0.5f);
        Invoke("InvokerAchievements48", 1f);
    }
    public void InvokerC49()
    {
        Charter49UI(48);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements48()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter49UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Talk_With_A_Stranger();

        if (gameManager.b_grab_some_food == 0)
        {
            buttonIf[13].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[13].gameObject.SetActive(false);
        }

        if (gameManager.b_grab_some_food == 1)
        {
            buttonIf[14].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[14].gameObject.SetActive(false);
        }

        if (gameManager.b_go_to_the_bookstore == 0)
        {
            buttonIf[15].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[15].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[48].AllAnim();
        }
    }

    //50
    public void ButtonC50()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC50", 0.5f);
        Invoke("InvokerAchievements49", 1f);
    }
    public void InvokerC50()
    {
        Charter50UI(49);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements49()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter50UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[49].AllAnim();
        }
    }

    //51
    public void ButtonC51()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC51", 0.5f);
        Invoke("InvokerAchievements50", 1f);
    }
    public void InvokerC51()
    {
        Charter51UI(50);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements50()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter51UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[50].AllAnim();
        }
    }

    //52
    public void ButtonC52()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC52", 0.5f);
        Invoke("InvokerAchievements51", 1f);
    }
    public void InvokerC52()
    {
        Charter52UI(51);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements51()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter52UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[51].AllAnim();
        }
    }

    //53
    public void ButtonC53()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC53", 0.5f);
        Invoke("InvokerAchievements52", 1f);
    }
    public void InvokerC53()
    {
        Charter53UI(52);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements52()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter53UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[52].AllAnim();
        }
    }

    //54
    public void ButtonC54()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC54", 0.5f);
        Invoke("InvokerAchievements53", 1f);
    }
    public void InvokerC54()
    {
        Charter54UI(53);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements53()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter54UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[53].AllAnim();
        }
    }

    //55
    public void ButtonC55()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC55", 0.5f);
        Invoke("InvokerAchievements54", 1f);
    }
    public void InvokerC55()
    {
        Charter55UI(54);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements54()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter55UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[54].AllAnim();
        }
    }

    //56
    public void ButtonC56()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC56", 0.5f);
        Invoke("InvokerAchievements55", 1f);
    }
    public void InvokerC56()
    {
        Charter56UI(55);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements55()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter56UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[55].AllAnim();
        }
    }

    //57
    public void ButtonC57()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC57", 0.5f);
        Invoke("InvokerAchievements56", 1f);
    }
    public void InvokerC57()
    {
        Charter57UI(56);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements56()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter57UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[56].AllAnim();
        }
    }

    //58
    public void ButtonC58()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC58", 0.5f);
        Invoke("InvokerAchievements57", 1f);
    }
    public void InvokerC58()
    {
        Charter58UI(57);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements57()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter58UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[57].AllAnim();
        }
    }

    //59
    public void ButtonC59()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC59", 0.5f);
        Invoke("InvokerAchievements58", 1f);
    }
    public void InvokerC59()
    {
        Charter59UI(58);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements58()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter59UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[58].AllAnim();
        }
    }

    //60
    public void ButtonC60()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC60", 0.5f);
        Invoke("InvokerAchievements59", 1f);
    }
    public void InvokerC60()
    {
        Charter60UI(59);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements59()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter60UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[59].AllAnim();
        }
    }

    //61
    public void ButtonC61()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC61", 0.5f);
        Invoke("InvokerAchievements60", 1f);
    }
    public void InvokerC61()
    {
        Charter61UI(60);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements60()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter61UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[60].AllAnim();
        }
    }

    //62
    public void ButtonC62()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC62", 0.5f);
        Invoke("InvokerAchievements61", 1f);
    }
    public void InvokerC62()
    {
        Charter62UI(61);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements61()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter62UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[61].AllAnim();
        }
    }

    //63
    public void ButtonC63()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC63", 0.5f);
        Invoke("InvokerAchievements62", 1f);
    }
    public void InvokerC63()
    {
        Charter63UI(62);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements62()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter63UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[62].AllAnim();
        }
    }

    //64
    public void ButtonC64()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC64", 0.5f);
        Invoke("InvokerAchievements63", 1f);
    }
    public void InvokerC64()
    {
        Charter64UI(63);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements63()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter64UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[63].AllAnim();
        }
    }

    //65
    public void ButtonC65()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC65", 0.5f);
        Invoke("InvokerAchievements64", 1f);
    }
    public void InvokerC65()
    {
        Charter65UI(64);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements64()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements3();
    }
    public void Charter65UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        if (gameManager.b_buy_book == 0)
        {
            buttonIf[16].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[16].gameObject.SetActive(false);
        }

        if (gameManager.b_buy_book == 1)
        {
            buttonIf[17].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[17].gameObject.SetActive(false);
        }

        if (gameManager.b_we_were_looking == 1)
        {
            buttonIf[18].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[18].gameObject.SetActive(false);
        }

        if (gameManager.b_take_the_girl_to_an_officer == 1)
        {
            buttonIf[19].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[19].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[64].AllAnim();
        }
    }

    //66
    public void ButtonC66()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC66", 0.5f);
        Invoke("InvokerAchievements65", 1f);
    }
    public void InvokerC66()
    {
        Charter66UI(65);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements65()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter66UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[65].AllAnim();
        }
    }

    //67
    public void ButtonC67()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC67", 0.5f);
        Invoke("InvokerAchievements66", 1f);
    }
    public void InvokerC67()
    {
        Charter67UI(66);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements66()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter67UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[66].AllAnim();
        }
    }

    //68
    public void ButtonC68()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC68", 0.5f);
        Invoke("InvokerAchievements67", 1f);
    }
    public void InvokerC68()
    {
        Charter68UI(67);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements67()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements4();
    }
    public void Charter68UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Alcohol();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[67].AllAnim();
        }
    }

    //69
    public void ButtonC69()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC69", 0.5f);
        Invoke("InvokerAchievements68", 1f);
    }
    public void InvokerC69()
    {
        Charter69UI(68);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements68()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements5();
    }
    public void Charter69UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[68].AllAnim();
        }
    }

    //70
    public void ButtonC70()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC70", 0.5f);
        Invoke("InvokerAchievements69", 1f);
    }
    public void InvokerC70()
    {
        Charter70UI(69);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements69()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter70UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[69].AllAnim();
        }
    }

    //71
    public void ButtonC71()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC71", 0.5f);
        Invoke("InvokerAchievements70", 1f);
    }
    public void InvokerC71()
    {
        Charter71UI(70);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements70()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter71UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        if (gameManager.b_alcohol == 0)
        {
            buttonIf[20].gameObject.SetActive(true);
            buttonIf[21].gameObject.SetActive(true);
            buttonIf[22].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[20].gameObject.SetActive(false);
            buttonIf[21].gameObject.SetActive(false);
            buttonIf[22].gameObject.SetActive(false);
        }

        if (gameManager.b_alcohol > 0)
        {
            buttonIf[23].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[23].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[70].AllAnim();
        }
    }

    //72
    public void ButtonC72()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC72", 0.5f);
        Invoke("InvokerAchievements71", 1f);
    }
    public void InvokerC72()
    {
        Charter72UI(71);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements71()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements6();
    }
    public void Charter72UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Ignore_It();
        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[71].AllAnim();
        }
    }

    //73
    public void ButtonC73()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC73", 0.5f);
        Invoke("InvokerAchievements72", 1f);
    }
    public void InvokerC73()
    {
        Charter73UI(72);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements72()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter73UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[72].AllAnim();
        }
    }

    //74
    public void ButtonC74()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC74", 0.5f);
        Invoke("InvokerAchievements73", 1f);
    }
    public void InvokerC74()
    {
        Charter74UI(73);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements73()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter74UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Too_Much_Of_A_Risk();
        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[73].AllAnim();
        }
    }

    //75
    public void ButtonC75()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC75", 0.5f);
        Invoke("InvokerAchievements74", 1f);
    }
    public void InvokerC75()
    {
        Charter75UI(74);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements74()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter75UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Give_Me_Some_Time();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[74].AllAnim();
        }
    }

    //76
    public void ButtonC76()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC76", 0.5f);
        Invoke("InvokerAchievements75", 1f);
    }
    public void InvokerC76()
    {
        Charter76UI(75);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements75()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter76UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[75].AllAnim();
        }
    }

    //77
    public void ButtonC77()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC77", 0.5f);
        Invoke("InvokerAchievements76", 1f);
    }
    public void InvokerC77()
    {
        Charter77UI(76);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements76()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter77UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[76].AllAnim();
        }
    }

    //78
    public void ButtonC78()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC78", 0.5f);
        Invoke("InvokerAchievements77", 1f);
    }
    public void InvokerC78()
    {
        Charter78UI(77);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements77()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter78UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[77].AllAnim();
        }
    }

    //79
    public void ButtonC79()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC79", 0.5f);
        Invoke("InvokerAchievements78", 1f);
    }
    public void InvokerC79()
    {
        Charter79UI(78);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements78()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter79UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Nevermind();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[78].AllAnim();
        }
    }

    //80
    public void ButtonC80()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC80", 0.5f);
        Invoke("InvokerAchievements79", 1f);
    }
    public void InvokerC80()
    {
        Charter80UI(79);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements79()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter80UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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


        if (gameManager.b_too_much_of_a_risk == 0 && gameManager.b_nevermind == 0 && gameManager.b_alcohol == 0 && gameManager.b_ignore_it_2 == 0)
        {
            buttonIf[24].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[24].gameObject.SetActive(false);
        } 
        
        if (gameManager.b_give_me_some_time == 1 && gameManager.b_check_the_weather == 0 && gameManager.b_alcohol == 0 && gameManager.b_ignore_it_2 == 0)
        {
            buttonIf[25].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[25].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[79].AllAnim();
        }
    }

    //81
    public void ButtonC81()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC81", 0.5f);
        Invoke("InvokerAchievements80", 1f);
    }
    public void InvokerC81()
    {
        Charter81UI(80);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements80()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter81UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[80].AllAnim();
        }
    }

    //82
    public void ButtonC82()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC82", 0.5f);
        Invoke("InvokerAchievements81", 1f);
    }
    public void InvokerC82()
    {
        Charter82UI(81);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements81()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements7();
    }
    public void Charter82UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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
        logicValuesChapters.B_Check_The_Weather();
        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[81].AllAnim();
        }
    }

    //83
    public void ButtonC83()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC83", 0.5f);
        Invoke("InvokerAchievements82", 1f);
    }
    public void InvokerC83()
    {
        Charter83UI(82);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements82()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter83UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[82].AllAnim();
        }
    }

    //84
    public void ButtonC84()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC84", 0.5f);
        Invoke("InvokerAchievements83", 1f);
    }
    public void InvokerC84()
    {
        Charter84UI(83);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements83()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter84UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_The_Lounge();

        if (gameManager.b_the_food_court == 0)
        {
            buttonIf[26].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[26].gameObject.SetActive(false);
        }

        if (gameManager.b_halls == 0)
        {
            buttonIf[27].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[27].gameObject.SetActive(false);
        }

        if (gameManager.b_gates == 0)
        {
            buttonIf[28].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[28].gameObject.SetActive(false);
        }

        if (gameManager.b_gates == 1 && gameManager.b_halls == 1 && gameManager.b_the_food_court == 1 && gameManager.b_the_lounge == 1)
        {
            buttonIf[29].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[29].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[83].AllAnim();
        }
    }

    //85
    public void ButtonC85()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC85", 0.5f);
        Invoke("InvokerAchievements84", 1f);
    }
    public void InvokerC85()
    {
        Charter85UI(84);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements84()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter85UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_The_Food_Court();

        if (gameManager.b_the_lounge == 0)
        {
            buttonIf[30].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[30].gameObject.SetActive(false);
        }

        if (gameManager.b_halls == 0)
        {
            buttonIf[31].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[31].gameObject.SetActive(false);
        }

        if (gameManager.b_gates == 0)
        {
            buttonIf[32].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[32].gameObject.SetActive(false);
        }

        if (gameManager.b_gates == 1 && gameManager.b_halls == 1 && gameManager.b_the_food_court == 1 && gameManager.b_the_lounge == 1)
        {
            buttonIf[33].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[33].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[84].AllAnim();
        }
    }

    //86
    public void ButtonC86()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC86", 0.5f);
        Invoke("InvokerAchievements85", 1f);
    }
    public void InvokerC86()
    {
        Charter86UI(85);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements85()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter86UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Halls();

        if (gameManager.b_the_lounge == 0)
        {
            buttonIf[34].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[34].gameObject.SetActive(false);
        }

        if (gameManager.b_the_food_court == 0)
        {
            buttonIf[35].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[35].gameObject.SetActive(false);
        }

        if (gameManager.b_gates == 0)
        {
            buttonIf[36].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[36].gameObject.SetActive(false);
        }

        if (gameManager.b_gates == 1 && gameManager.b_halls == 1 && gameManager.b_the_food_court == 1 && gameManager.b_the_lounge == 1)
        {
            buttonIf[37].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[37].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[85].AllAnim();
        }
    }

    //87
    public void ButtonC87()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC87", 0.5f);
        Invoke("InvokerAchievements86", 1f);
    }
    public void InvokerC87()
    {
        Charter87UI(86);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements86()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter87UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Gates();

        if (gameManager.b_the_lounge == 0)
        {
            buttonIf[38].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[38].gameObject.SetActive(false);
        }

        if (gameManager.b_the_food_court == 0)
        {
            buttonIf[39].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[39].gameObject.SetActive(false);
        }

        if (gameManager.b_halls == 0)
        {
            buttonIf[40].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[40].gameObject.SetActive(false);
        }

        if (gameManager.b_gates == 1 && gameManager.b_halls == 1 && gameManager.b_the_food_court == 1 && gameManager.b_the_lounge == 1)
        {
            buttonIf[41].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[41].gameObject.SetActive(false);
        }
        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[86].AllAnim();
        }
    }

    //88
    public void ButtonC88()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC88", 0.5f);
        Invoke("InvokerAchievements87", 1f);
    }
    public void InvokerC88()
    {
        Charter88UI(87);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements87()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter88UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[87].AllAnim();
        }
    }

    //89
    public void ButtonC89()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC89", 0.5f);
        Invoke("InvokerAchievements88", 1f);
    }
    public void InvokerC89()
    {
        Charter89UI(88);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements88()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter89UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        if (gameManager.b_buy_book == 0)
        {
            buttonIf[42].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[42].gameObject.SetActive(false);
        }

        if (gameManager.b_buy_book == 1)
        {
            buttonIf[43].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[43].gameObject.SetActive(false);
        }

        if (gameManager.b_we_were_looking == 1)
        {
            buttonIf[44].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[44].gameObject.SetActive(false);
        }

        if (gameManager.b_take_the_girl_to_an_officer == 1)
        {
            buttonIf[45].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[45].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[88].AllAnim();
        }
    }

    //90
    public void ButtonC90()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC90", 0.5f);
        Invoke("InvokerAchievements89", 1f);
    }
    public void InvokerC90()
    {
        Charter90UI(89);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements89()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter90UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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


        if (gameManager.b_buy_book == 0)
        {
            buttonIf[46].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[46].gameObject.SetActive(false);
        }

        if (gameManager.b_buy_book == 1)
        {
            buttonIf[47].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[47].gameObject.SetActive(false);
        }

        if (gameManager.b_we_were_looking == 1)
        {
            buttonIf[48].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[48].gameObject.SetActive(false);
        }

        if (gameManager.b_take_the_girl_to_an_officer == 1)
        {
            buttonIf[49].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[49].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[89].AllAnim();
        }
    }

    //91
    public void ButtonC91()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC91", 0.5f);
        Invoke("InvokerAchievements90", 1f);
    }
    public void InvokerC91()
    {
        Charter91UI(90);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements90()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements8();
    }
    public void Charter91UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[90].AllAnim();
        }
    }

    //92
    public void ButtonC92()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC92", 0.5f);
        Invoke("InvokerAchievements91", 1f);
    }
    public void InvokerC92()
    {
        Charter92UI(91);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements91()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter92UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[91].AllAnim();
        }
    }

    //93
    public void ButtonC93()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC93", 0.5f);
        Invoke("InvokerAchievements92", 1f);
    }
    public void InvokerC93()
    {
        Charter93UI(92);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements92()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements9();
    }
    public void Charter93UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[92].AllAnim();
        }
    }

    //94
    public void ButtonC94()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC94", 0.5f);
        Invoke("InvokerAchievements93", 1f);
    }
    public void InvokerC94()
    {
        Charter94UI(93);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements93()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter94UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[93].AllAnim();
        }
    }

    //95
    public void ButtonC95()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC95", 0.5f);
        Invoke("InvokerAchievements94", 1f);
    }
    public void InvokerC95()
    {
        Charter95UI(94);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements94()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter95UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[94].AllAnim();
        }
    }

    //96
    public void ButtonC96()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC96", 0.5f);
        Invoke("InvokerAchievements95", 1f);
    }
    public void InvokerC96()
    {
        Charter96UI(95);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements95()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter96UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[95].AllAnim();
        }
    }

    //97
    public void ButtonC97()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC97", 0.5f);
        Invoke("InvokerAchievements96", 1f);
    }
    public void InvokerC97()
    {
        Charter97UI(96);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements96()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter97UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[96].AllAnim();
        }
    }

    //98
    public void ButtonC98()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC98", 0.5f);
        Invoke("InvokerAchievements97", 1f);
    }
    public void InvokerC98()
    {
        Charter98UI(97);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements97()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements10();
    }
    public void Charter98UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[97].AllAnim();
        }
    }

    //99
    public void ButtonC99()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC99", 0.5f);
        Invoke("InvokerAchievements98", 1f);
    }
    public void InvokerC99()
    {
        Charter99UI(98);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements98()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter99UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[98].AllAnim();
        }
    }

    //100
    public void ButtonC100()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC100", 0.5f);
        Invoke("InvokerAchievements99", 1f);
    }
    public void InvokerC100()
    {
        Charter100UI(99);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements99()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter100UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[99].AllAnim();
        }
    }

    //101
    public void ButtonC101()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC101", 0.5f);
        Invoke("InvokerAchievements100", 1f);
    }
    public void InvokerC101()
    {
        Charter101UI(100);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements100()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter101UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[100].AllAnim();
        }
    }

    //102
    public void ButtonC102()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC102", 0.5f);
        Invoke("InvokerAchievements101", 1f);
    }
    public void InvokerC102()
    {
        Charter102UI(101);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements101()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter102UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[101].AllAnim();
        }
    }

    //103
    public void ButtonC103()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC103", 0.5f);
        Invoke("InvokerAchievements102", 1f);
    }
    public void InvokerC103()
    {
        Charter103UI(102);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements102()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter103UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[102].AllAnim();
        }
    }

    //104
    public void ButtonC104()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC104", 0.5f);
        Invoke("InvokerAchievements103", 1f);
    }
    public void InvokerC104()
    {
        Charter104UI(103);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements103()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter104UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[103].AllAnim();
        }
    }

    //105
    public void ButtonC105()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC105", 0.5f);
        Invoke("InvokerAchievements104", 1f);
    }
    public void InvokerC105()
    {
        Charter105UI(104);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements104()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter105UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[104].AllAnim();
        }
    }

    //106
    public void ButtonC106()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC106", 0.5f);
        Invoke("InvokerAchievements105", 1f);
    }
    public void InvokerC106()
    {
        Charter106UI(105);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements105()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter106UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[105].AllAnim();
        }
    }

    //107
    public void ButtonC107()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC107", 0.5f);
        Invoke("InvokerAchievements106", 1f);
    }
    public void InvokerC107()
    {
        Charter107UI(106);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements106()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter107UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[106].AllAnim();
        }
    }

    //108
    public void ButtonC108()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC108", 0.5f);
        Invoke("InvokerAchievements107", 1f);
    }
    public void InvokerC108()
    {
        Charter108UI(107);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements107()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter108UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[107].AllAnim();
        }
    }

    //109
    public void ButtonC109()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC109", 0.5f);
        Invoke("InvokerAchievements108", 1f);
    }
    public void InvokerC109()
    {
        Charter109UI(108);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements108()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter109UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[108].AllAnim();
        }
    }

    //110
    public void ButtonC110()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC110", 0.5f);
        Invoke("InvokerAchievements109", 1f);
    }
    public void InvokerC110()
    {
        Charter110UI(109);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements109()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter110UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[109].AllAnim();
        }
    }

    //111
    public void ButtonC111()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC111", 0.5f);
        Invoke("InvokerAchievements110", 1f);
    }
    public void InvokerC111()
    {
        Charter111UI(110);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements110()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter111UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[110].AllAnim();
        }
    }

    //112
    public void ButtonC112()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC112", 0.5f);
        Invoke("InvokerAchievements111", 1f);
    }
    public void InvokerC112()
    {
        Charter112UI(111);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements111()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter112UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[111].AllAnim();
        }
    }

    //113
    public void ButtonC113()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC113", 0.5f);
        Invoke("InvokerAchievements112", 1f);
    }
    public void InvokerC113()
    {
        Charter113UI(112);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements112()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter113UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[112].AllAnim();
        }
    }

    //114
    public void ButtonC114()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC114", 0.5f);
        Invoke("InvokerAchievements113", 1f);
    }
    public void InvokerC114()
    {
        Charter114UI(113);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements113()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter114UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[113].AllAnim();
        }
    }

    //115
    public void ButtonC115()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC115", 0.5f);
        Invoke("InvokerAchievements114", 1f);
    }
    public void InvokerC115()
    {
        Charter115UI(114);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements114()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter115UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[114].AllAnim();
        }
    }

    //116
    public void ButtonC116()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC116", 0.5f);
        Invoke("InvokerAchievements115", 1f);
    }
    public void InvokerC116()
    {
        Charter116UI(115);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements115()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter116UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[115].AllAnim();
        }
    }

    //117
    public void ButtonC117()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC117", 0.5f);
        Invoke("InvokerAchievements116", 1f);
    }
    public void InvokerC117()
    {
        Charter117UI(116);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements116()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter117UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[116].AllAnim();
        }
    }

    //118
    public void ButtonC118()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC118", 0.5f);
        Invoke("InvokerAchievements117", 1f);
    }
    public void InvokerC118()
    {
        Charter118UI(117);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements117()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter118UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[117].AllAnim();
        }
    }

    //119
    public void ButtonC119()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC119", 0.5f);
        Invoke("InvokerAchievements118", 1f);
    }
    public void InvokerC119()
    {
        Charter119UI(118);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements118()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter119UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[118].AllAnim();
        }
    }

    //120
    public void ButtonC120()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC120", 0.5f);
        Invoke("InvokerAchievements119", 1f);
    }
    public void InvokerC120()
    {
        Charter120UI(119);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements119()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter120UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[119].AllAnim();
        }
    }

    //121
    public void ButtonC121()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC121", 0.5f);
        Invoke("InvokerAchievements120", 1f);
    }
    public void InvokerC121()
    {
        Charter121UI(120);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements120()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter121UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[120].AllAnim();
        }
    }

    //122
    public void ButtonC122()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC122", 0.5f);
        Invoke("InvokerAchievements121", 1f);
    }
    public void InvokerC122()
    {
        Charter122UI(121);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements121()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter122UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[121].AllAnim();
        }
    }

    //123
    public void ButtonC123()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC123", 0.5f);
        Invoke("InvokerAchievements122", 1f);
    }
    public void InvokerC123()
    {
        Charter123UI(122);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements122()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter123UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[122].AllAnim();
        }
    }

    //124
    public void ButtonC124()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC124", 0.5f);
        Invoke("InvokerAchievements123", 1f);
    }
    public void InvokerC124()
    {
        Charter124UI(123);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements123()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements11();
    }
    public void Charter124UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[123].AllAnim();
        }
    }

    //125
    public void ButtonC125()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC125", 0.5f);
        Invoke("InvokerAchievements124", 1f);
    }
    public void InvokerC125()
    {
        Charter125UI(124);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements124()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter125UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[124].AllAnim();
        }
    }

    //126
    public void ButtonC126()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC126", 0.5f);
        Invoke("InvokerAchievements125", 1f);
    }
    public void InvokerC126()
    {
        Charter126UI(125);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements125()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements12();
    }
    public void Charter126UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[125].AllAnim();
        }
    }

    //127
    public void ButtonC127()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC127", 0.5f);
        Invoke("InvokerAchievements126", 1f);
    }
    public void InvokerC127()
    {
        Charter127UI(126);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements126()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter127UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[126].AllAnim();
        }
    }

    //128
    public void ButtonC128()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC128", 0.5f);
        Invoke("InvokerAchievements127", 1f);
    }
    public void InvokerC128()
    {
        Charter128UI(127);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements127()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter128UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[127].AllAnim();
        }
    }

    //129
    public void ButtonC129()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC129", 0.5f);
        Invoke("InvokerAchievements128", 1f);
    }
    public void InvokerC129()
    {
        Charter129UI(128);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements128()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter129UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[128].AllAnim();
        }
    }

    //130
    public void ButtonC130()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC130", 0.5f);
        Invoke("InvokerAchievements129", 1f);
    }
    public void InvokerC130()
    {
        Charter130UI(129);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements129()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter130UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[129].AllAnim();
        }
    }

    //131
    public void ButtonC131()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC131", 0.5f);
        Invoke("InvokerAchievements130", 1f);
    }
    public void InvokerC131()
    {
        Charter131UI(130);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements130()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter131UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Fight();

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[130].AllAnim();
        }
    }

    //132
    public void ButtonC132()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC132", 0.5f);
        Invoke("InvokerAchievements131", 1f);
    }
    public void InvokerC132()
    {
        Charter132UI(131);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements131()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements13();
    }
    public void Charter132UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[131].AllAnim();
        }
    }

    //133
    public void ButtonC133()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC133", 0.5f);
        Invoke("InvokerAchievements132", 1f);
    }
    public void InvokerC133()
    {
        Charter133UI(132);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements132()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter133UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[132].AllAnim();
        }
    }

    //134
    public void ButtonC134()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC134", 0.5f);
        Invoke("InvokerAchievements133", 1f);
    }
    public void InvokerC134()
    {
        Charter134UI(133);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements133()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter134UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[133].AllAnim();
        }
    }

    //135
    public void ButtonC135()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC135", 0.5f);
        Invoke("InvokerAchievements134", 1f);
    }
    public void InvokerC135()
    {
        Charter135UI(134);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements134()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter135UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[134].AllAnim();
        }
    }

    //136
    public void ButtonC136()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC136", 0.5f);
        Invoke("InvokerAchievements135", 1f);
    }
    public void InvokerC136()
    {
        Charter136UI(135);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements135()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter136UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[135].AllAnim();
        }
    }

    //137
    public void ButtonC137()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC137", 0.5f);
        Invoke("InvokerAchievements136", 1f);
    }
    public void InvokerC137()
    {
        Charter137UI(136);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements136()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter137UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[136].AllAnim();
        }
    }

    //138
    public void ButtonC138()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC138", 0.5f);
        Invoke("InvokerAchievements137", 1f);
    }
    public void InvokerC138()
    {
        Charter138UI(137);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements137()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter138UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[137].AllAnim();
        }
    }

    //139
    public void ButtonC139()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC139", 0.5f);
        Invoke("InvokerAchievements138", 1f);
    }
    public void InvokerC139()
    {
        Charter139UI(138);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements138()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter139UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[138].AllAnim();
        }
    }

    //140
    public void ButtonC140()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC140", 0.5f);
        Invoke("InvokerAchievements139", 1f);
    }
    public void InvokerC140()
    {
        Charter140UI(139);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements139()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter140UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[139].AllAnim();
        }
    }

    //141
    public void ButtonC141()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC141", 0.5f);
        Invoke("InvokerAchievements140", 1f);
    }
    public void InvokerC141()
    {
        Charter141UI(140);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements140()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter141UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[140].AllAnim();
        }
    }

    //142
    public void ButtonC142()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC142", 0.5f);
        Invoke("InvokerAchievements141", 1f);
    }
    public void InvokerC142()
    {
        Charter142UI(141);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements141()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter142UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[141].AllAnim();
        }
    }

    //143
    public void ButtonC143()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC143", 0.5f);
        Invoke("InvokerAchievements142", 1f);
    }
    public void InvokerC143()
    {
        Charter143UI(142);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements142()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter143UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[142].AllAnim();
        }
    }

    //144
    public void ButtonC144()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC144", 0.5f);
        Invoke("InvokerAchievements143", 1f);
    }
    public void InvokerC144()
    {
        Charter144UI(143);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements143()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter144UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[143].AllAnim();
        }
    }

    //145
    public void ButtonC145()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC145", 0.5f);
        Invoke("InvokerAchievements144", 1f);
    }
    public void InvokerC145()
    {
        Charter145UI(144);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements144()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter145UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Looking_Around();

        if (gameManager.b_check_for_survivors == 0)
        {
            buttonIf[50].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[50].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[144].AllAnim();
        }
    }

    //146
    public void ButtonC146()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC146", 0.5f);
        Invoke("InvokerAchievements145", 1f);
    }
    public void InvokerC146()
    {
        Charter146UI(145);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements145()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter146UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Check_For_Survivors();

        if (gameManager.b_looking_around == 0)
        {
            buttonIf[51].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[51].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[145].AllAnim();
        }
    }

    //147
    public void ButtonC147()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC147", 0.5f);
        Invoke("InvokerAchievements146", 1f);
    }
    public void InvokerC147()
    {
        Charter147UI(146);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements146()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter147UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[146].AllAnim();
        }
    }

    //148
    public void ButtonC148()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC148", 0.5f);
        Invoke("InvokerAchievements147", 1f);
    }
    public void InvokerC148()
    {
        Charter148UI(147);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements147()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter148UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[147].AllAnim();
        }
    }

    //149
    public void ButtonC149()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC149", 0.5f);
        Invoke("InvokerAchievements148", 1f);
    }
    public void InvokerC149()
    {
        Charter149UI(148);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements148()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter149UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[148].AllAnim();
        }
    }

    //150
    public void ButtonC150()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC150", 0.5f);
        Invoke("InvokerAchievements149", 1f);
    }
    public void InvokerC150()
    {
        Charter150UI(149);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements149()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter150UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[149].AllAnim();
        }
    }

    //151
    public void ButtonC151()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC151", 0.5f);
        Invoke("InvokerAchievements150", 1f);
    }
    public void InvokerC151()
    {
        Charter151UI(150);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements150()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter151UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[150].AllAnim();
        }
    }

    //152
    public void ButtonC152()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC152", 0.5f);
        Invoke("InvokerAchievements151", 1f);
    }
    public void InvokerC152()
    {
        Charter152UI(151);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements151()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter152UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[151].AllAnim();
        }
    }

    //153
    public void ButtonC153()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC153", 0.5f);
        Invoke("InvokerAchievements152", 1f);
    }
    public void InvokerC153()
    {
        Charter153UI(152);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements152()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter153UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[152].AllAnim();
        }
    }

    //154
    public void ButtonC154()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC154", 0.5f);
        Invoke("InvokerAchievements153", 1f);
    }
    public void InvokerC154()
    {
        Charter154UI(153);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements153()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter154UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[153].AllAnim();
        }
    }

    //155
    public void ButtonC155()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC155", 0.5f);
        Invoke("InvokerAchievements154", 1f);
    }
    public void InvokerC155()
    {
        Charter155UI(154);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements154()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter155UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[154].AllAnim();
        }
    }

    //156
    public void ButtonC156()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC156", 0.5f);
        Invoke("InvokerAchievements155", 1f);
    }
    public void InvokerC156()
    {
        Charter156UI(155);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements155()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter156UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[155].AllAnim();
        }
    }

    //157
    public void ButtonC157()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC157", 0.5f);
        Invoke("InvokerAchievements156", 1f);
    }
    public void InvokerC157()
    {
        Charter157UI(156);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements156()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter157UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[156].AllAnim();
        }
    }

    //158
    public void ButtonC158()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC158", 0.5f);
        Invoke("InvokerAchievements157", 1f);
    }
    public void InvokerC158()
    {
        Charter158UI(157);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements157()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter158UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[157].AllAnim();
        }
    }

    //159
    public void ButtonC159()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC159", 0.5f);
        Invoke("InvokerAchievements158", 1f);
    }
    public void InvokerC159()
    {
        Charter159UI(158);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements158()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter159UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[158].AllAnim();
        }
    }

    //160
    public void ButtonC160()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC160", 0.5f);
        Invoke("InvokerAchievements159", 1f);
    }
    public void InvokerC160()
    {
        Charter160UI(159);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements159()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter160UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[159].AllAnim();
        }
    }

    //161
    public void ButtonC161()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC161", 0.5f);
        Invoke("InvokerAchievements160", 1f);
    }
    public void InvokerC161()
    {
        Charter161UI(160);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements160()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter161UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Push_The_Chair();
        logicValuesChapters.Climb_Over();

        if (gameManager.b_move_the_luggage == 0)
        {
            buttonIf[52].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[52].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_tray_table == 0)
        {
            buttonIf[53].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[53].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_bent_metal == 0)
        {
            buttonIf[54].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[54].gameObject.SetActive(false);
        }

        if (gameManager.b_tuck_in_the_loose_wires == 0)
        {
            buttonIf[55].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[55].gameObject.SetActive(false);
        }

        if (gameManager.climb_over <= 2)
        {
            buttonIf[56].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[56].gameObject.SetActive(false);
        }
        if (gameManager.climb_over >= 3)
        {
            buttonIf[57].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[57].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[160].AllAnim();
        }
    }

    //162
    public void ButtonC162()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC162", 0.5f);
        Invoke("InvokerAchievements161", 1f);
    }
    public void InvokerC162()
    {
        Charter162UI(161);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements161()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter162UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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


        logicValuesChapters.B_Move_The_Luggage();
        logicValuesChapters.Climb_Over();

        if (gameManager.b_push_the_chair == 0)
        {
            buttonIf[58].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[58].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_tray_table == 0)
        {
            buttonIf[59].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[59].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_bent_metal == 0)
        {
            buttonIf[60].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[60].gameObject.SetActive(false);
        }

        if (gameManager.b_tuck_in_the_loose_wires == 0)
        {
            buttonIf[61].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[61].gameObject.SetActive(false);
        }

        if (gameManager.climb_over <= 2)
        {
            buttonIf[62].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[62].gameObject.SetActive(false);
        }
        if (gameManager.climb_over >= 3)
        {
            buttonIf[63].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[63].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[161].AllAnim();
        }
    }

    //163
    public void ButtonC163()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC163", 0.5f);
        Invoke("InvokerAchievements162", 1f);
    }
    public void InvokerC163()
    {
        Charter163UI(162);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements162()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter163UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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


        logicValuesChapters.B_Pick_Up_The_Tray_Table();
        logicValuesChapters.Climb_Over();

        if (gameManager.b_push_the_chair == 0)
        {
            buttonIf[64].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[64].gameObject.SetActive(false);
        }

        if (gameManager.b_move_the_luggage == 0)
        {
            buttonIf[65].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[65].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_bent_metal == 0)
        {
            buttonIf[66].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[66].gameObject.SetActive(false);
        }

        if (gameManager.b_tuck_in_the_loose_wires == 0)
        {
            buttonIf[67].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[67].gameObject.SetActive(false);
        }

        if (gameManager.climb_over <= 2)
        {
            buttonIf[68].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[68].gameObject.SetActive(false);
        }
        if (gameManager.climb_over >= 3)
        {
            buttonIf[69].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[69].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[162].AllAnim();
        }
    }

    //164
    public void ButtonC164()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC164", 0.5f);
        Invoke("InvokerAchievements163", 1f);
    }
    public void InvokerC164()
    {
        Charter164UI(163);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements163()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter164UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Pick_Up_The_Bent_Metal();
        logicValuesChapters.Climb_Over();

        if (gameManager.b_push_the_chair == 0)
        {
            buttonIf[70].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[70].gameObject.SetActive(false);
        }

        if (gameManager.b_move_the_luggage == 0)
        {
            buttonIf[71].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[71].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_tray_table == 0)
        {
            buttonIf[72].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[72].gameObject.SetActive(false);
        }

        if (gameManager.b_tuck_in_the_loose_wires == 0)
        {
            buttonIf[73].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[73].gameObject.SetActive(false);
        }

        if (gameManager.climb_over <= 2)
        {
            buttonIf[74].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[74].gameObject.SetActive(false);
        }
        if (gameManager.climb_over >= 3)
        {
            buttonIf[75].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[75].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[163].AllAnim();
        }
    }

    //165
    public void ButtonC165()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC165", 0.5f);
        Invoke("InvokerAchievements164", 1f);
    }
    public void InvokerC165()
    {
        Charter165UI(164);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements164()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter165UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        logicValuesChapters.B_Tuck_In_The_Loose_Wires();
        logicValuesChapters.Climb_Over();

        if (gameManager.b_push_the_chair == 0)
        {
            buttonIf[76].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[76].gameObject.SetActive(false);
        }

        if (gameManager.b_move_the_luggage == 0)
        {
            buttonIf[77].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[77].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_tray_table == 0)
        {
            buttonIf[78].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[78].gameObject.SetActive(false);
        }

        if (gameManager.b_pick_up_the_bent_metal == 0)
        {
            buttonIf[79].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[79].gameObject.SetActive(false);
        }

        if (gameManager.climb_over <= 2)
        {
            buttonIf[80].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[80].gameObject.SetActive(false);
        }
        if (gameManager.climb_over >= 3)
        {
            buttonIf[81].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[81].gameObject.SetActive(false);
        }

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[164].AllAnim();
        }
    }

    //166
    public void ButtonC166()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC166", 0.5f);
        Invoke("InvokerAchievements165", 1f);
    }
    public void InvokerC166()
    {
        Charter166UI(165);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements165()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter166UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[165].AllAnim();
        }
    }

    //167
    public void ButtonC167()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC167", 0.5f);
        Invoke("InvokerAchievements166", 1f);
    }
    public void InvokerC167()
    {
        Charter167UI(166);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements166()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter167UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[166].AllAnim();
        }
    }

    //168
    public void ButtonC168()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC168", 0.5f);
        Invoke("InvokerAchievements167", 1f);
    }
    public void InvokerC168()
    {
        Charter168UI(167);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements167()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter168UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        if (gameManager.b_fight == 0)
        {
            buttonIf[82].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[82].gameObject.SetActive(false);
        }

        if (gameManager.b_fight == 1)
        {
            buttonIf[83].gameObject.SetActive(true);
        }
        else
        {
            buttonIf[83].gameObject.SetActive(false);
        }


        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[167].AllAnim();
        }
    }

    //169
    public void ButtonC169()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC169", 0.5f);
        Invoke("InvokerAchievements168", 1f);
    }
    public void InvokerC169()
    {
        Charter169UI(168);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements168()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter169UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[168].AllAnim();
        }
    }

    //170
    public void ButtonC170()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC170", 0.5f);
        Invoke("InvokerAchievements169", 1f);
    }
    public void InvokerC170()
    {
        Charter170UI(169);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements169()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter170UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[169].AllAnim();
        }
    }

    //171
    public void ButtonC171()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC171", 0.5f);
        Invoke("InvokerAchievements170", 1f);
    }
    public void InvokerC171()
    {
        Charter171UI(170);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements170()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter171UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[170].AllAnim();
        }
    }

    //172
    public void ButtonC172()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC172", 0.5f);
        Invoke("InvokerAchievements171", 1f);
    }
    public void InvokerC172()
    {
        Charter172UI(171);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements171()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter172UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[171].AllAnim();
        }
    }

    //173
    public void ButtonC173()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC173", 0.5f);
        Invoke("InvokerAchievements172", 1f);
    }
    public void InvokerC173()
    {
        Charter173UI(172);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements172()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements15();
    }
    public void Charter173UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[172].AllAnim();
        }
    }

    //174
    public void ButtonC174()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC174", 0.5f);
        Invoke("InvokerAchievements173", 1f);
    }
    public void InvokerC174()
    {
        Charter174UI(173);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements173()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements14();
    }
    public void Charter174UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[173].AllAnim();
        }
    }

    //175
    public void ButtonC175()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC175", 0.5f);
        Invoke("InvokerAchievements174", 1f);
    }
    public void InvokerC175()
    {
        Charter175UI(174);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements174()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter175UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[174].AllAnim();
        }
    }

    //176
    public void ButtonC176()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC176", 0.5f);
        Invoke("InvokerAchievements175", 1f);
    }
    public void InvokerC176()
    {
        Charter176UI(175);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements175()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter176UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[175].AllAnim();
        }
    }

    //177
    public void ButtonC177()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC177", 0.5f);
        Invoke("InvokerAchievements176", 1f);
    }
    public void InvokerC177()
    {
        Charter177UI(176);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements176()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter177UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[176].AllAnim();
        }
    }

    //178
    public void ButtonC178()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC178", 0.5f);
        Invoke("InvokerAchievements177", 1f);
    }
    public void InvokerC178()
    {
        Charter178UI(177);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements177()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter178UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[177].AllAnim();
        }
    }

    //179
    public void ButtonC179()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC179", 0.5f);
        Invoke("InvokerAchievements178", 1f);
    }
    public void InvokerC179()
    {
        Charter179UI(178);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements178()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter179UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[178].AllAnim();
        }
    }

    //180
    public void ButtonC180()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC180", 0.5f);
        Invoke("InvokerAchievements179", 1f);
    }
    public void InvokerC180()
    {
        Charter180UI(179);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements179()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter180UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[179].AllAnim();
        }
    }

    //181
    public void ButtonC181()
    {
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC181", 0.5f);
        Invoke("InvokerAchievements180", 1f);
    }
    public void InvokerC181()
    {
        Charter181UI(180);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements180()
    {
        imgBlackout.gameObject.SetActive(false);
        achievements.Achievements15();
    }
    public void Charter181UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[180].AllAnim();
        }
    }

    //182
    public void ButtonC182()
    {
        FireBaseAnalyticsEvents.EventsWinGame("WinGame");
        imgBlackout.gameObject.SetActive(true);
        anim.Play("BlackoutDarkAnimation");
        Invoke("InvokerC182", 0.5f);
        Invoke("InvokerAchievements181", 1f);
    }
    public void InvokerC182()
    {
        Charter182UI(181);
        gameManager.SavePlayer();
    }
    public void InvokerAchievements181()
    {
        imgBlackout.gameObject.SetActive(false);
    }
    public void Charter182UI(int index)
    {
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            if (i == index)
            {
                gameManager.charter[i] = 1;
            }
            else
            {
                gameManager.charter[i] = 0;
            }
        }

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

        for (int i = 0; i < animContent.Length; i++)
        {
            animContent[181].AllAnim();
        }
    }

    //Лагерь
    public void CampCharter13UI(int index)
    {
        sound.StopSound();
        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            gameManager.charter[i] = 0;
        }
        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

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
        musicCharter.StopMusic();
        gameManager.ResetPlayer();
        activeMenu.BackMenu();
    }

    //Кнопка МЕНЮ на панели
    public void MenuCharterPanel(int index)
    {

        sound.StopSound();

        for (int i = 0; i < gameManager.charter.Length; i++)
        {
            gameManager.charter[i] = 0;
        }

        //toBeContinued.text = "Chapter 1";


        //gameManager.charter1UI = false;
        //gameManager.charter2UI = false;
        //gameManager.charter3UI = false;
        //gameManager.charter4UI = false;
        //gameManager.charter5UI = false;
        //gameManager.charter6UI = false;
        //gameManager.charter7UI = false;
        //gameManager.charter8UI = false;
        //gameManager.charter9UI = false;
        //gameManager.charter10UI = false;
        //gameManager.charter11UI = false;
        //gameManager.charter12UI = false;
        //gameManager.charter13UI = false;
        //gameManager.charter14UI = false;
        //gameManager.charter15UI = false;
        //gameManager.charter16UI = false;
        //gameManager.charter17UI = false;
        //gameManager.charter18UI = false;
        //gameManager.charter19UI = false;
        //gameManager.charter20UI = false;
        //gameManager.charter21UI = false;
        //gameManager.charter22UI = false;
        //gameManager.charter23UI = false;
        //gameManager.charter24UI = false;
        //gameManager.charter25UI = false;
        //gameManager.charter26UI = false;
        //gameManager.charter27UI = false;
        //gameManager.charter28UI = false;
        //gameManager.charter29UI = false;
        //gameManager.charter30UI = false;

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
        musicCharter.StopMusic();
        activeMenu.BackMenu();
    }

    //Оценить
    public void RateUs()
    {
        rateUs.gameObject.SetActive(true);
    }
    public void RateUsClose()
    {
        rateUs.gameObject.SetActive(false);
        Star5();
    }
    public void RateUsNot()
    {
        rateUs.gameObject.SetActive(false);
        rateUsNot.gameObject.SetActive(true);
    }
    public void RateUsNotClose()
    {
        rateUsNot.gameObject.SetActive(false);
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
