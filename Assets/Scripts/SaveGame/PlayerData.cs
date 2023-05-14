using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public bool charter1UI;
    public bool charter2UI;
    public bool charter3UI;
    public bool charter4UI;
    public bool charter5UI;
    public bool charter6UI;
    public bool charter7UI;
    public bool charter8UI;
    public bool charter9UI;
    public bool charter10UI;
    public bool charter11UI;
    public bool charter12UI;
    public bool charter13UI;
    public bool ToBeContinued;

    public bool musicMenu;
    public bool musicCharter;
    public bool musicCamp;
    public bool musicForest;

    //public bool[] charter;

    public PlayerData(GameManager gameManager)
    {
        //for (int i = 0; i < charter.Length; i++)
        //{
        //    charter[i] = gameManager.charter[i];
        //}
        //charter[0] = gameManager.charter[0];
        //charter[1] = gameManager.charter[1];
        //charter[2] = gameManager.charter[2];
        //charter[3] = gameManager.charter[3];
        //charter[4] = gameManager.charter[4];
        charter1UI = gameManager.charter1UI;
        charter2UI = gameManager.charter2UI;
        charter3UI = gameManager.charter3UI;
        charter4UI = gameManager.charter4UI;
        charter5UI = gameManager.charter5UI;
        charter6UI = gameManager.charter6UI;
        charter7UI = gameManager.charter7UI;
        charter8UI = gameManager.charter8UI;
        charter9UI = gameManager.charter9UI;
        charter10UI = gameManager.charter10UI;
        charter11UI = gameManager.charter11UI;
        charter12UI = gameManager.charter12UI;
        charter13UI = gameManager.charter13UI;
        ToBeContinued = gameManager.ToBeContinued;

        musicMenu = gameManager.musicMenu;
        musicCharter = gameManager.musicCharter;
        musicCamp = gameManager.musicCamp;
        musicForest = gameManager.musicForest;
    }
}