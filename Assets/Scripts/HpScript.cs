using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HpScript : MonoBehaviour
{
    [SerializeField] int PlayerLives = 3;
    
    SceneScript sceneScript;


    private void Start()
    {
        sceneScript = FindObjectOfType<SceneScript>();

       
    }

    private void Update()
    {
        UpdateHearts();
    }

    void UpdateHearts()
    {
        PlayerDeath();
    }

    private void PlayerDeath()
    {
        if (PlayerLives == 0)
        {
            sceneScript.GoToNextScene();
        }
    }


    private void RemoveHealth()
    {
       
    }

}
