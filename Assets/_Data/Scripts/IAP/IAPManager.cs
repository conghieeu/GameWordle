using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Purchasing;
using GoogleMobileAds.Api;

public class IAPManager : MonoBehaviour
{
    private string RemoveAd = "com.company.namegame.product";

    public GameObject ThankYou;
    public GameObject Offer;

    public void Awake()
    {
        if (PlayerPrefs.GetString("AdRemoved") == "AdRemoved")
        {
            RemoveAdsObject();
        }
    }

    public void OnPurchaseComplete(Product product)
    {
        if (product.transactionID == RemoveAd)
        {
            RemoveAdsObject();
            PlayerPrefs.SetString("AdRemoved", "AdRemoved");

            ThankYou.SetActive(true);
            Offer.SetActive(false);
        }
    }

    public void OnAdFailedToLoad(Product product, PurchaseFailureReason args)
    {
        Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, args));
    }

    void RemoveAdsObject()
    {
        Destroy(GameObject.FindGameObjectWithTag("adPanel"));
    }
}
