using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerIAP
{
    public int saveGo;
    public int recGo;

    //public bool[] charter;

    public PlayerIAP(GameManager gameManager)
    {
        saveGo = gameManager.saveGo;
        recGo = gameManager.recGo;
    }
}
