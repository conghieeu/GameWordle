using UnityEngine;

public class SoundButton : MonoBehaviour
{
    public bool state;
    public Animator anim;
    public AudioSource _audio;

    public void Awake()
    {
        if (PlayerPrefs.GetString("StateOfSound") == "")
        {
            OnOffSound();
        }
    }

    public void Start()
    {
        if (PlayerPrefs.GetString("StateOfSound") == "true")
        {
            state = true;
        }
        else if (PlayerPrefs.GetString("StateOfSound") == "false")
        {
            state = false;
        }

        boolSound();
    }

    public void ButtonUpdate()
    {
        // Get Data
        if (PlayerPrefs.GetString("StateOfSound") == "true")
        {
            state = true;
        }
        else if (PlayerPrefs.GetString("StateOfSound") == "false")
        {
            state = false;
        }

        boolSound();
    }
    public void OnOffSound()
    {

        state = !state;

        if (state)
        {
            PlayerPrefs.SetString("StateOfSound", "true");
        }
        else
        {
            PlayerPrefs.SetString("StateOfSound", "false");
        }

        boolSound();
    }

    private void boolSound()
    {
        if (!anim.isActiveAndEnabled) return;

        // lưu trạng thái của sound
        if (PlayerPrefs.GetString("StateOfSound") == "true")
        {
            anim.SetBool("Open", true);
            anim.SetBool("Close", false);
            _audio.enabled = true;
        }
        else if (PlayerPrefs.GetString("StateOfSound") == "false")
        {
            anim.SetBool("Close", true);
            anim.SetBool("Open", false);
            _audio.enabled = false;
        }
    }
}
