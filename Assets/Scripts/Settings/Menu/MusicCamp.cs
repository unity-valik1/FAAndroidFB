//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class MusicCamp : MonoBehaviour
//{
//    [SerializeField] private GameManager gameManager;
//    [SerializeField] private AudioSource audioSource;
//    [SerializeField] private MusicMenu musicMenu;
//    public void CampMusicOnOff()
//    {
//        if (musicMenu.music == 1 && gameManager.musicCamp == true)
//        {
//            audioSource.mute = false;
//        }
//        else if (musicMenu.music == 1 && gameManager.musicCamp == false || musicMenu.music == 0 && gameManager.musicCamp == false ||
//            musicMenu.music == 0 && gameManager.musicCamp == true)
//        {
//            audioSource.mute = true;
//        }
//    }

//    public void CampMusic()
//    {
//        if (musicMenu.music == 1 && gameManager.musicCamp == false)
//        {
//            gameManager.musicCamp = true;
//            audioSource.mute = false;
//        }
//        else if (musicMenu.music == 1 && gameManager.musicCamp == true)
//        {
//            gameManager.musicCamp = false;
//            audioSource.mute = true;
//        }
//        else
//        {
//            return;
//        }
//    }

//    public void OffMusic()
//    {
//        if (gameManager.musicCamp == true || gameManager.musicCamp == false)
//        {
//            gameManager.musicCamp = false;
//            audioSource.mute = true;
//        }
//    }
//}
