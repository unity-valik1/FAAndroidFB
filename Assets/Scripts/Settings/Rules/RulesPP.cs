using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RulesPP : MonoBehaviour
{
    public int rules=0;

    private void Start()
    {
        if (PlayerPrefs.HasKey("rules"))
        {
            rules = PlayerPrefs.GetInt("rules");
        }        
        if (rules == 1)
        {
            SceneManager.LoadScene(1);
            rules= 0;
            PlayerPrefs.SetInt("rules", rules);
            PlayerPrefs.Save();
        }
        else if (rules == 0)
        {
            rules = 1;
            PlayerPrefs.SetInt("rules", rules);
            PlayerPrefs.Save();
        }
    }
}
