using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using TMPro;
using UnityEngine.UI;

public class Employee : IComparable<Employee>
{
    public string Name { get; set; }
    public float Time { get; set; }
    public Sprite Flag { get; set; }

    public int CompareTo(Employee other)
    {
        // Alphabetic sort if salary is equal. [A to Z]
        if (this.Time == other.Time)
        {
            return this.Name.CompareTo(other.Name);
        }
        // Default to salary sort. [High to low]
        return other.Time.CompareTo(this.Time);
    }

    public override string ToString()
    {
        float minutes = Mathf.FloorToInt(this.Time / 60);
        float seconds = Mathf.FloorToInt(this.Time % 60);

        // String representation.
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}


public class Leaderboard : MonoBehaviour
{
    public Text[] GetTime;
    public Text[] GetName;
    public TextMeshProUGUI[] GetRank;
    public Image[] GetFlag;
    public GameObject[] colorRankPos;
    public UnityEngine.Color youRankColor;
    public Sprite[] flag;
    private int[] rankVirtual =
    {
        1, 2, 3, 4, 5, 6, 7, 12, 14, 15,
        16, 26, 30, 123, 192, 232, 324, 346, 454, 490,
        675, 730, 820, 920, 10503, 22790, 52032, 65460, 72044, 90235
    };

    // Update Highest Time . Call this in click (==Panel Container 1 ========

