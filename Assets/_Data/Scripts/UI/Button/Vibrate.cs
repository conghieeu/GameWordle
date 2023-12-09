using UnityEngine;

public class Vibrate : MonoBehaviour
{
    public bool State = true;
    public Animator anim;

    public void Awake()
    {
        if (PlayerPrefs.GetString("StateOfVibrate") == "")
        {
            OnOffVibrate();

        }
    }

    public void Start()
    {

        if (PlayerPrefs.GetString("StateOfVibrate") == "true")
        {
            State = true;
        }
        else if (PlayerPrefs.GetString("StateOfVibrate") == "false")
        {
            State = false;
        }


        boolVibrate();
    }

    public void ButtonUpdate()
    {
        if (PlayerPrefs.GetString("StateOfVibrate") == "true")
        {
            State = true;
        }
        else
        {
            State = false;
        }

        boolVibrate();
    }

    public void OnOffVibrate()
    {
        State = !State;

        if (State)
        {
            PlayerPrefs.SetString("StateOfVibrate", "true");
        }
        else
        {
            PlayerPrefs.SetString("StateOfVibrate", "false");
        }

        boolVibrate();
    }

    public void boolVibrate()
    {
        if (!anim.isActiveAndEnabled) return;

        if (PlayerPrefs.GetString("StateOfVibrate") == "true")
        {
            anim.SetBool("Open", true);
            anim.SetBool("Close", false);
        }
        else if (PlayerPrefs.GetString("StateOfVibrate") == "false")
        {
            anim.SetBool("Close", true);
            anim.SetBool("Open", false);
        }
    }

    public void VibrateButton()
    {
        // Vibrate STATE
        if (PlayerPrefs.GetString("StateOfVibrate") == "true")
        {
            Vibrator.Vibrate();
            Vibrator.Vibrate(88);
        }
    }
}