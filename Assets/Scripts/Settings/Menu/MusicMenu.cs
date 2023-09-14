using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MusicMenu : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private MusicSound musicSound;

    public void StopMusic()
    {
        audioSource.Stop();
    }
    public void PlayMusic()
    {
        if (musicSound.music == 1)
        {
            audioSource.Play();
        }
    }
}
