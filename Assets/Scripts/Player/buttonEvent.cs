using UnityEngine;
using UnityEngine.Events;

public class buttonEvent : MonoBehaviour
{
    public UnityEvent buttonCall;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    void OnMouseDown()
    {
        buttonCall?.Invoke();
    }
}
