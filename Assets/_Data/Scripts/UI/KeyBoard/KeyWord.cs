using UnityEngine;
using UnityEngine.UI;

public class KeyWord : MonoBehaviour
{
    // Các dòng chữ ở trên ô
    public string current0, current1, current2, current3, current4, current5, current6;
    public Submit Submit;
    
    //public Animator[] ObjInputPressEffect;
    public GameObject[] square  = new GameObject[5];
    public GameObject[] square1 = new GameObject[5];
    public GameObject[] square2 = new GameObject[5];
    public GameObject[] square3 = new GameObject[5];
    public GameObject[] square4 = new GameObject[5];
    public GameObject[] square5 = new GameObject[5];
    public GameObject[] square6 = new GameObject[5];

    // Use to delete letter
    public Text[] Letter  = new Text[5];
    public Text[] Letter1 = new Text[5];
    public Text[] Letter2 = new Text[5];
    public Text[] Letter3 = new Text[5];
    public Text[] Letter4 = new Text[5];
    public Text[] Letter5 = new Text[5];
    public Text[] Letter6 = new Text[5];

    public BankWord bankWord;
    public ChangeColorBtn KeyBoard;
    
    public Color CorrectColor, IncorrectColor, NotExistColor;
    public char wordCorrect, wordIncorrect, wordNotExist;
    
    public string word;

    private void Start() {
        wordCorrect = ' ';
        wordIncorrect = ' ';
        wordNotExist = ' ';

    }

    public void alphabetFuncion(string alphabet)
    {
        if (word.Length <= 4)
        {
            word = word + alphabet;
            Key();
            
        }
    }
    
    public void resetWord()
    {
        // Chạy square Color ứng với tứ tự submit
        if (Submit.submitIndex == 0)
        {
            squareColor();
        }
        else if (Submit.submitIndex == 1)
        {
            squareColor1();
        }
        else if (Submit.submitIndex == 2)
        {
            squareColor2();
        }
        else if (Submit.submitIndex == 3)
        {
            squareColor3();
        }
        else if (Submit.submitIndex == 4)
        {
            squareColor4();
        }
        else if (Submit.submitIndex == 5)
        {
            squareColor5();
        }
        else if (Submit.submitIndex == 6)
        {
            squareColor6();
        }

        word = "";
    }
    
    public void deleteButton()
    {
        if (word.Length > 0)
        {
            word = word.Substring(0,word.Length-1);
            Key();
        }
    }
    
    public void Key()
    {
        // Khởi chạy khi được submit để lấy chữ hàng ngang
        switch (Submit.submitIndex)
        {
            case 0:
                current0 = word;
                break;
            case 1:
                current1 = word;
                break;
            case 2:
                current2 = word;
                break;
            case 3:
                current3 = word;
                break;
            case 4:
                current4 = word;
                break;
            case 5:
                current5 = word;
                break;
            case 6:
                if (Submit.checkActiveCurrent7 == false)
                {
                    word = "";
                }
                if (Submit.checkActiveCurrent7 == true)
                {
                    current6 = word;    
                }
                break;
        }

        AllCurrent();
    }

