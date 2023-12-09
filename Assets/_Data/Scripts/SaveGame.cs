using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    
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
    }
}
