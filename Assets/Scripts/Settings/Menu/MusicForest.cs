using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicForest : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private MusicMenu musicMenu;

    public void ForestMusicOnOff()
    {
        if (musicMenu.music == 1 && gameManager.musicForest == true)
        {
            audioSource.mute = false;
        }
        else if (musicMenu.music == 1 && gameManager.musicForest == false || musicMenu.music == 0 && gameManager.musicForest == false ||
            musicMenu.music == 0 && gameManager.musicForest == true)
        {
            audioSource.mute = true;
        }
    }

    public void ForestMusic()
    {
        if (musicMenu.music == 1 && gameManager.musicForest == false)
        {
            gameManager.musicForest = true;
            audioSource.mute = false;
        }
        else if (musicMenu.music == 1 && gameManager.musicForest == true)
        {
            gameManager.musicForest = false;
            audioSource.mute = true;
        }
        else
        {
            return;
        }
    }

    public void OffMusic()
    {
        if (gameManager.musicForest == true || gameManager.musicForest == false)
        {
            gameManager.musicForest = false;
            audioSource.mute = true;
        }
    }
}
