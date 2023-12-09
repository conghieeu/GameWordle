using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Submit : MonoBehaviour
{
    [SerializeField] private float TimeLoadEnd;
    [SerializeField] private GameObject Fail;
    [SerializeField] private NotOnWordList PosNotOnWordList;
    [SerializeField] private GameObject[] chanceImageLeft, chanceImageRight;
    [SerializeField] private GameObject QuangCao;
    [SerializeField] private GameObject current7;
    public bool checkActiveCurrent7;
    [SerializeField] private Animator[] EffectSubmit;
    [SerializeField] public Image cube;

    private bool animaRun1, animaRun2, animaRun3, animaRun4, animaRun5, animaRun6, animaRun7;
    
    [SerializeField] private GameObject[] onColorSquare;
    [SerializeField] private GameObject[] onColorKeyBoard;
    public int submitIndex = 0;

    private bool lastChance;

    public Resize resize;
    public Color defaultColor;
    public KeyWord KeyWord;
    public ChangeColorBtn KeyBoard;
    public BankWord CorrectWords;

    private void Start()
    {
        current7.SetActive(false);
        checkActiveCurrent7 = false;

        foreach (var VARIABLE in onColorSquare)
        {
            VARIABLE.GetComponent<Image>().enabled = false;
        }

        foreach (var VARIABLE in onColorKeyBoard)
        {
            VARIABLE.GetComponent<Image>().enabled = false;
        }
    }

    private void Update()
    {
        if (lastChance == true )
        {
            StartCoroutine(waitToEnd());
        }
    }

    private bool AddCurrent;
    public void submitButton()
    {
        CorrectWords.CheckWord();
        checkDK();

        switch (submitIndex)
        {
            case 1:
                StartCoroutine(AnimationCurrent1());
                break;
            case 2:
                StartCoroutine(AnimationCurrent2());
                break;
            case 3:
                StartCoroutine(AnimationCurrent3());
                break;
            case 4:
                StartCoroutine(AnimationCurrent4());
                break;
            case 5:
                StartCoroutine(AnimationCurrent5());
                break;
            case 6:
                StartCoroutine(AnimationCurrent6());
                StartCoroutine(eventCurrent6());
                
                break;
            case 7:
                StartCoroutine(AnimationCurrent7());
                StartCoroutine(eventCurrent7());
                break;
        }

    }

    public void checkDK()
    {
        if (KeyWord.word.Length >= 5 && CorrectWords.WordExist == true)
        {
            KeyWord.resetWord();
            submitIndex++;
            CorrectWords.WordExist = false;
        }
        else if(KeyWord.word.Length >= 5 && CorrectWords.WordExist == false)
        {
            PosNotOnWordList.Notification();
        }
    }
    

    // trường hợp nếu fail ở dòng 6 thì bật bảng đợi 5 giây
    void broadEndGame()
    {
        QuangCao.SetActive(true);
        lastChance = true;
    }

    // trường hợp đợi quá 5 giây thì đóng bảng thêm một cơ hội
    IEnumerator waitToEnd()
    {
        yield return new WaitForSeconds(TimeLoadEnd);
        if (AddCurrent == false)
        {
            QuangCao.SetActive(false);
            Fail.SetActive(true);
            submitIndex++;
            submitButton();
        }
    }

    // trường hợp nhấn vào nút thêm một cơ hội trong bảng đợi 5 giây
    public void extendingButton() // Button tang them 1 current khi nhan vao ad
    {
        resize.fixedScaleWhenCall();
        current7.SetActive(true);
        checkActiveCurrent7 = true;
        QuangCao.SetActive(false);
        AddCurrent = true;
        chanceImageRight[0].GetComponent<Image>().sprite = cube.sprite;
        chanceImageRight[1].GetComponent<Image>().sprite = cube.sprite;
        chanceImageLeft[0].GetComponent<Image>().sprite = cube.sprite;
        chanceImageLeft[1].GetComponent<Image>().sprite = cube.sprite;
    }

    #region AnimationEffect

    // current 7
    IEnumerator AnimationCurrent7()
    {
        if (animaRun7 == false)
        {
            animaRun7 = true;
            for (int i = 30; i < 35;)
            {
                EffectSubmit[i].SetBool("Rotate", true);
                CorrectWords.CheckWord();
                yield return new WaitForSeconds(0.5f);
                onColorSquare[i].GetComponent<Image>().enabled = true;
                i++;
            }

            foreach (var VARIABLE in onColorKeyBoard)
            {
                if (VARIABLE.GetComponent<Image>().color != defaultColor)
                {
                    VARIABLE.GetComponent<Image>().enabled = true;
                }
            }
        }
    }
    IEnumerator eventCurrent7()
    {
        yield return new WaitForSeconds(2.6f);
        Fail.SetActive(true);
        Time.timeScale = 0;
    }
    
    
    IEnumerator AnimationCurrent6()
    {
        if (animaRun6 == false)
        {
            animaRun6 = true;
            for (int i = 25; i < 30;)
            {
                EffectSubmit[i].SetBool("Rotate", true);
                CorrectWords.CheckWord();
                yield return new WaitForSeconds(0.5f);
                onColorSquare[i].GetComponent<Image>().enabled = true;
                i++;
            }

            foreach (var VARIABLE in onColorKeyBoard)
            {
                if (VARIABLE.GetComponent<Image>().color != defaultColor)
                {
                    VARIABLE.GetComponent<Image>().enabled = true;
                }
            }
        }
    }

    IEnumerator eventCurrent6()
    {
        if (CorrectWords.CaseWin == false)
        {
            yield return new WaitForSeconds(2.6f);

        
            if (AddCurrent == false)
            {
                broadEndGame();
            }
        }
    }

    IEnumerator AnimationCurrent5()
    {
        if (animaRun5 == false)
        {
            animaRun5 = true;
            for (int i = 20; i < 25;)
            {
                EffectSubmit[i].SetBool("Rotate", true);
                CorrectWords.CheckWord();
                yield return new WaitForSeconds(0.5f);
                onColorSquare[i].GetComponent<Image>().enabled = true;
                i++;
            }

            foreach (var VARIABLE in onColorKeyBoard)
            {
                if (VARIABLE.GetComponent<Image>().color != defaultColor)
                {
                    VARIABLE.GetComponent<Image>().enabled = true;
                }
            }

        }
    }
    
    IEnumerator AnimationCurrent4()
    {
        if (animaRun4 == false)
        {
            animaRun4 = true;
            for (int i = 15; i < 20;)
            {
                EffectSubmit[i].SetBool("Rotate", true);
                CorrectWords.CheckWord();
                yield return new WaitForSeconds(0.5f);
                onColorSquare[i].GetComponent<Image>().enabled = true;
                i++;
            }

            foreach (var VARIABLE in onColorKeyBoard)
            {
                if (VARIABLE.GetComponent<Image>().color != defaultColor)
                {
                    VARIABLE.GetComponent<Image>().enabled = true;
                }
            }
        }
    }
    IEnumerator AnimationCurrent3()
    {
        if (animaRun3 == false)
        {
            animaRun3 = true;
            for (int i = 10; i < 15;)
            {
                EffectSubmit[i].SetBool("Rotate", true);
                CorrectWords.CheckWord();
                yield return new WaitForSeconds(0.5f);
                onColorSquare[i].GetComponent<Image>().enabled = true;
                i++;
            }

            foreach (var VARIABLE in onColorKeyBoard)
            {
                if (VARIABLE.GetComponent<Image>().color != defaultColor)
                {
                    VARIABLE.GetComponent<Image>().enabled = true;
                }
            }
        }
    }
    
    IEnumerator AnimationCurrent2()
    {
        if (animaRun2 == false)
        {
            animaRun2 = true;
            for (int i = 5; i < 10;)
            {
                if (true)
                {
                    EffectSubmit[i].SetBool("Rotate", true);
                }

                CorrectWords.CheckWord();
                yield return new WaitForSeconds(0.5f);
                onColorSquare[i].GetComponent<Image>().enabled = true;
                i++;
            }

            foreach (var VARIABLE in onColorKeyBoard)
            {
                if (VARIABLE.GetComponent<Image>().color != defaultColor)
                {
                    VARIABLE.GetComponent<Image>().enabled = true;
                }
            }
        }
    }

    IEnumerator AnimationCurrent1()
    {
        if (animaRun1 == false)
        {
            animaRun1 = true;
            for (int i = 0; i < 5;)
            {
                EffectSubmit[i].SetBool("Rotate", true);
                CorrectWords.CheckWord();
                yield return new WaitForSeconds(0.5f);
                onColorSquare[i].GetComponent<Image>().enabled = true;
                i++;
            }

            foreach (var VARIABLE in onColorKeyBoard)
            {
                if (VARIABLE.GetComponent<Image>().color != defaultColor)
                {
                    VARIABLE.GetComponent<Image>().enabled = true;
                }
            }
        }
    }
    #endregion
}
