using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Suggest : MonoBehaviour
{

    [SerializeField] AdmobAdsScript admobAdsScript; 
    [SerializeField] private Animator[] _suggestEffect;
    [SerializeField] private GameObject[] _onColorKeyBoard;
    [SerializeField] private KeyWord _input;
    [SerializeField] private ChangeColorBtn _board;
    [SerializeField] private BankWord _word;
    private string _str;
    private string _wordUsed;
    private string _bankWord;
    private string _letter = "QWERTYUIOPASDFGHJKLZXCVBNM";
    private string RemoveUsedLetter1, RemoveUsedLetter2, RemoveUsedLetter3;
    public GameObject Notification;
    public UnityEngine.Color _suggestColor;
    public UnityEngine.Color _cantSuggest;
    public Color _defaultColor;
    public static Suggest Instance {get; private set;}

    string RemoveUsedLetter;

    private void Awake() {
        if (Instance) Destroy(this); else { Instance = this; }

    }

    public void SuggestButton()
    {
        _bankWord = _word.RandomWord;
        _wordUsed = _input.current0 + _input.current1 + _input.current2 + _input.current3 + _input.current4 + _input.current5 +
                   _input.current6 + _str + _bankWord;

        int count = 0;

        // Tạo danh sách chữ được loại bỏ
        List<char> exceptionsList = new List<char>();
        //print(WordUsed);
        exceptionsList.AddRange(_wordUsed);

        // Tạo màn danh sách gợi ý ban đầu
        List<char> dataList = new List<char>();
        dataList.AddRange(_letter);

        // loại bỏ các danh sách chữ gợi ý
        for (int i = 0; i < exceptionsList.Count; i++)
        {
            dataList.Remove(exceptionsList[i]);
            //print(exceptionsList[i]);
        }


        foreach (var data in dataList)
        {
            char _charRandom = dataList[Mathf.RoundToInt(Random.Range(0, dataList.Count))];

            print(_charRandom);
            if (!exceptionsList.Contains(_charRandom) && dataList.Contains(_charRandom) &&
                RemoveUsedLetter1 != _charRandom.ToString() && RemoveUsedLetter2 != _charRandom.ToString() &&
                RemoveUsedLetter3 != _charRandom.ToString())
            {
                if (count == 0)
                {
                    RemoveUsedLetter1 = _charRandom.ToString();
                }
                if (count == 1)
                {
                    RemoveUsedLetter2 = _charRandom.ToString();
                }
                if (count == 2)
                {
                    RemoveUsedLetter3 = _charRandom.ToString();
                }


                if (dataList.Count < 3) // clear
                {
                    for (int i = 0; i < dataList.Count; i++)
                    {
                        _suggestEffect[i].SetBool("Scale", true);
                        _board.letter[i].GetComponent<Image>().color = _suggestColor;
                        _str += dataList[i];
                        print("Clear: " + dataList[i]);
                    }
                    DisableButton();
                }

                _str += _charRandom.ToString();

                for (int i = 0; i < 26; i++)
                {
                    if (_charRandom == _board.key[i])
                    {
                        _suggestEffect[i].SetBool("Scale", true);
                        _board.letter[i].GetComponent<Image>().color = _suggestColor;
                    }
                }

                count++;
            }

            if (count == 3) break;
        }

        // Play Animtion Button is suggest
        foreach (var VARIABLE in _onColorKeyBoard)
        {
            if (VARIABLE.GetComponent<Image>().color != _defaultColor)
            {
                VARIABLE.GetComponent<Image>().enabled = true;
            }
        }
    }

    public void turnOnNotification()
    {
        Notification.SetActive(true);
    }

    public void TurnOffNotification()
    {
        Notification.SetActive(false);
    }

    // Nếu như Spam nút suggest hoặc đã gợi í full thì sẽ xóa nút suggest button
    public void DisableButton()
    {
        /*this.gameObject.GetComponent<Image>().color = _cantSuggest;
        Destroy(this.gameObject.GetComponent<Button>());*/
        Destroy(GameObject.FindGameObjectWithTag("suggestButton"));
    }
}