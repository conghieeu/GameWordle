using UnityEngine;

public class EffectSubmit : MonoBehaviour
{
    private Animator _animator;
    
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void endAnimationSquare()
    {
        _animator.SetBool("Rotate",false);
        _animator.SetBool("Scale",false);
    }
}
