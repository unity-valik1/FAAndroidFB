using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MusicMenu : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private AudioSource audioSource;

    [Header("Музыка в РР")]
    [Tooltip("Музыка")] public int music = 1;//PP


    //public float startVolume = 0f;
    //public float endVolume = 1f;
    //public float duration = 0.1f;

    //private float timer = 0f;


    //private void Start()
    //{
    //    audioSource.volume = startVolume;
    //}
    //void Update()
    //{
    //    timer += Time.deltaTime;
    //    audioSource.volume = Mathf.Lerp(startVolume, endVolume, timer / duration);
    //}
    public void MenuMusicOnOff()
    {
        if (music == 1 && gameManager.musicMenu == true)
        {
            //timer = 0f;
            //audioSource.mute = false;
            audioSource.Play();
        }
        else if (music == 1 && gameManager.musicMenu == false || music == 0 && gameManager.musicMenu == false ||
            music == 0 && gameManager.musicMenu == true)
        {
            //audioSource.mute = true;
            audioSource.Stop();
        }
    }

    public void MenuMusicStart()
    {
        if (music == 1)
        {
            //timer = 0f;
            gameManager.musicMenu = true;
            //audioSource.mute = false;
            audioSource.Play();
        }
        else
        {
            gameManager.musicMenu = false;
            //audioSource.mute = true;
            audioSource.Stop();
        }
    }

    public void MenuMusic()
    {
        if (music == 1 && gameManager.musicMenu == true)
        {
            gameManager.musicMenu = false;
            //audioSource.mute = true;
            audioSource.Stop();
        }
        else if (music == 1 && gameManager.musicMenu == false)
        {
            //timer = 0f;
            gameManager.musicMenu = true;
            //audioSource.mute = false;
            audioSource.Play();
        }
        else
        {
            return;
        }
    }
}