    // Delete letter
    public void AllCurrent()
    {
        if (Submit.submitIndex == 0)
        {
            if (current0.Length == 0)
            {
                if (current0.Length < 1)
                {
                    Letter[0].text = "";
                }
            }
            else if (current0.Length == 1)
            {
                Letter[0].text = current0.Substring(0, 1);
                if (current0.Length < 2)
                {
                    Letter[1].text = "";
                }
            }
            else if (current0.Length == 2)
            {
                Letter[1].text = current0.Substring(1,1);
                if (current0.Length < 3)
                {
                    Letter[2].text = "";
                }
            }
            else if (current0.Length == 3)
            {
                Letter[2].text = current0.Substring(2,1);
                if (current0.Length < 4)
                {
                    Letter[3].text = "";
                }
            }
            else if (current0.Length == 4)
            {
                Letter[3].text = current0.Substring(3,1);
                if (current0.Length < 5)
                {
                    Letter[4].text = "";
                }
            }
            else if (current0.Length == 5)
            {
                Letter[4].text = current0.Substring(4,1);
            }
        }
        
        else if (Submit.submitIndex == 1)
        {
            if (current1.Length == 0)
            {
                if (current1.Length < 1)
                {
                    Letter1[0].text = "";
                }
            }
            else if (current1.Length == 1)
            {
                Letter1[0].text = current1.Substring(0, 1);
                if (current1.Length < 2)
                {
                    Letter1[1].text = "";
                }
            }
            else if (current1.Length == 2)
            {
                Letter1[1].text = current1.Substring(1,1);
                if (current1.Length < 3)
                {
                    Letter1[2].text = "";
                }
            }
            else if (current1.Length == 3)
            {
                Letter1[2].text = current1.Substring(2,1);
                if (current1.Length < 4)
                {
                    Letter1[3].text = "";
                }
            }
            else if (current1.Length == 4)
            {
                Letter1[3].text = current1.Substring(3,1);
                if (current1.Length < 5)
                {
                    Letter1[4].text = "";
                }
            }
            else if (current1.Length == 5)
            {
                Letter1[4].text = current1.Substring(4,1);
            }
        }
        
        else if (Submit.submitIndex == 2)
        {
            if (current2.Length == 0)
            {
                if (current2.Length < 1)
                {
                    Letter2[0].text = "";
                }
            }
            else if (current2.Length == 1)
            {
                Letter2[0].text = current2.Substring(0, 1);
                if (current2.Length < 2)
                {
                    Letter2[1].text = "";
                }
            }
            else if (current2.Length == 2)
            {
                Letter2[1].text = current2.Substring(1,1);
                if (current2.Length < 3)
                {
                    Letter2[2].text = "";
                }
            }
            else if (current2.Length == 3)
            {
                Letter2[2].text = current2.Substring(2,1);
                if (current2.Length < 4)
                {
                    Letter2[3].text = "";
                }
            }
            else if (current2.Length == 4)
            {
                Letter2[3].text = current2.Substring(3,1);
                if (current2.Length < 5)
                {
                    Letter2[4].text = "";
                }
            }
            else if (current2.Length == 5)
            {
                Letter2[4].text = current2.Substring(4,1);
            }
        }
        
        else if (Submit.submitIndex == 3)
        {
            if (current3.Length == 0)
            {
                if (current3.Length < 1)
                {
                    Letter3[0].text = "";
                }
            }
            else if (current3.Length == 1)
            {
                Letter3[0].text = current3.Substring(0, 1);
                if (current3.Length < 2)
                {
                    Letter3[1].text = "";
                }
            }
            else if (current3.Length == 2)
            {
                Letter3[1].text = current3.Substring(1,1);
                if (current3.Length < 3)
                {
                    Letter3[2].text = "";
                }
            }
            else if (current3.Length == 3)
            {
                Letter3[2].text = current3.Substring(2,1);
                if (current3.Length < 4)
                {
                    Letter3[3].text = "";
                }
            }
            else if (current3.Length == 4)
            {
                Letter3[3].text = current3.Substring(3,1);
                if (current3.Length < 5)
                {
                    Letter3[4].text = "";
                }
            }
            else if (current3.Length == 5)
            {
                Letter3[4].text = current3.Substring(4,1);
            }
        }

        else if (Submit.submitIndex == 4)
        {
            if (current4.Length == 0)
            {
                if (current4.Length < 1)
                {
                    Letter4[0].text = "";
                }
            }
            else if (current4.Length == 1)
            {
                Letter4[0].text = current4.Substring(0, 1);
                if (current4.Length < 2)
                {
                    Letter4[1].text = "";
                }
            }
            else if (current4.Length == 2)
            {
                Letter4[1].text = current4.Substring(1,1);
                if (current4.Length < 3)
                {
                    Letter4[2].text = "";
                }
            }
            else if (current4.Length == 3)
            {
                Letter4[2].text = current4.Substring(2,1);
                if (current4.Length < 4)
                {
                    Letter4[3].text = "";
                }
            }
            else if (current4.Length == 4)
            {
                Letter4[3].text = current4.Substring(3,1);
                if (current4.Length < 5)
                {
                    Letter4[4].text = "";
                }
            }
            else if (current4.Length == 5)
            {
                Letter4[4].text = current4.Substring(4,1);
            }
        }

        else if (Submit.submitIndex == 5)
        {
            if (current5.Length == 0)
            {
                if (current5.Length < 1)
                {
                    Letter5[0].text = "";
                }
            }
            else if (current5.Length == 1)
            {
                Letter5[0].text = current5.Substring(0, 1);
                if (current5.Length < 2)
                {
                    Letter5[1].text = "";
                }
            }
            else if (current5.Length == 2)
            {
                Letter5[1].text = current5.Substring(1,1);
                if (current5.Length < 3)
                {
                    Letter5[2].text = "";
                }
            }
            else if (current5.Length == 3)
            {
                Letter5[2].text = current5.Substring(2,1);
                if (current5.Length < 4)
                {
                    Letter5[3].text = "";
                }
            }
            else if (current5.Length == 4)
            {
                Letter5[3].text = current5.Substring(3,1);
                if (current5.Length < 5)
                {
                    Letter5[4].text = "";
                }
            }
            else if (current5.Length == 5)
            {
                Letter5[4].text = current5.Substring(4,1);
            }
        }
        
        else if (Submit.submitIndex == 6)
        {
            if (current6.Length == 0)
            {
                if (current6.Length < 1)
                {
                    Letter6[0].text = "";
                }
            }
            else if (current6.Length == 1)
            {
                Letter6[0].text = current6.Substring(0, 1);
                if (current6.Length < 2)
                {
                    Letter6[1].text = "";
                }
            }
            else if (current6.Length == 2)
            {
                Letter6[1].text = current6.Substring(1,1);
                if (current6.Length < 3)
                {
                    Letter6[2].text = "";
                }
            }
            else if (current6.Length == 3)
            {
                Letter6[2].text = current6.Substring(2,1);
                if (current6.Length < 4)
                {
                    Letter6[3].text = "";
                }
            }
            else if (current6.Length == 4)
            {
                Letter6[3].text = current6.Substring(3,1);
                if (current6.Length < 5)
                {
                    Letter6[4].text = "";
                }
            }
            else if (current6.Length == 5)
            {
                Letter6[4].text = current6.Substring(4,1);
            }
        }
        
    }

