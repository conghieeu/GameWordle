using UnityEngine;
using UnityEngine.UI;

public class ManagerButton : MonoBehaviour
{
    public bool boolTheme = false;

    public void InputTheme()
    {
        boolTheme = !boolTheme;
    }
    
    // Color in button Settings
    public UnityEngine.Color[] effectButton;
    public GameObject ThemeSetting;
    public GameObject HapicSetting;
    public GameObject SoundSetting;

    public Vibrate vibrateButton;
    public SoundButton soundButton;
    //public Vibrate vibrateButton;

    private void Start()
    {
        ThemeButtonSetting();
        HapicButtonSetting();
        SoundButtonSetting();
    }

    public void Awake()
    {
        ThemeSetting.GetComponent<Image>().color = effectButton[0];
    }

    public void ThemeButtonSetting()
    {
        if (boolTheme)
        {
            ThemeSetting.GetComponent<Image>().color = effectButton[1];
        }
        else
        {
            ThemeSetting.GetComponent<Image>().color = effectButton[0];
        }
    }

    public void HapicButtonSetting()
    {
        if (vibrateButton.State)
        {
            HapicSetting.GetComponent<Image>().color = effectButton[1];
        }
        else
        {
            HapicSetting.GetComponent<Image>().color = effectButton[0];
        }
    }
    
    public void SoundButtonSetting()
    {
        if (soundButton.state)
        {
            SoundSetting.GetComponent<Image>().color = effectButton[1];
        }
        else
        {
            SoundSetting.GetComponent<Image>().color = effectButton[0];
        }
    }
}
