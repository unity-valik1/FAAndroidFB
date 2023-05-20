using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateUsTwo : MonoBehaviour
{
    public void AndroidRateUs()
    {
        Application.OpenURL("market://details?id=" + Application.identifier);
    }
}
