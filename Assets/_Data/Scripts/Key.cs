using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    [System.Serializable]
    public class State
    {
        public Color fillColor;
        public Color outlineColor;
    }

    public char _keyCode;

    public State state { get; private set; }
    public char letter { get; private set; }

    private Image fill;
    private Outline outline;
    private Animator anim;
    private Button button;

    private void Awake()
    {
        fill = GetComponent<Image>();
        outline = GetComponent<Outline>();
        button = GetComponent<Button>();
    }

    private void Start()
    {
        button.onClick.AddListener(() => Keyboard.Instance.SetKey(_keyCode));
    }

    public void SetLetter(char letter)
    {
        this.letter = letter;
        anim.Play("Type");
    }

    public void SetState(State state)
    {
        this.state = state;
        fill.color = state.fillColor;
        outline.effectColor = state.outlineColor;
        anim.Play("Submit");
    }
}
