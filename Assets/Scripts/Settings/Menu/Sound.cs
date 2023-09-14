using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip[] audioClip;

    [Header("Текст ON/OFF")]
    [Tooltip("Текст звуков")] public TMP_Text soundText;

    [Header("Звуки в РР")]
    [Tooltip("Звуки")] public int sound = 1;//PP
    private void Start()
    {

        if (PlayerPrefs.HasKey("sound"))
        {
            sound = PlayerPrefs.GetInt("sound");
        }
        SoundSettingsStart();
    }
    public void SoundSettingsStart()
    {
        if (sound == 1)
        {
            soundText.text = "Sounds: ON";
            PlaySound(-1);
        }
        else
        {
            soundText.text = "Sounds: OFF";
            StopSound();
        }
    }
    public void OnOffSound()
    {
        if (sound == 1)
        {
            FireBaseAnalyticsEvents.EventsSoundsButtonOff("SoundsButtonOff");
            sound = 0;
            soundText.text = "Sounds: OFF";
            StopSound();
            PlayerPrefs.SetInt("sound", sound);
            PlayerPrefs.Save();
        }
        else
        {
            FireBaseAnalyticsEvents.EventsSoundsButtonOn("SoundsButtonOn");
            sound = 1;
            soundText.text = "Sounds: ON";
            PlaySound(-1);
            PlayerPrefs.SetInt("sound", sound);
            PlayerPrefs.Save();
        }
    }

    public void PlaySound(int index)
    {
        for (int i = 0; i < audioClip.Length; i++)
        {
            if (i == index)
            {
                audioSource.clip = audioClip[i];
            }
        }
        audioSource.Play();
    }
    public void StopSound()
    {
        audioSource.Stop();
    }
}

