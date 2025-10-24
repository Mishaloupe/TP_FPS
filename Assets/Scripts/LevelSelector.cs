using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public string loadSceneName = "LoadingScene";

    public void LoadNewScene(string name)
    {
        SceneManager.LoadScene(name);
        SceneManager.UnloadSceneAsync(gameObject.scene);
        if (name == "MainMenu")
        {
            return;
        }
        SceneManager.LoadScene(loadSceneName, LoadSceneMode.Additive);
    }
}
