using UnityEngine;
using UnityEngine.UI;

public class Resize : MonoBehaviour
{
    private AspectRatioFitter _resize;

    private void Start()
    {
        _resize = GetComponent<AspectRatioFitter>();
    }

    public void fixedScaleWhenCall()
    {
        _resize.aspectRatio = 0.714f;
    }
}
