using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    private int randomSceneNum;

    public void Start()
    {
        int randomSceneNum = Random.Range(0, 7); //goes to 6

    }

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

    public void RandomScene()
    {
        if (randomSceneNum == 0)
        {

        }
        else if (randomSceneNum == 1)
        {

        }
        else if (randomSceneNum == 2)
        {

        }
        else if (randomSceneNum == 3)
        {

        }
        else if (randomSceneNum == 4)
        { 
        
        }
        else if (randomSceneNum == 5)
        {

        }

    }


}

