using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class SaveName : MonoBehaviour
{
    [SerializeField] private TMP_Text[] textButton;
    [SerializeField] private int[] numberButton;
    [SerializeField] public string nameSave;
    [SerializeField] private SaveAndLoad saveAndLoad;
    public void NameSave(int index)
    {
        for (int i = 0; i < numberButton.Length; i++)
        {
            if (numberButton[i] == index)
            {
                nameSave = textButton[i].text;
                PlayerPrefs.SetString("nameSave", nameSave);
                PlayerPrefs.Save();
                return;
            }
        }
    }
    public void NewGameNameSave()
    {
        nameSave = "New Game";
        PlayerPrefs.SetString("nameSave", nameSave);
        PlayerPrefs.Save();
    } 
    public void ContinueNameSave()
    {
        if (PlayerPrefs.HasKey("nameSave"))
        {
            nameSave = PlayerPrefs.GetString("nameSave");
        }
    }
    public void NowLoadName1()
    {
        nameSave = saveAndLoad.nameLocation1Load.text;
        PlayerPrefs.SetString("nameSave", nameSave);
        PlayerPrefs.Save();
    }
    public void NowLoadName2()
    {
        nameSave = saveAndLoad.nameLocation2Load.text;
        PlayerPrefs.SetString("nameSave", nameSave);
        PlayerPrefs.Save();
    }
    public void NowLoadName3()
    {
        nameSave = saveAndLoad.nameLocation3Load.text;
        PlayerPrefs.SetString("nameSave", nameSave);
        PlayerPrefs.Save();
    }
    public void NowLoadName4()
    {
        nameSave = saveAndLoad.nameLocation4Load.text;
        PlayerPrefs.SetString("nameSave", nameSave);
        PlayerPrefs.Save();
    }
    public void NowLoadName5()
    {
        nameSave = saveAndLoad.nameLocation5Load.text;
        PlayerPrefs.SetString("nameSave", nameSave);
        PlayerPrefs.Save();
    }

}
