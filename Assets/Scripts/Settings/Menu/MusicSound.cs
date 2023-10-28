using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MusicSound : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private MusicMenu musicMenu;
    [SerializeField] private MusicCharter musicCharter;
    [SerializeField] private Sound sound;
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
            musicMenu.StopMusic();
            FireBaseAnalyticsEvents.EventsMusicButtonOff("MusicButtonOff");
            music = 0;
            musicText.text = "Music: OFF";
            PlayerPrefs.SetInt("music", music);
            PlayerPrefs.Save();
        }
        else
        {
            music = 1;
            musicMenu.PlayMusic();
            sound.PlaySound(2);
            FireBaseAnalyticsEvents.EventsMusicButtonOn("MusicButtonOn");
            
            musicText.text = "Music: ON";
            PlayerPrefs.SetInt("music", music);
            PlayerPrefs.Save();
        }
    }
}
