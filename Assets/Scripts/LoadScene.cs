using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string sceneName;
    public LoadSceneMode loadMode;
    public bool isMainMenu;

    private void Awake()
    {
        
        if (isMainMenu) loadScene(sceneName, loadMode);
    }

    public void loadScene(string sceneName, LoadSceneMode loadMode)
    {
        SceneManager.LoadScene(sceneName, loadMode);
    }
}
