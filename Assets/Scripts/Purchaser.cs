using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class Purchaser : MonoBehaviour, IStoreListener
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private SaveAndLoad saveAndLoad;
    [SerializeField] private ActiveMenu activeMenu;

    private static IStoreController m_StoreController;

    public static string vip = "com.textbased.adventure.removeads";

    [Obsolete]
    private void Start()
    {
        InitializePurchasing();
        //RestoreVariable();
        //gameManager.LoadPlayer6();
    }

    [Obsolete]
    public void InitializePurchasing()
    {
        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        //Прописываем свои товары для добавления в билдер
        builder.AddProduct(vip, ProductType.NonConsumable);

        UnityPurchasing.Initialize(this, builder);
    }
    //void RestoreVariable()
    //{
    //    if (gameManager.saveGo == 1)
    //    {
    //        RemoveAds();
    //    }
    //}
    public void BuyProductID(string productName)
    {
        m_StoreController.InitiatePurchase(productName);
    }
    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {
        var product = args.purchasedProduct;

        if (product.definition.id == vip)
        {
            RemoveAds();
        }

        Debug.Log($"Purchase Complete - Product: {product.definition.id}");

        return PurchaseProcessingResult.Complete;
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        Debug.Log("In-App Purchasing successfully initialized");
        m_StoreController = controller;
        extensions.GetExtension<IAppleExtensions>().RestoreTransactions((result, message) =>
        {
            if (result)
            {
                Debug.Log("Куплено");
            }
            else
            {
                Debug.Log("Нет");
            }
        });
    }
    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log($"Purchase failed - Product: '{product.definition.id}', PurchaseFailureReason: {failureReason}");
    }
    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.Log($"In-App Purchasing initialize failed: {error}");
    }
    public void OnInitializeFailed(InitializationFailureReason error, string message)
    {
        throw new NotImplementedException();
    }
    private void RemoveAds()
    {
        FireBaseAnalyticsEvents.EventsPurchase_Successfull("Purchase_Successfull");
        gameManager.saveGo = 1;
        if (gameManager.save_buy == 1)
        {
            saveAndLoad.money.SetActive(false);
            saveAndLoad.saveSave.SetActive(true);
        }
        else if (gameManager.load_buy == 1)
        {
            saveAndLoad.money.SetActive(false);
            activeMenu.loadUI.SetActive(true);
        }
        gameManager.SavePlayer6();
    }
}
