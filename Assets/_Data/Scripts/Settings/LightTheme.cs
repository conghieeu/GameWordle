using UnityEngine;
using UnityEngine.UI;

public class LightTheme : MonoBehaviour
{
    public Animator anim;
    public GameObject DeleteButton;

    public GameObject[] Square;
    public GameObject[] Text;
    public GameObject[] Key;
    public GameObject[] Text_KeyBroad;
    public GameObject[] otherObj;

    public UnityEngine.Color[] NewSquareColor;
    public UnityEngine.Color[] DefaultSquareColor;

    public UnityEngine.Color[] NewObjColor;
    public UnityEngine.Color[] DefaultColor;

    public UnityEngine.Color[] KeyBoardColor;
    public UnityEngine.Color[] DefaultKeyColor;
    private bool Theme;

    public void Start()
    {
        stateTheme();
    }

    public void ButtonUpdate()
    {
        if (PlayerPrefs.GetString("StateOfLightTheme") == "true")
        {
            Theme = true;
        }
        else if (PlayerPrefs.GetString("StateOfLightTheme") == "false")
        {
            Theme = false;
        }

        boolTheme();
    }

    public void PressButtonLightTheme()
    {
        Theme = !Theme;

        boolTheme();
    }

    public void boolTheme()
    {
        if (Theme)
        {
            anim.SetBool("Open", true);
            anim.SetBool("Close", false);
            PlayerPrefs.SetString("StateOfLightTheme", "true");
        }
        else
        {
            anim.SetBool("Close", true);
            anim.SetBool("Open", false);
            PlayerPrefs.SetString("StateOfLightTheme", "false");
        }

        stateTheme();
    }

    public void stateTheme()
    {
        #region set Light Theme

        if (PlayerPrefs.GetString("StateOfLightTheme") == "true")
        {
            DeleteButton.GetComponent<Image>().color = KeyBoardColor[0];
            for (int i = 0; i < Key.Length; i++)
            {
                Key[i].GetComponent<Image>().color = KeyBoardColor[0];
            }

            // Text In keyboard 
            Text_KeyBroad[26].GetComponent<Image>().color = NewSquareColor[1];
            for (int i = 0; i < Text_KeyBroad.Length - 1; i++)
            {
                Text_KeyBroad[i].GetComponent<Text>().color = NewSquareColor[1];
            }

            // đặt các panel khác màu mới
            for (int j = 0; j < otherObj.Length; j++)
            {
                otherObj[j].GetComponent<Image>().color = NewObjColor[j];
            }

            for (int j = 0; j < Square.Length; j++)
            {
                Square[j].GetComponent<Image>().color = NewSquareColor[0];
                Text[j].GetComponent<Text>().color = NewSquareColor[1];
            }

        }

        else if (PlayerPrefs.GetString("StateOfLightTheme") == "false")
        {
            DeleteButton.GetComponent<Image>().color = DefaultKeyColor[0];

            for (int i = 0; i < Key.Length; i++)
            {
                Key[i].GetComponent<Image>().color = DefaultKeyColor[0];
            }

            // Text In keyboard 
            Text_KeyBroad[26].GetComponent<Image>().color = DefaultSquareColor[1];
            for (int i = 0; i < Text_KeyBroad.Length - 1; i++)
            {
                Text_KeyBroad[i].GetComponent<Text>().color = DefaultSquareColor[1];
            }

            // đặt các panel lại màu mặc định
            for (int i = 0; i < otherObj.Length; i++)
            {
                otherObj[i].GetComponent<Image>().color = DefaultColor[i];
            }

            for (int i = 0; i < Square.Length; i++)
            {
                Square[i].GetComponent<Image>().color = DefaultSquareColor[0];
                Text[i].GetComponent<Text>().color = DefaultSquareColor[1];
            }

        }

        #endregion
    }
}
