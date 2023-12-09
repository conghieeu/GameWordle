using UnityEngine;
using UnityEngine.UI;

public class times : MonoBehaviour
{
    public Text textTimer;
    
    public float timer = 0.0f;
    private bool isTimer = true;

    private void Start()
    {
        textTimer = GetComponent<Text>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimer)
        {
            timer += Time.deltaTime;
            DisplayTime();
        }
    }

    void DisplayTime()
    {
        float minutes = Mathf.FloorToInt(timer / 60);
        float seconds = Mathf.FloorToInt((timer % 60));
        textTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