    // Chèn màu vào letter ứng với mỗi letter đã check và tự động check và đổi màu bazz
    public void squareColor()
    {
        // mau gray
        for (int i = 0; i < 5; i++)
        {
            square[i].GetComponent<Image>().color = NotExistColor;
            wordNotExist = word[i];
            KeyBoard.Color();
        }
        
        // mau vang
        for (int e = 0; e < 5; e++)
        {
            for (int d = 0; d < 5; d++)
            {
                if (word[e] == bankWord.RandomWord[d])
                {
                    square[e].GetComponent<Image>().color = IncorrectColor;
                    wordIncorrect = word[e];
                    KeyBoard.Color();
                }
            }
        }
        
        // mau xanh
        for (int y = 0; y < 5; y++)
        {
            if (bankWord.RandomWord[y] == word[y])
            {
                square[y].GetComponent<Image>().color = CorrectColor;
                wordCorrect = word[y];
                KeyBoard.Color();
            }
        }
    }
    
    public void squareColor1()
    {
        // mau gray
        for (int i = 0; i < 5; i++)
        {
            square1[i].GetComponent<Image>().color = NotExistColor;
            wordNotExist = word[i];
            KeyBoard.Color();
        }
        
        // mau vang
        for (int e = 0; e < 5; e++)
        {
            for (int d = 0; d < 5; d++)
            {
                if (word[e] == bankWord.RandomWord[d])
                {
                    square1[e].GetComponent<Image>().color = IncorrectColor;
                    wordIncorrect = word[e];
                    KeyBoard.Color();
                }
            }
        }
        
        // mau xanh
        for (int y = 0; y < 5; y++)
        {
            if (bankWord.RandomWord[y] == word[y])
            {
                square1[y].GetComponent<Image>().color = CorrectColor;
                wordCorrect = word[y];
                KeyBoard.Color();
            }
        }
    }
    
