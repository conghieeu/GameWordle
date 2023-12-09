using UnityEngine;
using UnityEngine.UI;

public class ChangeColorBtn : MonoBehaviour
{
    public GameObject[] letter = new GameObject[26];
    public char[] key = new char[26];

    public KeyWord keyWord;

    // Đổi màu bàn phím với những chữ đã được thao tác
    public void Color()
    {
        for (int j = 0; j < 26; j++)
        {
            if (keyWord.wordCorrect == key[j])
            {
                letter[j].GetComponent<Image>().color = keyWord.CorrectColor;
            }
            else if (keyWord.wordIncorrect == key[j])
            {
                letter[j].GetComponent<Image>().color = keyWord.IncorrectColor;
            }
            else if (keyWord.wordNotExist == key[j])
            {
                letter[j].GetComponent<Image>().color = keyWord.NotExistColor;
            }
        }
    }
}