using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Typography : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [Header("�������")]
    [Tooltip("������ �����")] public GameObject imageVectorS;
    [Tooltip("������� �����")] public GameObject imageVectorM;
    [Tooltip("������� �����")] public GameObject imageVectorL;

    [Header("������")]
    [Tooltip("54")] public TMP_Text[] typographyText54;

    [Header("����� � ��")]
    [Tooltip("��������� �����")] public int s = 0;//PP
    [Tooltip("������� �����")] public int m = 1;//PP
    [Tooltip("������� �����")] public int l = 0;//PP

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
    public void TypographyGame()//��������� ������
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
