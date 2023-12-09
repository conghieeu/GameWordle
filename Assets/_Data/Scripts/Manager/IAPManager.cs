using UnityEngine;
// using UnityEditor.Purchasing;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using GoogleMobileAds.Api;

public class IAPManager : MonoBehaviour
{
    // private string RemoveAd = "com.company.namegame.product";

    public GameObject ThankYou;
    public GameObject Offer;

    public void Awake()
    {
        if (PlayerPrefs.GetString("AdRemoved") == "AdRemoved")
        {
            RemoveAdsObject();
        }
    }

    // public void OnPurchaseComplete(Product product)
    // {
    //     if (product.id == RemoveAd)
    //     {
    //         RemoveAdsObject();
    //         PlayerPrefs.SetString("AdRemoved", "AdRemoved");

    //         ThankYou.SetActive(true);
    //         Offer.SetActive(false);
    //     }
    // }

    public void OnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        LoadAdError loadAdError = args.LoadAdError;

        // Gets the domain from which the error came.
        string domain = loadAdError.GetDomain();

        // Gets the error code. See
        // https://developers.google.com/android/reference/com/google/android/gms/ads/AdRequest
        // and https://developers.google.com/admob/ios/api/reference/Enums/GADErrorCode
        // for a list of possible codes.
        int code = loadAdError.GetCode();

        // Gets an error message.
        // For example "Account not approved yet". See
        // https://support.google.com/admob/answer/9905175 for explanations of
        // common errors.
        string message = loadAdError.GetMessage();

        // Gets the cause of the error, if available.
        AdError underlyingError = loadAdError.GetCause();

        // All of this information is available via the error's toString() method.
        Debug.Log("Load error string: " + loadAdError.ToString());

        // Get response information, which may include results of mediation requests.
        ResponseInfo responseInfo = loadAdError.GetResponseInfo();
        Debug.Log("Response info: " + responseInfo.ToString());
    }
    
    void RemoveAdsObject()
    {
        Destroy(GameObject.FindGameObjectWithTag("adPanel"));
    }
}
