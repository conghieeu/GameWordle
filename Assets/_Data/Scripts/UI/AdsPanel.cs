using UnityEngine;

public class AdsPanel : MonoBehaviour 
{
  
    public GameObject OnOffer;
    public GameObject OffOffer;
    public GameObject OffPanel;

    public void OnPanelOffer()
    {
        OnOffer.SetActive(true);
        OffPanel.SetActive(false);
    }

    public void OffTheOffer()
    {
        OffOffer.SetActive(false);
    }
}
