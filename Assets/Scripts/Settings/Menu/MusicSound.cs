using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MusicSound : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private MusicMenu musicMenu;
    [SerializeField] private MusicCharter musicCharter;
    //[SerializeField] private MusicCamp musicCamp;
    //[SerializeField] private MusicForest musicForest;

    [Header("Текст ON/OFF")]
    [Tooltip("Текст музыки")] public TMP_Text musicText;


    [Header("Музыка в РР")]
    [Tooltip("Музыка")] public int music = 1;//PP


    private void Start()
    {
        if (PlayerPrefs.HasKey("music"))
        {
            music = PlayerPrefs.GetInt("music");
        }
        MusicSettingsStart();
    }  
    public void MusicSettingsStart()
    {
        if (music == 1)
        {
            musicText.text = "Music: ON";
            musicMenu.PlayMusic();
        }
        else
        {
            musicText.text = "Music: OFF";
            musicMenu.StopMusic();
        }
    }
    public void OnOffMusic()
    {
        if (music == 1)
        {
            FireBaseAnalyticsEvents.EventsMusicButtonOff("MusicButtonOff");
            music = 0;
            musicText.text = "Music: OFF";
            musicMenu.StopMusic();
            PlayerPrefs.SetInt("music", music);
            PlayerPrefs.Save();
        }
        else
        {
            FireBaseAnalyticsEvents.EventsMusicButtonOn("MusicButtonOn");
            music = 1;
            musicText.text = "Music: ON";
            musicMenu.PlayMusic();
            PlayerPrefs.SetInt("music", music);
            PlayerPrefs.Save();
        }
    }
}
