using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShareButton : MonoBehaviour
{
    public Button shareButton;

    void Start()
    {
        shareButton.onClick.AddListener(OnShare);
    }

    void OnShare() {
        Debug.Log("SHARE");
    }
}