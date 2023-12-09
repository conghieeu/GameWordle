using UnityEngine;

public class NotOnWordList : MonoBehaviour
{    
    [SerializeField] private GameObject Word;
    
    public void Destroy()
    {
        Destroy(gameObject);
    }

    public void Notification()
    {
        Instantiate(Word,transform);
    }
}
