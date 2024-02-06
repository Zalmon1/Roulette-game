using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{

    [SerializeField, Range(0.1f, 10f)] float gameSpeed = 1f;

    private void Awake()
    {
        // Count and save the number of GameStatus objects in an int variable
        int gameSessionCount = FindObjectsOfType<GameSession>().Length;

        if (gameSessionCount > 1)
        {
            // If more than 1 GameStatus object, destroy myself
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            // If only 1 GameStatus object, keep existing
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

}