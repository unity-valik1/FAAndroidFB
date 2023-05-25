using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulesPP : MonoBehaviour
{
    public int rules=0;

    public void RulesGo()
    {
        rules = 1;
        PlayerPrefs.SetInt("rules", rules);
        PlayerPrefs.Save();
    }
    public void RulesNo()
    {
        rules = 0;
        PlayerPrefs.SetInt("rules", rules);
        PlayerPrefs.Save();
    }
}
