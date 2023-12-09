using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class APIhowToPlay : MonoBehaviour, IDragHandler, IEndDragHandler
{
    // void OnMouseDrag()
    // {
    //     transform.position = GetMousePos();
    // }
    //
    // Vector3 GetMousePos()
    // {
    //     var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //     mousePos.z = 0;
    //     mousePos.y = 0;
    //     return mousePos;
    // }
    //
    // public void OnEndDrag(PointerEventData eventData)
    // {
    //     transform.localPosition = Vector3.zero;
    // }

    private Vector3 panelLocation;
    public float percentThreshold = 0.2f;
    public float easing = 0.5f;
    private int currentChild;
    public HorizontalLayoutGroup layout;
    private Image _image;
    private PointerEventData _lastPointerData;
    public static APIhowToPlay resetPos;

    private void Start()
    {
        _image = GetComponent<Image>();
        panelLocation = transform.position;
        int x = (int) -_image.rectTransform.rect.width;
        layout.GetComponent<HorizontalLayoutGroup>().padding.right = x;
    }

    public void OnDrag(PointerEventData eventData)
    {
        _lastPointerData = eventData;
        float defference = eventData.pressPosition.x - eventData.position.x;
        transform.position = panelLocation - new Vector3(defference, 0, 0);
        resetPos = this;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
        float percentage = (eventData.pressPosition.x - eventData.position.x) / Screen.width;
        if (Mathf.Abs(percentage) >= percentThreshold)
        {
            Vector3 newLocation = panelLocation;
            if (percentage > 0 && currentChild < transform.childCount - 1)
            {
                newLocation += new Vector3(-Screen.width, 0, 0);
                currentChild++;
            }
            else if (percentage < 0 && currentChild > 0)
            {
                newLocation += new Vector3(Screen.width, 0, 0);
                currentChild--;
            }

            StartCoroutine(SmoothMove(transform.position, newLocation, easing));
            panelLocation = newLocation;
        }
        else
        {
            StartCoroutine(SmoothMove(transform.position, panelLocation, easing));
        }
        // _lastPointerData = null;
        // _lastPointerData.pointerDrag = newLocation;
    }

    IEnumerator SmoothMove(Vector3 startpos, Vector3 endpos, float seconds)
    {
        float t = 0f;
        while (t <= 1.0)
        {
            t += Time.deltaTime / seconds;
            transform.position = Vector3.Lerp(startpos, endpos, Mathf.SmoothStep(0f, 1f, t));
            yield return null;
        }
    }
}

    



