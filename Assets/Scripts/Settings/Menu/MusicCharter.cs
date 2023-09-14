using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicCharter : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip[] audioClip;
    [SerializeField] private MusicSound musicSound;

    public void StopMusic()
    {
        audioSource.Stop();
    }
    public void PlayMusic(int index)
    {
        if (musicSound.music == 1)
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
    }
}
