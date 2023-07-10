using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Typography : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [Header("Галочка")]
    [Tooltip("Мелкий шрифт")] public GameObject imageVectorS;
    [Tooltip("Средний шрифт")] public GameObject imageVectorM;
    [Tooltip("Крупный шрифт")] public GameObject imageVectorL;

    [Header("Текста")]
    [Tooltip("36")] public TMP_Text[] typographyText36;
    [Tooltip("42")] public TMP_Text[] typographyText42;
    [Tooltip("48")] public TMP_Text[] typographyText48;
    [Tooltip("54")] public TMP_Text[] typographyText54;
    [Tooltip("60")] public TMP_Text[] typographyText60;
    [Tooltip("72")] public TMP_Text[] typographyText72;
    [Tooltip("84")] public TMP_Text[] typographyText84;
    [Tooltip("108")] public TMP_Text[] typographyText108;

    [Header("Шрифт в РР")]
    [Tooltip("Маленький шрифт")] public int s = 0;//PP
    [Tooltip("Средний шрифт")] public int m = 0;//PP
    [Tooltip("Крупный шрифт")] public int l = 1;//PP

    void Start()
    {
        if (PlayerPrefs.HasKey("s"))
        {
            s = PlayerPrefs.GetInt("s");

        }
        if (PlayerPrefs.HasKey("m"))
        {
            m = PlayerPrefs.GetInt("m");

        }
        if (PlayerPrefs.HasKey("l"))
        {
            l = PlayerPrefs.GetInt("l");
        }
        TypographyGame();
    }

    public void TypographyGame()//изменение шрифта
    {
        if (s == 1)
        {
            imageVectorS.SetActive(true);
            imageVectorM.SetActive(false);
            imageVectorL.SetActive(false);
        }//Vector
        else if (m == 1)
        {
            imageVectorS.SetActive(false);
            imageVectorM.SetActive(true);
            imageVectorL.SetActive(false);
        }
        else if (l == 1)
        {
            imageVectorS.SetActive(false);
            imageVectorM.SetActive(false);
            imageVectorL.SetActive(true);
        }


        if (s == 1)
        {
            for (int i = 0; i < typographyText36.Length; ++i)
                typographyText36[i].fontSize = 30;
        } //36
        else if (m == 1)
        {
            for (int i = 0; i < typographyText36.Length; ++i)
            {
                typographyText36[i].fontSize = 36;
            }
        }
        else if (l == 1)
        {
            for (int i = 0; i < typographyText36.Length; ++i)
            {
                typographyText36[i].fontSize = 42;
            }
        }


        if (s == 1)
        {
            for (int i = 0; i < typographyText42.Length; ++i)
                typographyText42[i].fontSize = 36;
        } //42
        else if (m == 1)
        {
            for (int i = 0; i < typographyText42.Length; ++i)
            {
                typographyText42[i].fontSize = 42;
            }
        }
        else if (l == 1)
        {
            for (int i = 0; i < typographyText42.Length; ++i)
            {
                typographyText42[i].fontSize = 48;
            }
        }

        if (s == 1)
        {
            for (int i = 0; i < typographyText48.Length; ++i)
                typographyText48[i].fontSize = 42;
        } //48
        else if (m == 1)
        {
            for (int i = 0; i < typographyText48.Length; ++i)
            {
                typographyText48[i].fontSize = 48;
            }
        }
        else if (l == 1)
        {
            for (int i = 0; i < typographyText48.Length; ++i)
            {
                typographyText48[i].fontSize = 54;
            }
        }

        if (s == 1)
        {
            for (int i = 0; i < typographyText54.Length; ++i)
                typographyText54[i].fontSize = 48;
        } //54
        else if (m == 1)
        {
            for (int i = 0; i < typographyText54.Length; ++i)
            {
                typographyText54[i].fontSize = 54;
            }
        }
        else if (l == 1)
        {
            for (int i = 0; i < typographyText54.Length; ++i)
            {
                typographyText54[i].fontSize = 60;
            }
        }

        if (s == 1)
        {
            for (int i = 0; i < typographyText60.Length; ++i)
                typographyText60[i].fontSize = 54;
        } //60
        else if (m == 1)
        {
            for (int i = 0; i < typographyText60.Length; ++i)
            {
                typographyText60[i].fontSize = 60;
            }
        }
        else if (l == 1)
        {
            for (int i = 0; i < typographyText60.Length; ++i)
            {
                typographyText60[i].fontSize = 66;
            }
        }

        if (s == 1)
        {
            for (int i = 0; i < typographyText72.Length; ++i)
                typographyText72[i].fontSize = 66;
        } //72
        else if (m == 1)
        {
            for (int i = 0; i < typographyText72.Length; ++i)
            {
                typographyText72[i].fontSize = 72;
            }
        }
        else if (l == 1)
        {
            for (int i = 0; i < typographyText72.Length; ++i)
            {
                typographyText72[i].fontSize = 78;
            }
        }

        if (s == 1)
        {
            for (int i = 0; i < typographyText84.Length; ++i)
                typographyText84[i].fontSize = 78;
        } //84 
        else if (m == 1)
        {
            for (int i = 0; i < typographyText84.Length; ++i)
            {
                typographyText84[i].fontSize = 84;
            }
        }
        else if (l == 1)
        {
            for (int i = 0; i < typographyText84.Length; ++i)
            {
                typographyText84[i].fontSize = 90;
            }
        }

        if (s == 1)
        {
            for (int i = 0; i < typographyText108.Length; ++i)
                typographyText108[i].fontSize = 102;
        } //126
        else if (m == 1)
        {
            for (int i = 0; i < typographyText108.Length; ++i)
            {
                typographyText108[i].fontSize = 108;
            }
        }
        else if (l == 1)
        {
            for (int i = 0; i < typographyText108.Length; ++i)
            {
                typographyText108[i].fontSize = 114;
            }
        }
    }

    public void S()
    {
        FireBaseAnalyticsEvents.EventsTyphographySmall("TyphographySmall");
        s = 1;
        m = 0;
        l = 0;
        TypographyGame();
        PlayerPrefs.SetInt("s", s);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("m", m);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("l", l);
        PlayerPrefs.Save();
    }

    public void M()
    {
        FireBaseAnalyticsEvents.EventsTyphographyMiddle("TyphographyMiddle");
        s = 0;
        m = 1;
        l = 0;
        TypographyGame();
        PlayerPrefs.SetInt("s", s);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("m", m);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("l", l);
        PlayerPrefs.Save();
    }

    public void L()
    {
        FireBaseAnalyticsEvents.EventsTyphographyLarge("TyphographyLarge");
        s = 0;
        m = 0;
        l = 1;
        TypographyGame();
        PlayerPrefs.SetInt("s", s);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("m", m);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("l", l);
        PlayerPrefs.Save();
    }
}
