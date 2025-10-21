using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class OpenLevelSelector : MonoBehaviour
{
    public LoadScene loadSceneManager;
    public string sceneName;
    public LoadSceneMode loadMode;
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            loadSceneManager.loadScene(sceneName, loadMode);
        }
    }
}
