using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverEvents : MonoBehaviour
{
    public void replayGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void QuitGame()
    {
        // Application.Quit();
        SceneManager.LoadScene("MainMenu");
    }
}
