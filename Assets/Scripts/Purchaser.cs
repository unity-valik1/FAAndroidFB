using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class Purchaser : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private SaveAndLoad saveAndLoad;
    [SerializeField] private ActiveMenu activeMenu;
    private void Start()
    {
        gameManager.LoadPlayer6();
    }
  
    public void OnPurchaseCompleted(Product product)
    {
        switch(product.definition.id)
        {
            case "com.textbased.adventure.removeads":
                RemoveAds();
                break;
        }
    }

    private void RemoveAds()
    {
        FireBaseAnalyticsEvents.EventsPurchase_Successfull("Purchase_Successfull");
        gameManager.saveGo = 1;
        if(gameManager.save_buy == 1)
        {
            saveAndLoad.money.SetActive(false);
            saveAndLoad.saveSave.SetActive(true);
        }
        else if( gameManager.load_buy == 1)
        {
            saveAndLoad.money.SetActive(false);
            activeMenu.loadUI.SetActive(true);
        }
        gameManager.SavePlayer6();
    }
    public void rrr()
    {
        FireBaseAnalyticsEvents.EventsPurchase_Continue("Purchase_Continue");
    }
}
