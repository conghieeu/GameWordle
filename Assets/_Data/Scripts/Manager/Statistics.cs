using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    public Text playedText, winText, ratioWinText;

    public void LoadDataStatistics()
    {
        playedText.text = PlayerPrefs.GetInt("Played").ToString();
        winText.text = PlayerPrefs.GetInt("Win").ToString();
        ratioWinText.text = PlayerPrefs.GetFloat("ratioWin").ToString("0%");
    }

}
