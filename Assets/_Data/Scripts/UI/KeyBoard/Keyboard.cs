using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
    public static Keyboard Instance;

    public static char _key { get; private set; }

    private void Awake()
    {
        if (Instance) Destroy(this); else { Instance = this; }
    }

    public void SetKey(char key)
    {
        _key = key;
    }
}