using UnityEngine;

public class ScalerCanvas : MonoBehaviour
{
    private Canvas _canvas;
    
    private void Start()
    {
        _canvas = GetComponent<Canvas>();
    }

    private void LateUpdate()
    {
        _canvas.scaleFactor = Screen.height / Screen.width;
        print(Screen.height / Screen.width );
    }
}
