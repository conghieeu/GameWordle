using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BankWord : Data
{
    public RectTransform[] column;
    public string RandomWord;
    public Submit submit;
    [SerializeField] private GameObject _win;
    public Text PanelFail, PanelWin;
    public KeyWord words;
    public bool WordExist, CaseWin = false;

    private void Start()
    {
        Distribution();
    }

    public void Distribution()
    {
        print(PickWord());
        CountColumn();
    }

    public string PickWord()
    {
        int random = Mathf.RoundToInt(Random.Range(0, BankWords.Length));
        RandomWord = BankWords[random][random];

        PanelFail.text = RandomWord;
        PanelWin.text = RandomWord;

        return RandomWord;
    }

    public void CheckWord()
    {
        // doi chieu voi tu co trong danh sach
        for (int i = 0; i < BankWords.Length; i++)
        {
            for (int j = 0; j < BankWords[i].Length; j++)
            {
                if (words.word == BankWords[i][j])
                {
                    WordExist = true;
                }
            }
        }
        
        StartCoroutine(DelayWin());
    }

    IEnumerator DelayWin()
    {
        // Case win (correct the words)
        if (words.word == RandomWord)
        {
            CaseWin = true;
            yield return new WaitForSeconds(2.8f);
            submit.submitIndex -= 1;
            CurrentRatio();
            _win.SetActive(true);
            Time.timeScale = 0;
        }
    }
    
    // Lưu giá trị xem thắng ở dòng nào
    public void CurrentRatio()
    {
        if (submit.submitIndex == 0 )
        {
            PlayerPrefs.SetInt("column1", PlayerPrefs.GetInt("column1") +1);
        }
        else if (submit.submitIndex == 1)
        {
            PlayerPrefs.SetInt("column2", PlayerPrefs.GetInt("column2") +1);
        }
        else if (submit.submitIndex == 2)
        {
            PlayerPrefs.SetInt("column3", PlayerPrefs.GetInt("column3") +1);
        }
        else if (submit.submitIndex == 3)
        {
            PlayerPrefs.SetInt("column4", PlayerPrefs.GetInt("column4") +1);
        }
        else if (submit.submitIndex == 4)
        {
            PlayerPrefs.SetInt("column5", PlayerPrefs.GetInt("column5") +1);
        }
        else if (submit.submitIndex == 5)
        {
            PlayerPrefs.SetInt("column6", PlayerPrefs.GetInt("column6") +1);
        }
    }
    
    // Tính value của các cột
    public void CountColumn()
    {
        float totalValueColumn = PlayerPrefs.GetInt("column1") + PlayerPrefs.GetInt("column2") +
                               PlayerPrefs.GetInt("column3") + PlayerPrefs.GetInt("column4") +
                               PlayerPrefs.GetInt("column5") + PlayerPrefs.GetInt("column6");
        // column 1
        if (PlayerPrefs.GetInt("column1") == 0)
        {
            column[0].sizeDelta = new Vector2(50, 30);
        }
        else 
        {
            column[0].sizeDelta =  new Vector2(50,(PlayerPrefs.GetInt("column1") / totalValueColumn) * 400);
            print(column[0].sizeDelta);
        }
        
        // column 2
        if (PlayerPrefs.GetInt("column2") == 0)
        {
            column[1].sizeDelta = new Vector2(50, 30);
        }
        else
        {
            column[1].sizeDelta =  new Vector2(50,(PlayerPrefs.GetInt("column2") / totalValueColumn) * 400);
        }
        
        // column 3
        if (PlayerPrefs.GetInt("column3") == 0)
        {
            column[2].sizeDelta = new Vector2(50, 30);
        }
        else
        {
            column[2].sizeDelta =  new Vector2(50,(PlayerPrefs.GetInt("column3") / totalValueColumn) * 400);
        }
        
        // column 4
        if (PlayerPrefs.GetInt("column4") == 0)
        {
            column[3].sizeDelta = new Vector2(50, 30);
        }
        else
        {
            column[3].sizeDelta =  new Vector2(50,(PlayerPrefs.GetInt("column4") / totalValueColumn) * 400);
        }
        
        // column 5
        if (PlayerPrefs.GetInt("column5") == 0)
        {
            column[4].sizeDelta = new Vector2(50, 30);
        }
        else
        {
            column[4].sizeDelta =  new Vector2(50,(PlayerPrefs.GetInt("column5") / totalValueColumn) * 400);
        }
        
        // column 6
        if (PlayerPrefs.GetInt("column6") == 0)
        {
            column[5].sizeDelta = new Vector2(50, 30);
        }
        else
        {
            column[5].sizeDelta =  new Vector2(50,(PlayerPrefs.GetInt("column6") / totalValueColumn) * 400);
        }
    }
}