    public void SortListPlayer()
    {

        List<Employee> list = new List<Employee>();
        list.Add(new Employee() {Name = "Steve", Time = 2, Flag = flag[0]});
        list.Add(new Employee() {Name = "Janet", Time = 32f, Flag = flag[1]});
        list.Add(new Employee() {Name = "Andrew", Time = 32f, Flag = flag[2]});
        list.Add(new Employee() {Name = "Bill", Time = 1323f, Flag = flag[3]});
        list.Add(new Employee() {Name = "Lucy", Time = 235f, Flag = flag[4]});
        list.Add(new Employee() {Name = "Lucas", Time = 7f, Flag = flag[5]});
        list.Add(new Employee() {Name = "Las", Time = 4f, Flag = flag[6]});
        list.Add(new Employee() {Name = "Pin", Time = 324f, Flag = flag[7]});
        list.Add(new Employee() {Name = "Lola", Time = 543f, Flag = flag[8]});
        list.Add(new Employee() {Name = "Raymond", Time = 325f, Flag = flag[9]});
        list.Add(new Employee() {Name = "Patrick", Time = 124f, Flag = flag[10]});
        list.Add(new Employee() {Name = "Jack", Time = 542f, Flag = flag[11]});
        list.Add(new Employee() {Name = "Jerry", Time = 223f, Flag = flag[12]});
        list.Add(new Employee() {Name = "Dennis", Time = 157f, Flag = flag[13]});
        list.Add(new Employee() {Name = "Aaron", Time = 1123, Flag = flag[14]});
        list.Add(new Employee() {Name = "Jose", Time = 124f, Flag = flag[15]});
        list.Add(new Employee() {Name = "Adam", Time = 1742f, Flag = flag[16]});
        list.Add(new Employee() {Name = "Henry", Time = 351f, Flag = flag[17]});
        list.Add(new Employee() {Name = "Nathan", Time = 64f, Flag = flag[18]});
        list.Add(new Employee() {Name = "Roger", Time = 125f, Flag = flag[19]});
        list.Add(new Employee() {Name = "Christian", Time = 731f, Flag = flag[20]});
        list.Add(new Employee() {Name = "Harold", Time = 23f, Flag = flag[21]});
        list.Add(new Employee() {Name = "Sean", Time = 623f, Flag = flag[22]});
        list.Add(new Employee() {Name = "Jesse", Time = 174f, Flag = flag[23]});
        list.Add(new Employee() {Name = "Bryan", Time = 3348f, Flag = flag[24]});
        list.Add(new Employee() {Name = "Willie", Time = 3241f, Flag = flag[25]});
        list.Add(new Employee() {Name = "Logan", Time = 2341f, Flag = flag[26]});
        list.Add(new Employee() {Name = "Gabriel", Time = 1345f, Flag = flag[27]}); 
        list.Add(new Employee() {Name = "Randy", Time = 27f, Flag = flag[28]});
        list.Add(new Employee() {Name = "Logas", Time = 427f, Flag = flag[29]});
        list.Add(new Employee() {Name = "You", Time = PlayerPrefs.GetFloat("HighestTime"), Flag = flag.Last()});

        // Uses IComparable.CompareTo()
        list.Sort();
        list.Reverse();

        int stReal = 0;
        int stFake = 0;

        // Xác định vị trí xếp hạng thời gian thật của player
        foreach (var element in list)
        {
            // print(element.Time);
            if (element.Time == PlayerPrefs.GetFloat("HighestTime"))
            {
                print("Xac dinh vi tri cua You " + stReal);
                print("Số lượng người đang có trong danh sách thật là: " + list.Count);
                PlayerPrefs.SetInt("yourRealSt", stReal);
            }

            stReal++;
        }

        // Uses Employee.ToString 
        foreach (var element in list)
        {
            if (PlayerPrefs.GetString("CheckPoint") == "true")
            {
                #region thuật toán sắp xếp vị trí của player trên bảng xếp hạng ảo cho player thấy

                // player nằm ở vị trí từ 1 đến 6
                if (PlayerPrefs.GetInt("yourRealSt") < 7)
                {
                    // Sắp xếp như bt từ 1 đến 6
                    GetName[stFake].text = element.Name;
                    GetTime[stFake].text = element.ToString();
                    GetRank[stFake].text = rankVirtual[stFake].ToString();
                    GetFlag[stFake].sprite = element.Flag;

                    colorRankPos[PlayerPrefs.GetInt("yourRealSt")].GetComponent<Image>().color = youRankColor; 
                    
                    // vị trí cuối lấy người chơi cuối
                    GetFlag[7].sprite = list.Last().Flag;
                    GetName[7].text = list.Last().Name;
                    GetTime[7].text = string.Format("{0:00}:{1:00}",
                        Mathf.FloorToInt(list.Last().Time / 60),
                        Mathf.FloorToInt(list.Last().Time % 60));
                    GetRank[7].text = rankVirtual.Last().ToString();
                    if (stFake == 6)
                    {
                        break;
                    }
                }

                // các trường hợp player nằm ở vị trí ở 7
                else if (PlayerPrefs.GetInt("yourRealSt") >= 7 && PlayerPrefs.GetInt("yourRealSt") < list.Count - 1)
                {
                    print("các trường hợp player nằm ở vị trí ở 7");
                    GetName[stFake].text = element.Name;
                    GetTime[stFake].text = element.ToString();
                    GetRank[stFake].text = rankVirtual[stFake].ToString();
                    GetFlag[stFake].sprite = element.Flag;

                    GetFlag[4].sprite = list[PlayerPrefs.GetInt("yourRealSt") - 2].Flag;
                    GetName[4].text = list[PlayerPrefs.GetInt("yourRealSt") - 2].Name;
                    GetTime[4].text = string.Format("{0:00}:{1:00}",
                        Mathf.FloorToInt(list[PlayerPrefs.GetInt("yourRealSt") - 2].Time / 60),
                        Mathf.FloorToInt(list[PlayerPrefs.GetInt("yourRealSt") - 2].Time % 60));
                    GetRank[4].text = (rankVirtual[PlayerPrefs.GetInt("yourRealSt")] - 2).ToString();

                    GetFlag[5].sprite = list[PlayerPrefs.GetInt("yourRealSt") - 1].Flag;
                    GetName[5].text = list[PlayerPrefs.GetInt("yourRealSt") - 1].Name;
                    GetTime[5].text = string.Format("{0:00}:{1:00}",
                        Mathf.FloorToInt(list[PlayerPrefs.GetInt("yourRealSt") - 1].Time / 60),
                        Mathf.FloorToInt(list[PlayerPrefs.GetInt("yourRealSt") - 1].Time % 60));
                    GetRank[5].text = (rankVirtual[PlayerPrefs.GetInt("yourRealSt")] - 1).ToString();

                    GetFlag[6].sprite = list[PlayerPrefs.GetInt("yourRealSt")].Flag;
                    GetName[6].text = list[PlayerPrefs.GetInt("yourRealSt")].Name;
                    GetTime[6].text = string.Format("{0:00}:{1:00}",
                        Mathf.FloorToInt(list[PlayerPrefs.GetInt("yourRealSt")].Time / 60),
                        Mathf.FloorToInt(list[PlayerPrefs.GetInt("yourRealSt")].Time % 60));
                    GetRank[6].text = rankVirtual[PlayerPrefs.GetInt("yourRealSt")].ToString();
                    
                    GetFlag[7].sprite = list.Last().Flag;
                    GetName[7].text = list.Last().Name;
                    GetTime[7].text = string.Format("{0:00}:{1:00}",
                        Mathf.FloorToInt(list.Last().Time / 60),
                        Mathf.FloorToInt(list.Last().Time % 60));
                    GetRank[7].text = rankVirtual.Last().ToString();

                    colorRankPos[6].GetComponent<Image>().color = youRankColor; 
                    
                    if (stFake == 3)
                    {
                        break;
                    }
                }

                // vị trí sếp hạng của player khi chưa có điểm
                else if (PlayerPrefs.GetFloat("HighestTime") == 99999)
                {
                    print("vị trí sếp hạng của player khi chưa có điểm");
                    GetName[stFake].text = element.Name;
                    GetTime[stFake].text = element.ToString();
                    GetRank[stFake].text = rankVirtual[stFake].ToString();
                    GetFlag[stFake].sprite = element.Flag;
                    
                    GetFlag[7].sprite = list.Last().Flag;
                    GetName[7].text = "You";
                    GetTime[7].text = "--";
                    GetRank[7].text = rankVirtual.Last().ToString();
                    
                    colorRankPos[7].GetComponent<Image>().color = youRankColor; 
                    
                    if (stFake == 6)
                    {
                        break;
                    }
                }
                
                // player nằm ở vị trí thứ 8
                else if (PlayerPrefs.GetInt("yourRealSt") >= list.Count - 1)
                {
                    GetName[stFake].text = element.Name;
                    GetTime[stFake].text = element.ToString();
                    GetRank[stFake].text = rankVirtual[stFake].ToString();
                    GetFlag[stFake].sprite = element.Flag;
                    
                    GetFlag[7].sprite = list.Last().Flag;
                    GetName[7].text = list.Last().Name;
                    GetTime[7].text = string.Format("{0:00}:{1:00}",
                        Mathf.FloorToInt(list[PlayerPrefs.GetInt("yourRealSt")].Time / 60),
                        Mathf.FloorToInt(list[PlayerPrefs.GetInt("yourRealSt")].Time % 60));
                    GetRank[7].text = rankVirtual.Last().ToString();

                    colorRankPos[7].GetComponent<Image>().color = youRankColor; 
                    
                    print("player nằm ở vị trí thứ 8");

                    if (stFake == 6)
                    {
                        break;
                    }
                }
                #endregion
            }
            
            stFake++;
            if (stFake == 8)
            {
                break;
            }
        }
    }
}

