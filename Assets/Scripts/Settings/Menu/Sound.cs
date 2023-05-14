using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private AudioSource audioSource;

    [Header("����� � ��")]
    [Tooltip("�����")] public int sound = 1;//PP
    private void Start()
    {
        SoundSettings();
    }

    public void SoundSettings()
    {
        if (sound == 1)
        {
            audioSource.mute = false;
        }
        else
        {
            audioSource.mute = true;
        }
    }

    public void SoundButton()
    {
        audioSource.Play();
    }
}