    public void squareColor2()
    {
        // mau gray
        for (int i = 0; i < 5; i++)
        {
            square2[i].GetComponent<Image>().color = NotExistColor;
            wordNotExist = word[i];
            KeyBoard.Color();
        }
        
        // mau vang
        for (int e = 0; e < 5; e++)
        {
            for (int d = 0; d < 5; d++)
            {
                if (word[e] == bankWord.RandomWord[d])
                {
                    square2[e].GetComponent<Image>().color = IncorrectColor;
                    wordIncorrect = word[e];
                    KeyBoard.Color();
                }
            }
        }
        
        // mau xanh
        for (int y = 0; y < 5; y++)
        {
            if (bankWord.RandomWord[y] == word[y])
            {
                square2[y].GetComponent<Image>().color = CorrectColor;
                wordCorrect = word[y];
                KeyBoard.Color();
            }
        }
    }
    
    public void squareColor3()
    {
        // mau gray
        for (int i = 0; i < 5; i++)
        {
            square3[i].GetComponent<Image>().color = NotExistColor;
            wordNotExist = word[i];
            KeyBoard.Color();
        }
        
        // mau vang
        for (int e = 0; e < 5; e++)
        {
            for (int d = 0; d < 5; d++)
            {
                if (word[e] == bankWord.RandomWord[d])
                {
                    square3[e].GetComponent<Image>().color = IncorrectColor;
                    wordIncorrect = word[e];
                    KeyBoard.Color();
                }
            }
        }
        
        // mau xanh
        for (int y = 0; y < 5; y++)
        {
            if (bankWord.RandomWord[y] == word[y])
            {
                square3[y].GetComponent<Image>().color = CorrectColor;
                wordCorrect = word[y];
                KeyBoard.Color();
            }
        }
    }
    
    public void squareColor4()
    {
        // mau gray
        for (int i = 0; i < 5; i++)
        {
            square4[i].GetComponent<Image>().color = NotExistColor;
            wordNotExist = word[i];
            KeyBoard.Color();
        }
        
        // mau vang
        for (int e = 0; e < 5; e++)
        {
            for (int d = 0; d < 5; d++)
            {
                if (word[e] == bankWord.RandomWord[d])
                {
                    square4[e].GetComponent<Image>().color = IncorrectColor;
                    wordIncorrect = word[e];
                    KeyBoard.Color();
                }
            }
        }
        
        // mau xanh
        for (int y = 0; y < 5; y++)
        {
            if (bankWord.RandomWord[y] == word[y])
            {
                square4[y].GetComponent<Image>().color = CorrectColor;
                wordCorrect = word[y];
                KeyBoard.Color();
            }
        }
    }
    
    public void squareColor5()
    {
        // mau gray
        for (int i = 0; i < 5; i++)
        {
            square5[i].GetComponent<Image>().color = NotExistColor;
            wordNotExist = word[i];
            KeyBoard.Color();
        }
        
        // mau vang
        for (int e = 0; e < 5; e++)
        {
            for (int d = 0; d < 5; d++)
            {
                if (word[e] == bankWord.RandomWord[d])
                {
                    square5[e].GetComponent<Image>().color = IncorrectColor;
                    wordIncorrect = word[e];
                    KeyBoard.Color();
                }
            }
        }
        
        // mau xanh
        for (int y = 0; y < 5; y++)
        {
            if (bankWord.RandomWord[y] == word[y])
            {
                square5[y].GetComponent<Image>().color = CorrectColor;
                wordCorrect = word[y];
                KeyBoard.Color();
            }
        }
    }
    
    public void squareColor6()
    {
        // mau gray
        for (int i = 0; i < 5; i++)
        {
            square6[i].GetComponent<Image>().color = NotExistColor;
            wordNotExist = word[i];
            KeyBoard.Color();
        }
        
        // mau vang
        for (int e = 0; e < 5; e++)
        {
            for (int d = 0; d < 5; d++)
            {
                if (word[e] == bankWord.RandomWord[d])
                {
                    square6[e].GetComponent<Image>().color = IncorrectColor;
                    wordIncorrect = word[e];
                    KeyBoard.Color();
                }
            }
        }
        
        // mau xanh
        for (int y = 0; y < 5; y++)
        {
            if (bankWord.RandomWord[y] == word[y])
            {
                square6[y].GetComponent<Image>().color = CorrectColor;
                wordCorrect = word[y];
                KeyBoard.Color();
            }
        }
    }
    
}
