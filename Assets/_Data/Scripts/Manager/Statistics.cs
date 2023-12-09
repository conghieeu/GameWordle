using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    public Text playedText, winText, ratioWinText;
    public BankWord bankword;

    public void LoadDataStatistics()
    {
        playedText.text = PlayerPrefs.GetInt("Played").ToString();
        winText.text = PlayerPrefs.GetInt("Win").ToString();
        ratioWinText.text = PlayerPrefs.GetFloat("ratioWin").ToString("0%");
    }

    public void ButtonReset()
    {
        PlayerPrefs.SetInt("Played", 0);
        PlayerPrefs.SetInt("Win", 0);
        PlayerPrefs.SetInt("ratioWin", 0);
        
        // reset value of column
        PlayerPrefs.SetInt("column1", 0);
        PlayerPrefs.SetInt("column2", 0);
        PlayerPrefs.SetInt("column3", 0);
        PlayerPrefs.SetInt("column4", 0);
        PlayerPrefs.SetInt("column5", 0);
        PlayerPrefs.SetInt("column6", 0);
        
        bankword.Distribution();
    }
}
