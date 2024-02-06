using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpScript : MonoBehaviour
{
    [SerializeField] int PlayerLives = 3;

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
            // Player lives reaches 0 we die (use sceneManager)
        }
    }

}
