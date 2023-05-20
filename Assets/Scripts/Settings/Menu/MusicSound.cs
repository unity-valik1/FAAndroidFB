using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MusicSound : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private MusicMenu musicMenu;
    [SerializeField] private Sound sound;
    [SerializeField] private MusicCharter musicCharter;
    [SerializeField] private MusicCamp musicCamp;
    [SerializeField] private MusicForest musicForest;

    [Header("Текст ON/OFF")]
    [Tooltip("Текст звуков")] public TMP_Text soundText;
    [Tooltip("Текст музыки")] public TMP_Text musicText;


    

    private void Start()
    {
        if (PlayerPrefs.HasKey("music"))
        {
            musicMenu.music = PlayerPrefs.GetInt("music");
        }
        if (PlayerPrefs.HasKey("sound"))
        {
            sound.sound = PlayerPrefs.GetInt("sound");
        }
        SoundSettingsStart();
        MusicSettingsStart();
    }

    public void SoundSettingsStart()
    {
        if (sound.sound == 1)
        {
            soundText.text = "Sounds: ON";
            sound.SoundSettings();
        }
        else
        {
            soundText.text = "Sounds: OFF";
            sound.SoundSettings();
        }
    }

    public void OnOffSound()
    {
        if (sound.sound == 1)
        {
            FireBaseAnalyticsEvents.EventsSoundsButtonOff("SoundsButtonOff");
            sound.sound = 0;
            soundText.text = "Sounds: OFF";
            sound.SoundSettings();
            PlayerPrefs.SetInt("sound", sound.sound);
            PlayerPrefs.Save();
        }
        else
        {
            FireBaseAnalyticsEvents.EventsSoundsButtonOn("SoundsButtonOn");
            sound.sound = 1;
            soundText.text = "Sounds: ON";
            sound.SoundSettings();
            PlayerPrefs.SetInt("sound", sound.sound);
            PlayerPrefs.Save();
        }
    }

    public void MusicSettingsStart()
    {
        if (musicMenu.music == 1)
        {
            musicText.text = "Music: ON";
            musicMenu.MenuMusicStart();
        }
        else
        {
            musicText.text = "Music: OFF";
            musicMenu.MenuMusicStart();
        }
    }

    public void OnOffMusic()
    {
        if (musicMenu.music == 1)
        {
            FireBaseAnalyticsEvents.EventsMusicButtonOff("MusicButtonOff");
            musicMenu.music = 0;
            musicText.text = "Music: OFF";
            musicMenu.MenuMusicStart();
            PlayerPrefs.SetInt("music", musicMenu.music);
            PlayerPrefs.Save();
        }
        else
        {
            FireBaseAnalyticsEvents.EventsMusicButtonOn("MusicButtonOn");
            musicMenu.music = 1;
            musicText.text = "Music: ON";
            musicMenu.MenuMusicStart();
            PlayerPrefs.SetInt("music", musicMenu.music);
            PlayerPrefs.Save();
        }
    }
}
