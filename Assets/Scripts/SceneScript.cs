using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public string sceneName;

    public void GoToNextScene()
    {
        SceneManager.LoadScene(sceneName);
    }



    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }

}
