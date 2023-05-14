using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicCharter : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private AudioSource[] audioSource;
    [SerializeField] private MusicMenu musicMenu;

    //public float startVolume = 0f;
    //public float endVolume = 1f;
    //public float duration = 0.1f;

    //private float timer = 0f;

    private void Start()
    {
        audioSource[0].Stop();
        audioSource[1].Stop();
        //audioSource.Stop();
    }

    public void CharterMusicOnOff()
    {
        if (musicMenu.music == 1 && gameManager.musicCharter == true)
        {
            int a = Random.Range(0, 2);
            if (a == 0)
            {
                audioSource[0].Play();
            }
            else if (a == 1)
            {
                audioSource[1].Play();
            }
            //audioSource.Play();
        }
        else if (musicMenu.music == 1 && gameManager.musicCharter == false || musicMenu.music == 0 && gameManager.musicCharter == false ||
            musicMenu.music == 0 && gameManager.musicCharter == true)
        {
            audioSource[0].Stop();
            audioSource[1].Stop();
            //audioSource.Stop();
        }
    }

    public void CharterMusic()
    {
        if (musicMenu.music == 1 && gameManager.musicCharter == false)
        {
            gameManager.musicCharter = true;

            int a = Random.Range(0, 2);
            if (a == 0)
            {
                audioSource[0].Play();
            }
            else if (a == 1)
            {
                audioSource[1].Play();
            }
            //audioSource.Play();
        }
        else if (musicMenu.music == 1 && gameManager.musicCharter == true)
        {
            gameManager.musicCharter = false;
            audioSource[0].Stop();
            audioSource[1].Stop();
            //audioSource.Stop();
        }
        else
        {
            return;
        }
    }
}
