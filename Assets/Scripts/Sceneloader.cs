using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    GameSession gameSession;

    private void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
    }

    public void LoadNextScene()
    {
        // I want to save the current scene index in a variable
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // And then I want to use that variable to load the scene AFTER it
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadMainMenu()
    {
        gameSession.ResetGame();
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        // Only works in built version of game, not in editor
        Debug.Log("Quitting game!");
        Application.Quit();
    }
}