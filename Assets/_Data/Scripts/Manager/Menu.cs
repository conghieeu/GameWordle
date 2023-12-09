using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject settingPanel, statistics, leaderboard, howToPlay, adPanel, failPanel;
    public times Time;
    public RectTransform posTutorialPanel;


    private void Start()
    {
        StartupTheGame();
    }

    // SETTINGS
    public void OnSetting()
    {
        settingPanel.SetActive(true);
    }

    public void OffSetting()
    {
        settingPanel.SetActive(false);
    }


    // STATISTICS
    public void OnStatistics()
    {
        statistics.SetActive(true);
    }

    public void OffStatistics()
    {
        statistics.SetActive(false);
    }


    // LEADERBOARD
    public void OnLeaderboard()
    {
        leaderboard.SetActive(true);
    }

    public void OffLeaderboard()
    {
        leaderboard.SetActive(false);
    }
    
    // HowToPlay (Tutorial)
    public void OnHowToPlay()
    {
        howToPlay.SetActive(true);
        //settingPanel.SetActive(false);
        GoogleAdsManager.FindObjectOfType<GoogleAdsManager>().DestroyBannerView();
    }

    public void OffHowToPlay()
    {
        howToPlay.SetActive(false);
        GoogleAdsManager.FindObjectOfType<GoogleAdsManager>().CreateBannerView();
    }

    // Button exit Co hoi
    public void ExitChance()
    {
        adPanel.SetActive(false);
        failPanel.SetActive(true);
    }

    // Khởi động hướng dẫn người chơi một lần duy nhất khi khởi động
    public GameObject StartUpObj;

    public void StartupTheGame()
    {
        if (PlayerPrefs.GetString("HowToPlayOnGame") != "true")
        {
            StartUpObj.SetActive(true);
            PlayerPrefs.SetFloat("HighestTime", 99999);
            PlayerPrefs.SetString("CheckPoint", "true");
            PlayerPrefs.SetString("HowToPlayOnGame", "true");
            GoogleAdsManager.FindObjectOfType<GoogleAdsManager>().DestroyBannerView();
        }
    }

    #region Update Statistics

    // Play agent button
    public void CaseLoseBtn()
    {
        // số màn đã chơi
        PlayerPrefs.SetInt("Played", PlayerPrefs.GetInt("Played") + 1);

        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

        CaculaRatio();
    }

    public void CaseWinBtn()
    {
        // Check point người chơi đã có điểm
        PlayerPrefs.SetString("CheckPoint", "true");

        // Lưu số màn chơi
        PlayerPrefs.SetInt("Played", PlayerPrefs.GetInt("Played") + 1);

        // Lưu số màn thắng
        PlayerPrefs.SetInt("Win", PlayerPrefs.GetInt("Win") + 1);

        CaculaRatio();

        // Lưu số điểm thắng
        if (Time.timer < PlayerPrefs.GetFloat("HighestTime"))
            PlayerPrefs.SetFloat("HighestTime", Time.timer);
    }

    public void CaculaRatio()
    {
        // Tính tỉ lệ thắng
        float win = PlayerPrefs.GetInt("Win");
        float played = PlayerPrefs.GetInt("Played");
        float ratioWin = win / played;
        PlayerPrefs.SetFloat("ratioWin", ratioWin);
    }

    #endregion

    // reset and Setup the game 
    public void ResetAll()
    {
        PlayerPrefs.SetFloat("HighestTime", 99999);
        PlayerPrefs.SetString("CheckPoint", "true");
        PlayerPrefs.SetString("HowToPlayOnGame", "false");
        
        // reset value of column
        PlayerPrefs.SetInt("column1", 0);
        PlayerPrefs.SetInt("column2", 0);
        PlayerPrefs.SetInt("column3", 0);
        PlayerPrefs.SetInt("column4", 0);
        PlayerPrefs.SetInt("column5", 0);
        PlayerPrefs.SetInt("column6", 0);
        
        // Cai setting mac dinh
        PlayerPrefs.SetString("StateOfSound", "true");
        PlayerPrefs.SetString("StateOfVibrate", "true");
        PlayerPrefs.SetString("StateOfLightTheme", "false");

        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
}