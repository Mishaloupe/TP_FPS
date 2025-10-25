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
            // Vérifie si la scène n'est PAS déjà chargée avant de la recharger
            if (!IsSceneLoaded(sceneName))
            {
                loadSceneManager.loadScene(sceneName, loadMode);
            }
        }
    }

    private bool IsSceneLoaded(string name)
    {
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            if (scene.name == name)
                return true;
        }
        return false;
    }
}
