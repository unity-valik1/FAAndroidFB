using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.iOS;

public class RateUsTwo : MonoBehaviour
{
    public void AndroidRateUs()
    {
        Application.OpenURL("market://details?id=" + Application.identifier);
    }

    public void IOsRateUs()
    {
        Application.OpenURL("itms-apps://itunes.apple.com/app/6446098007");
    }

    //public void RateUsiOs()
    //{
    //    Device.RequestStoreReview();
    //}
}
