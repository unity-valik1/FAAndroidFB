using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Theme : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

    [Header("Галочки")]
    [Tooltip("Темная тема")] public GameObject imageVectorDark;
    [Tooltip("Светлая тема")] public GameObject imageVectorLight;

    [Header("Цвет")]
    [Tooltip("Цвет задний фон")] public Image imageBg;
    [Tooltip("Цвет задний фон")] public Image imagePanel;
    [Tooltip("Цыет текста")] public TMP_Text[] colorText;
    [Tooltip("Цыет кнопок")] public Button[] spriteButton;
    [Tooltip("Цыет кнопок")] public Button[] spriteMenuButton;
    [Tooltip("Цыет кнопок")] public Sprite spriteButtonLight;
    [Tooltip("Цыет кнопок")] public Sprite spriteButtonDark;
    [Tooltip("Цыет кнопок")] public Sprite _spriteMenuButton;

    [Header("Тема в РР")]
    [Tooltip("Тема")] public int theme = 0;//PP

    private void Start()
    {
        for (int i = 0; i < spriteMenuButton.Length; ++i)
        {
            spriteMenuButton[i].image.sprite = _spriteMenuButton;
        }
        if (PlayerPrefs.HasKey("theme"))
        {
            theme = PlayerPrefs.GetInt("theme");
        }
        ThemeSettings();
    }

    public void ThemeSettings()
    {
        if (theme == 1)
        {
            imageVectorDark.SetActive(false);
            imageVectorLight.SetActive(true);
            Color colorBg = new Color32(255, 255, 255, 255);
            imageBg.color = colorBg;
            imagePanel.color = colorBg;

            Color colortext = new Color32(0, 0, 0, 255);
            for (int i = 0; i < colorText.Length; ++i)
            {
                colorText[i].color = colortext;
            }

            //Color colorbutton = new Color32(18, 23, 37, 255);
            for (int i = 0; i < spriteButton.Length; ++i)
            {
                //spriteButton[i].image.color = colorbutton;
                spriteButton[i].image.sprite = spriteButtonLight;
            }
        }
        else
        {
            imageVectorDark.SetActive(true);
            imageVectorLight.SetActive(false);
            Color colorBg = new Color32(18, 23, 37, 255);
            imageBg.color = colorBg;
            imagePanel.color = colorBg;

            Color colortext = new Color32(255, 255, 255, 255);
            for (int i = 0; i < colorText.Length; ++i)
            {
                colorText[i].color = colortext;
            }

            //Color colorbutton1 = new Color32(25, 59, 126, 255);
            for (int i = 0; i < spriteButton.Length; ++i)
            {
                //spriteButton[i].image.color = colorbutton1;
                spriteButton[i].image.sprite = spriteButtonDark;

            }
        }
    }

    public void ThemeLight()
    {
        theme = 1;
        ThemeSettings();
        PlayerPrefs.SetInt("theme", theme);
        PlayerPrefs.Save();
    }

    public void ThemeDark()
    {
        theme = 0;
        ThemeSettings();
        PlayerPrefs.SetInt("theme", theme);
        PlayerPrefs.Save();
    }
}
