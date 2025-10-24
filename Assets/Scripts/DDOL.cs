using UnityEngine;
using UnityEngine.EventSystems;

public class DDOL : MonoBehaviour
{
    private void Awake()
    {
        var existingEventSystems = FindObjectsByType<EventSystem>(FindObjectsSortMode.None);
        if (existingEventSystems.Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }
}
