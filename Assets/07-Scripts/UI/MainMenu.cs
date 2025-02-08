using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Change Scene
    public void StartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
