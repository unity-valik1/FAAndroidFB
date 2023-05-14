using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class Achievements : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Camera camera1;
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

    public string nameAchievement;
    public TMP_Text textnameAchievement;
    public GameObject canvasAchievement;

    private void Start()
    {
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
        AchievementsOnOff();
    }
    public void AchievementsOnOff()
    {
        if (achievements1 == 1)
        {
            imageBlurAchievements1.gameObject.SetActive(false);
            imageBgAchievements1.GetComponent<Image>().enabled = true;
        }
        else if (achievements1 == 0)
        {
            imageBlurAchievements1.gameObject.SetActive(true);
            imageBgAchievements1.GetComponent<Image>().enabled = false;
        }

        if (achievements2 == 1)
        {
            imageBlurAchievements2.gameObject.SetActive(false);
            imageBgAchievements2.GetComponent<Image>().enabled = true;
        }
        else if (achievements2 == 0)
        {
            imageBlurAchievements2.gameObject.SetActive(true);
            imageBgAchievements2.GetComponent<Image>().enabled = false;
        }

        if (achievements3 == 1)
        {
            imageBlurAchievements3.gameObject.SetActive(false);
            imageBgAchievements3.GetComponent<Image>().enabled = true;
        }
        else if (achievements3 == 0)
        {
            imageBlurAchievements3.gameObject.SetActive(true);
            imageBgAchievements3.GetComponent<Image>().enabled = false;
        }

        if (achievements4 == 1)
        {
            imageBlurAchievements4.gameObject.SetActive(false);
            imageBgAchievements4.GetComponent<Image>().enabled = true;
        }
        else if (achievements4 == 0)
        {
            imageBlurAchievements4.gameObject.SetActive(true);
            imageBgAchievements4.GetComponent<Image>().enabled = false;
        }

        if (achievements5 == 1)
        {
            imageBlurAchievements5.gameObject.SetActive(false);
            imageBgAchievements5.GetComponent<Image>().enabled = true;
        }
        else if (achievements5 == 0)
        {
            imageBlurAchievements5.gameObject.SetActive(true);
            imageBgAchievements5.GetComponent<Image>().enabled = false;
        }

        if (achievements6 == 1)
        {
            imageBlurAchievements6.gameObject.SetActive(false);
            imageBgAchievements6.GetComponent<Image>().enabled = true;
        }
        else if (achievements6 == 0)
        {
            imageBlurAchievements6.gameObject.SetActive(true);
            imageBgAchievements6.GetComponent<Image>().enabled = false;
        }

        if (achievements7 == 1)
        {
            imageBlurAchievements7.gameObject.SetActive(false);
            imageBgAchievements7.GetComponent<Image>().enabled = true;
        }
        else if (achievements7 == 0)
        {
            imageBlurAchievements7.gameObject.SetActive(true);
            imageBgAchievements7.GetComponent<Image>().enabled = false;
        }

        if (achievements8 == 1)
        {
            imageBlurAchievements8.gameObject.SetActive(false);
            imageBgAchievements8.GetComponent<Image>().enabled = true;
        }
        else if (achievements8 == 0)
        {
            imageBlurAchievements8.gameObject.SetActive(true);
            imageBgAchievements8.GetComponent<Image>().enabled = false;
        }

        if (achievements9 == 1)
        {
            imageBlurAchievements9.gameObject.SetActive(false);
            imageBgAchievements9.GetComponent<Image>().enabled = true;
        }
        else if (achievements9 == 0)
        {
            imageBlurAchievements9.gameObject.SetActive(true);
            imageBgAchievements9.GetComponent<Image>().enabled = false;
        }

        if (achievements10 == 1)
        {
            imageBlurAchievements10.gameObject.SetActive(false);
            imageBgAchievements10.GetComponent<Image>().enabled = true;
        }
        else if (achievements10 == 0)
        {
            imageBlurAchievements10.gameObject.SetActive(true);
            imageBgAchievements10.GetComponent<Image>().enabled = false;
        } 
        
        if (achievements11 == 1)
        {
            imageBlurAchievements11.gameObject.SetActive(false);
            imageBgAchievements11.GetComponent<Image>().enabled = true;
        }
        else if (achievements11 == 0)
        {
            imageBlurAchievements11.gameObject.SetActive(true);
            imageBgAchievements11.GetComponent<Image>().enabled = false;
        }
    }


    public void BackAchievement()
    {
        achievements1 = 0;
        achievements2 = 0;
        achievements3 = 0;
        achievements4 = 0;
        achievements5 = 0;
        achievements6 = 0;
        achievements7 = 0;
        achievements8 = 0;
        achievements9 = 0;
        achievements10 = 0;
        achievements11 = 0;
        PlayerPrefs.SetInt("achievements1", achievements1);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("achievements2", achievements2);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("achievements3", achievements3);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("achievements4", achievements4);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("achievements5", achievements5);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("achievements6", achievements6);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("achievements7", achievements7);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("achievements8", achievements8);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("achievements9", achievements9);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("achievements10", achievements10);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("achievements11", achievements11);
        PlayerPrefs.Save();
        anim.Play("BackAchievement");
        Invoke("BackAchievementInvok", 0.5f);
    }
    
    public void BackAchievementInvok()
    {
        button.interactable = false;
        camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = false;
        canvasAchievement.gameObject.SetActive(false);
    }
    public void Achievements1()
    {
        if (achievements1 == 0)
        {
            anim.Play("Achievements");
            Invoke("Invoker", 1f);
            camera1.GetComponentInChildren<PostProcessVolume>().isGlobal= true;
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "Hero";
            achievements1 = 1;
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements1", achievements1);
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
            camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "Dima";
            achievements2 = 1;
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements2", achievements2);
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
            camera1.GetComponentInChildren<PostProcessVolume>().isGlobal = true;
            canvasAchievement.gameObject.SetActive(true);
            nameAchievement = textnameAchievement.text;
            textnameAchievement.text = "Valik";
            achievements3 = 1;
            AchievementsOnOff();
            PlayerPrefs.SetInt("achievements3", achievements3);
            PlayerPrefs.Save();
        }
        else if (achievements3 == 1)
        {

        }
    }

    public void Achievements4()
    {
        achievements4 = 1;
        AchievementsOnOff();
        PlayerPrefs.SetInt("achievements4", achievements4);
        PlayerPrefs.Save();
    }

    public void Achievements5()
    {
        achievements5 = 1;
        AchievementsOnOff();
        PlayerPrefs.SetInt("achievements5", achievements5);
        PlayerPrefs.Save();
    }

    public void Achievements6()
    {
        achievements6 = 1;
        AchievementsOnOff();
        PlayerPrefs.SetInt("achievements6", achievements6);
        PlayerPrefs.Save();
    }

    public void Achievements7()
    {
        achievements7 = 1;
        AchievementsOnOff();
        PlayerPrefs.SetInt("achievements7", achievements7);
        PlayerPrefs.Save();
    }

    public void Achievements8()
    {
        achievements8 = 1;
        AchievementsOnOff();
        PlayerPrefs.SetInt("achievements8", achievements8);
        PlayerPrefs.Save();
    }

    public void Achievements9()
    {
        achievements9 = 1;
        AchievementsOnOff();
        PlayerPrefs.SetInt("achievements9", achievements9);
        PlayerPrefs.Save();
    }

    public void Achievements10()
    {
        achievements10 = 1;
        AchievementsOnOff();
        PlayerPrefs.SetInt("achievements10", achievements10);
        PlayerPrefs.Save();
    }

    public void Achievements11()
    {
        achievements11 = 1;
        AchievementsOnOff();
        PlayerPrefs.SetInt("achievements11", achievements11);
        PlayerPrefs.Save();
    }

    public void Invoker()
    {
        button.interactable = true;
    }
}
