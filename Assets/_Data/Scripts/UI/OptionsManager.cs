using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    public GameObject OptionsPanel;
    // public GameObject shopPanel;

    private bool _activeOptions;
    private bool _activeShopButton;
    private bool _activePause;

    public Image PauseImg;
    public Text PauseText;
    public Sprite[] pauseImage;

    public void OptionsButton()
    {
        OptionsPanel.SetActive(true);
    }
    public void offPanel()
    {
        OptionsPanel.SetActive(false);
    }

    // public void ShopButton()
    // {
    //     bool activeShopButton = false;
    //
    //     activeShopButton = !activeShopButton;
    //     
    //     if (activeShopButton)
    //     {
    //         shopPanel.SetActive(true);
    //     }
    //     else
    //     {
    //         shopPanel.SetActive(false);
    //     }
    // }

    public void ExitButton()
    {
        Application.Quit();
        OptionsPanel.SetActive(false);
    }

    public void Restart()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }

    public void Pause()
    {
        _activePause = !_activePause;

        if (_activePause)
        {
            PauseImg.sprite = pauseImage[0];
            Time.timeScale = 0;
            PauseText.text = "Pause";
        }
        else
        {
            PauseImg.sprite = pauseImage[1];
            Time.timeScale = 1;
            PauseText.text = "Start";
        }
        
    }
}
