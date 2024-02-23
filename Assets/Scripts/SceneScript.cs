using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public int sceneNum;

    public void GoToNextScene()
    {
        SceneManager.LoadScene(sceneNum);
    }

}
