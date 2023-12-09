using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class ErrorWifi : MonoBehaviour
{
    public GameObject errorPanel;
    public GameObject Notification;
    public GameObject OneMoreChance;
    public GameObject OfferPanel;
    
    /// <summary> Kiểm tra wifi cho bật không </summary>
    public bool CheckInternet()
    {
        if(Application.internetReachability == NetworkReachability.NotReachable)
        {
            errorPanel.SetActive(true);
            Notification.SetActive(false);
            OneMoreChance.SetActive(false);
            OfferPanel.SetActive(false);
            return false;
        }

        return true;
    }
}
