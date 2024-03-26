using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Player1Win()
    {
        SceneManager.LoadScene("WinScene");
    }

    public void Player2Win()
    {
        SceneManager.LoadScene("LoseScene");
    }


    public void Restart()
    {
        SceneManager.LoadScene("StartScene");
    }
}