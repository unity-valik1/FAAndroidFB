using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Animation anim;
    [SerializeField] private Button button;

    [Header("Достижения")]
    [Tooltip("Достижение 1")] public int achievements1 = 0;//S
    [Tooltip("Достижение 2")] public int achievements2 = 0;//S
    [Tooltip("Достижение 3")] public int achievements3 = 0;//S
    [Tooltip("Достижение 4")] public int achievements4 = 0;//S
    [Tooltip("Достижение 5")] public int achievements5 = 0;//S
    [Tooltip("Достижение 6")] public int achievements6 = 0;//S
    [Tooltip("Достижение 7")] public int achievements7 = 0;//S
    [Tooltip("Достижение 8")] public int achievements8 = 0;//S
    [Tooltip("Достижение 9")] public int achievements9 = 0;//S
    [Tooltip("Достижение 10")] public int achievements10 = 0;//S
    [Tooltip("Достижение 11")] public int achievements11 = 0;//S
    [Tooltip("Достижение 12")] public int achievements12 = 0;//S
    [Tooltip("Достижение 13")] public int achievements13 = 0;//S
    [Tooltip("Достижение 14")] public int achievements14 = 0;//S
    [Tooltip("Достижение 15")] public int achievements15 = 0;//S

    [Header("Фон активных достижений")]
    [SerializeField] private Image imageBgAchievements1;
    [SerializeField] private Image imageBgAchievements2;
    [SerializeField] private Image imageBgAchievements3;
    [SerializeField] private Image imageBgAchievements4;
    [SerializeField] private Image imageBgAchievements5;
    [SerializeField] private Image imageBgAchievements6;
    [SerializeField] private Image imageBgAchievements7;
    [SerializeField] private Image imageBgAchievements8;
    [SerializeField] private Image imageBgAchievements9;
    [SerializeField] private Image imageBgAchievements10;
    [SerializeField] private Image imageBgAchievements11;
    [SerializeField] private Image imageBgAchievements12;
    [SerializeField] private Image imageBgAchievements13;
    [SerializeField] private Image imageBgAchievements14;
    [SerializeField] private Image imageBgAchievements15;

    [Header("Фон неактивных достижений")]
    [SerializeField] private Image imageBlurAchievements1;
    [SerializeField] private Image imageBlurAchievements2;
    [SerializeField] private Image imageBlurAchievements3;
    [SerializeField] private Image imageBlurAchievements4;
    [SerializeField] private Image imageBlurAchievements5;
    [SerializeField] private Image imageBlurAchievements6;
    [SerializeField] private Image imageBlurAchievements7;
    [SerializeField] private Image imageBlurAchievements8;
    [SerializeField] private Image imageBlurAchievements9;
    [SerializeField] private Image imageBlurAchievements10;
    [SerializeField] private Image imageBlurAchievements11;
    [SerializeField] private Image imageBlurAchievements12;
    [SerializeField] private Image imageBlurAchievements13;
    [SerializeField] private Image imageBlurAchievements14;
    [SerializeField] private Image imageBlurAchievements15;

    [SerializeField] private TMP_Text[] text1;
    [SerializeField] private TMP_Text[] text2;

    [SerializeField] private Image[] img;

    public string nameAchievement;
    public TMP_Text textnameAchievement;
    public int number;
    public TMP_Text numberAchievement;
    public GameObject canvasAchievement;
    public Sprite[] imgAchievement;
    public Image achievement;

    private void Start()
    {
        if (PlayerPrefs.HasKey("number"))
        {
            number = PlayerPrefs.GetInt("number");
        }
        if (PlayerPrefs.HasKey("achievements1"))
        {
            achievements1 = PlayerPrefs.GetInt("achievements1");
        }
        if (PlayerPrefs.HasKey("achievements2"))
        {
            achievements2 = PlayerPrefs.GetInt("achievements2");
        }
        if (PlayerPrefs.HasKey("achievements3"))
        {
            achievements3 = PlayerPrefs.GetInt("achievements3");
        }
        if (PlayerPrefs.HasKey("achievements4"))
        {
            achievements4 = PlayerPrefs.GetInt("achievements4");
        }
        if (PlayerPrefs.HasKey("achievements5"))
        {
            achievements5 = PlayerPrefs.GetInt("achievements5");
        }
        if (PlayerPrefs.HasKey("achievements6"))
        {
            achievements6 = PlayerPrefs.GetInt("achievements6");
        }
        if (PlayerPrefs.HasKey("achievements7"))
        {
            achievements7 = PlayerPrefs.GetInt("achievements7");
        }
        if (PlayerPrefs.HasKey("achievements8"))
        {
            achievements8 = PlayerPrefs.GetInt("achievements8");
        }
        if (PlayerPrefs.HasKey("achievements9"))
        {
            achievements9 = PlayerPrefs.GetInt("achievements9");
        }
        if (PlayerPrefs.HasKey("achievements10"))
        {
            achievements10 = PlayerPrefs.GetInt("achievements10");
        }
        if (PlayerPrefs.HasKey("achievements11"))
        {
            achievements11 = PlayerPrefs.GetInt("achievements11");
        }
        if (PlayerPrefs.HasKey("achievements12"))
        {
            achievements12 = PlayerPrefs.GetInt("achievements12");
        }
        if (PlayerPrefs.HasKey("achievements13"))
        {
            achievements13 = PlayerPrefs.GetInt("achievements13");
        }
        if (PlayerPrefs.HasKey("achievements14"))
        {
            achievements14 = PlayerPrefs.GetInt("achievements14");
        }
        if (PlayerPrefs.HasKey("achievements15"))
        {
            achievements15 = PlayerPrefs.GetInt("achievements15");
        }
        AchievementsOnOff();
    }

    public void AchievementsOnOff()
    {
        if (achievements1 == 1)
        {
            imageBlurAchievements1.gameObject.SetActive(false);
            imageBgAchievements1.GetComponent<Image>().enabled = true;
            text1[0].color = Color.white;
            text2[0].color = Color.white;
            img[0].color = Color.white;
        }
        else if (achievements1 == 0)
        {
            imageBlurAchievements1.gameObject.SetActive(true);
            imageBgAchievements1.GetComponent<Image>().enabled = false;
            text1[0].color = new Color32(255, 255, 255, 50);
            text2[0].color = new Color32(255, 255, 255, 50);
            img[0].color = new Color32(255, 255, 255, 50);
        }

        if (achievements2 == 1)
        {
            imageBlurAchievements2.gameObject.SetActive(false);
            imageBgAchievements2.GetComponent<Image>().enabled = true;
            text1[1].color = Color.white;
            text2[1].color = Color.white;
            img[1].color = Color.white;
        }
        else if (achievements2 == 0)
        {
            imageBlurAchievements2.gameObject.SetActive(true);
            imageBgAchievements2.GetComponent<Image>().enabled = false;
            text1[1].color = new Color32(255, 255, 255, 50);
            text2[1].color = new Color32(255, 255, 255, 50);
            img[1].color = new Color32(255, 255, 255, 50);
        }

        if (achievements3 == 1)
        {
            imageBlurAchievements3.gameObject.SetActive(false);
            imageBgAchievements3.GetComponent<Image>().enabled = true;
            text1[2].color = Color.white;
            text2[2].color = Color.white;
            img[2].color = Color.white;
        }
        else if (achievements3 == 0)
        {
            imageBlurAchievements3.gameObject.SetActive(true);
            imageBgAchievements3.GetComponent<Image>().enabled = false;
            text1[2].color = new Color32(255, 255, 255, 50);
            text2[2].color = new Color32(255, 255, 255, 50);
            img[2].color = new Color32(255, 255, 255, 50);
        }

        if (achievements4 == 1)
        {
            imageBlurAchievements4.gameObject.SetActive(false);
            imageBgAchievements4.GetComponent<Image>().enabled = true;
            text1[3].color = Color.white;
            text2[3].color = Color.white;
            img[3].color = Color.white;
        }
        else if (achievements4 == 0)
        {
            imageBlurAchievements4.gameObject.SetActive(true);
            imageBgAchievements4.GetComponent<Image>().enabled = false;
            text1[3].color = new Color32(255, 255, 255, 50);
            text2[3].color = new Color32(255, 255, 255, 50);
            img[3].color = new Color32(255, 255, 255, 50);
        }

        if (achievements5 == 1)
        {
            imageBlurAchievements5.gameObject.SetActive(false);
            imageBgAchievements5.GetComponent<Image>().enabled = true;
            text1[4].color = Color.white;
            text2[4].color = Color.white;
            img[4].color = Color.white;
        }
        else if (achievements5 == 0)
        {
            imageBlurAchievements5.gameObject.SetActive(true);
            imageBgAchievements5.GetComponent<Image>().enabled = false;
            text1[4].color = new Color32(255, 255, 255, 50);
            text2[4].color = new Color32(255, 255, 255, 50);
            img[4].color = new Color32(255, 255, 255, 50);
        }

        if (achievements6 == 1)
        {
            imageBlurAchievements6.gameObject.SetActive(false);
            imageBgAchievements6.GetComponent<Image>().enabled = true;
            text1[5].color = Color.white;
            text2[5].color = Color.white;
            img[5].color = Color.white;
        }
        else if (achievements6 == 0)
        {
            imageBlurAchievements6.gameObject.SetActive(true);
            imageBgAchievements6.GetComponent<Image>().enabled = false;
            text1[5].color = new Color32(255, 255, 255, 50);
            text2[5].color = new Color32(255, 255, 255, 50);
            img[5].color = new Color32(255, 255, 255, 50);
        }

        if (achievements7 == 1)
        {
            imageBlurAchievements7.gameObject.SetActive(false);
            imageBgAchievements7.GetComponent<Image>().enabled = true;
            text1[6].color = Color.white;
            text2[6].color = Color.white;
            img[6].color = Color.white;
        }
        else if (achievements7 == 0)
        {
            imageBlurAchievements7.gameObject.SetActive(true);
            imageBgAchievements7.GetComponent<Image>().enabled = false;
            text1[6].color = new Color32(255, 255, 255, 50);
            text2[6].color = new Color32(255, 255, 255, 50);
            img[6].color = new Color32(255, 255, 255, 50);
        }

        if (achievements8 == 1)
        {
            imageBlurAchievements8.gameObject.SetActive(false);
            imageBgAchievements8.GetComponent<Image>().enabled = true;
            text1[7].color = Color.white;
            text2[7].color = Color.white;
            img[7].color = Color.white;
        }
        else if (achievements8 == 0)
        {
            imageBlurAchievements8.gameObject.SetActive(true);
            imageBgAchievements8.GetComponent<Image>().enabled = false;
            text1[7].color = new Color32(255, 255, 255, 50);
            text2[7].color = new Color32(255, 255, 255, 50);
            img[7].color = new Color32(255, 255, 255, 50);
        }

        if (achievements9 == 1)
        {
            imageBlurAchievements9.gameObject.SetActive(false);
            imageBgAchievements9.GetComponent<Image>().enabled = true;
            text1[8].color = Color.white;
            text2[8].color = Color.white;
            img[8].color = Color.white;
        }
        else if (achievements9 == 0)
        {
            imageBlurAchievements9.gameObject.SetActive(true);
            imageBgAchievements9.GetComponent<Image>().enabled = false;
            text1[8].color = new Color32(255, 255, 255, 50);
            text2[8].color = new Color32(255, 255, 255, 50);
            img[8].color = new Color32(255, 255, 255, 50);
        }

        if (achievements10 == 1)
        {
            imageBlurAchievements10.gameObject.SetActive(false);
            imageBgAchievements10.GetComponent<Image>().enabled = true;
            text1[9].color = Color.white;
            text2[9].color = Color.white;
            img[9].color = Color.white;
        }
        else if (achievements10 == 0)
        {
            imageBlurAchievements10.gameObject.SetActive(true);
            imageBgAchievements10.GetComponent<Image>().enabled = false;
            text1[9].color = new Color32(255, 255, 255, 50);
            text2[9].color = new Color32(255, 255, 255, 50);
            img[9].color = new Color32(255, 255, 255, 50);
        } 
        
        if (achievements11 == 1)
        {
            imageBlurAchievements11.gameObject.SetActive(false);
            imageBgAchievements11.GetComponent<Image>().enabled = true;
            text1[10].color = Color.white;
            text2[10].color = Color.white;
            img[10].color = Color.white;
        }
        else if (achievements11 == 0)
        {
            imageBlurAchievements11.gameObject.SetActive(true);
            imageBgAchievements11.GetComponent<Image>().enabled = false;
            text1[10].color = new Color32(255, 255, 255, 50);
            text2[10].color = new Color32(255, 255, 255, 50);
            img[10].color = new Color32(255, 255, 255, 50);
        }

        if (achievements12 == 1)
        {
            imageBlurAchievements12.gameObject.SetActive(false);
            imageBgAchievements12.GetComponent<Image>().enabled = true;
            text1[11].color = Color.white;
            text2[11].color = Color.white;
            img[11].color = Color.white;
        }
        else if (achievements12 == 0)
        {
            imageBlurAchievements12.gameObject.SetActive(true);
            imageBgAchievements12.GetComponent<Image>().enabled = false;
            text1[11].color = new Color32(255, 255, 255, 50);
            text2[11].color = new Color32(255, 255, 255, 50);
            img[11].color = new Color32(255, 255, 255, 50);
        }

        if (achievements13 == 1)
        {
            imageBlurAchievements13.gameObject.SetActive(false);
            imageBgAchievements13.GetComponent<Image>().enabled = true;
            text1[12].color = Color.white;
            text2[12].color = Color.white;
            img[12].color = Color.white;
        }
        else if (achievements13 == 0)
        {
            imageBlurAchievements13.gameObject.SetActive(true);
            imageBgAchievements13.GetComponent<Image>().enabled = false;
            text1[12].color = new Color32(255, 255, 255, 50);
            text2[12].color = new Color32(255, 255, 255, 50);
            img[12].color = new Color32(255, 255, 255, 50);
        }

        if (achievements14 == 1)
        {
            imageBlurAchievements14.gameObject.SetActive(false);
            imageBgAchievements14.GetComponent<Image>().enabled = true;
            text1[13].color = Color.white;
            text2[13].color = Color.white;
            img[13].color = Color.white;
        }
        else if (achievements14 == 0)
        {
            imageBlurAchievements14.gameObject.SetActive(true);
            imageBgAchievements14.GetComponent<Image>().enabled = false;
            text1[13].color = new Color32(255, 255, 255, 50);
            text2[13].color = new Color32(255, 255, 255, 50);
            img[13].color = new Color32(255, 255, 255, 50);
        }

        if (achievements15 == 1)
        {
            imageBlurAchievements15.gameObject.SetActive(false);
            imageBgAchievements15.GetComponent<Image>().enabled = true;
            text1[14].color = Color.white;
            text2[14].color = Color.white;
            img[14].color = Color.white;
        }
        else if (achievements15 == 0)
        {
            imageBlurAchievements15.gameObject.SetActive(true);
            imageBgAchievements15.GetComponent<Image>().enabled = false;
            text1[14].color = new Color32(255, 255, 255, 50);
            text2[14].color = new Color32(255, 255, 255, 50);
            img[14].color = new Color32(255, 255, 255, 50);
        }
    }

    public void BackAchievement()
    {
        anim.Play("BackAchievement");
        Invoke("BackAchievementInvok", 0.5f);
    }
    
    public void BackAchievementInvok()
    {
        button.interactable = false;
        canvasAchievement.gameObject.SetActive(false);
    }

    public void Achievements1()
    {
        if (achievements1 == 0)
        {
            anim.Play("Achievements");
            Invoke("Invoker", 1f);
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "None of your business";
            achievement.sprite = imgAchievement[0];
            achievements1 = 1;
            number++;
            numberAchievement.text = (number + "/15").ToString();
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements1", achievements1);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("number", number);
            PlayerPrefs.Save();
        }
        else if (achievements1 == 1)
        {

        }
    }
    public void Achievements2()
    {
        if (achievements2 == 0)
        {
            anim.Play("Achievements");
            Invoke("Invoker", 1f);
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "Travelling Buddy";
            achievement.sprite = imgAchievement[1];
            achievements2 = 1;
            number++;
            numberAchievement.text = (number + "/15").ToString();
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements2", achievements2);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("number", number);
            PlayerPrefs.Save();
        }
        else if (achievements2 == 1)
        {

        }
    }
    public void Achievements3()
    {
        if (achievements3 == 0)
        {
            anim.Play("Achievements");
            Invoke("Invoker", 1f);
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "Sixth Sense";
            achievement.sprite = imgAchievement[2];
            achievements3 = 1;
            number++;
            numberAchievement.text = (number + "/15").ToString();
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements3", achievements3);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("number", number);
            PlayerPrefs.Save();
        }
        else if (achievements3 == 1)
        {

        }
    }
    public void Achievements4()
    {
        if (achievements4 == 0)
        {
            anim.Play("Achievements");
            Invoke("Invoker", 1f);
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "Wasted!";
            achievement.sprite = imgAchievement[3];
            achievements4 = 1;
            number++;
            numberAchievement.text = (number + "/15").ToString();
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements4", achievements4);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("number", number);
            PlayerPrefs.Save();
        }
        else if (achievements4 == 1)
        {

        }
    }
    public void Achievements5()
    {
        if (achievements5 == 0)
        {
            anim.Play("Achievements");
            Invoke("Invoker", 1f);
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "Straight-Edge";
            achievement.sprite = imgAchievement[4];
            achievements5 = 1;
            number++;
            numberAchievement.text = (number + "/15").ToString();
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements5", achievements5);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("number", number);
            PlayerPrefs.Save();
        }
        else if (achievements5 == 1)
        {

        }
    }
    public void Achievements6()
    {
        if (achievements6 == 0)
        {
            anim.Play("Achievements");
            Invoke("Invoker", 1f);
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "Do Not Disturb";
            achievement.sprite = imgAchievement[5];
            achievements6 = 1;
            number++;
            numberAchievement.text = (number + "/15").ToString();
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements6", achievements6);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("number", number);
            PlayerPrefs.Save();
        }
        else if (achievements6 == 1)
        {

        }
    }
    public void Achievements7()
    {
        if (achievements7 == 0)
        {
            anim.Play("Achievements");
            Invoke("Invoker", 1f);
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "The Forecast is…";
            achievement.sprite = imgAchievement[6];
            achievements7 = 1;
            number++;
            numberAchievement.text = (number + "/15").ToString();
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements7", achievements7);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("number", number);
            PlayerPrefs.Save();
        }
        else if (achievements7 == 1)
        {

        }
    }
    public void Achievements8()
    {
        if (achievements8 == 0)
        {
            anim.Play("Achievements");
            Invoke("Invoker", 1f);
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "Money solves everything";
            achievement.sprite = imgAchievement[7];
            achievements8 = 1;
            number++;
            numberAchievement.text = (number + "/15").ToString();
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements8", achievements8);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("number", number);
            PlayerPrefs.Save();
        }
        else if (achievements8 == 1)
        {

        }
    }
    public void Achievements9()
    {
        if (achievements9 == 0)
        {
            anim.Play("Achievements");
            Invoke("Invoker", 1f);
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "Caused a scene";
            achievement.sprite = imgAchievement[8];
            achievements9 = 1;
            number++;
            numberAchievement.text = (number + "/15").ToString();
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements9", achievements9);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("number", number);
            PlayerPrefs.Save();
        }
        else if (achievements9 == 1)
        {

        }
    }
    public void Achievements10()
    {
        if (achievements10 == 0)
        {
            anim.Play("Achievements");
            Invoke("Invoker", 1f);
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "Not My Bag, Not My Problem";
            achievement.sprite = imgAchievement[9];
            achievements10 = 1;
            number++;
            numberAchievement.text = (number + "/15").ToString();
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements10", achievements10);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("number", number);
            PlayerPrefs.Save();
        }
        else if (achievements10 == 1)
        {

        }
    }
    public void Achievements11()
    {
        if (achievements11 == 0)
        {
            anim.Play("Achievements");
            Invoke("Invoker", 1f);
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "Curiosity";
            achievement.sprite = imgAchievement[10];
            achievements11 = 1;
            number++;
            numberAchievement.text = (number + "/15").ToString();
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements11", achievements11);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("number", number);
            PlayerPrefs.Save();
        }
        else if (achievements11 == 1)
        {

        }
    }
    public void Achievements12()
    {
        if (achievements12 == 0)
        {
            anim.Play("Achievements");
            Invoke("Invoker", 1f);
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "Brought a Knife to a Fist Fight";
            achievement.sprite = imgAchievement[11];
            achievements12 = 1;
            number++;
            numberAchievement.text = (number + "/15").ToString();
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements12", achievements12);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("number", number);
            PlayerPrefs.Save();
        }
        else if (achievements12 == 1)
        {

        }
    }
    public void Achievements13()
    {
        if (achievements13 == 0)
        {
            anim.Play("Achievements");
            Invoke("Invoker", 1f);
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "A matter of life and death";
            achievement.sprite = imgAchievement[12];
            achievements13 = 1;
            number++;
            numberAchievement.text = (number + "/15").ToString();
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements13", achievements13);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("number", number);
            PlayerPrefs.Save();
        }
        else if (achievements13 == 1)
        {

        }
    }
    public void Achievements14()
    {
        if (achievements14 == 0)
        {
            anim.Play("Achievements");
            Invoke("Invoker", 1f);
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "Nobody Left Behind";
            achievement.sprite = imgAchievement[13];
            achievements14 = 1;
            number++;
            numberAchievement.text = (number + "/15").ToString();
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements14", achievements14);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("number", number);
            PlayerPrefs.Save();
        }
        else if (achievements14 == 1)
        {

        }
    }
    public void Achievements15()
    {
        if (achievements15 == 0)
        {
            anim.Play("Achievements");
            Invoke("Invoker", 1f);
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "Strong Man";
            achievement.sprite = imgAchievement[14];
            achievements15 = 1;
            number++;
            numberAchievement.text = (number + "/15").ToString();
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements15", achievements15);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("number", number);
            PlayerPrefs.Save();
        }
        else if (achievements15 == 1)
        {

        }
    }

    public void Invoker()
    {
        button.interactable = true;
    }
}
