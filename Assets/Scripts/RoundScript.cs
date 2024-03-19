using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundScript : MonoBehaviour
{
    [SerializeField] bool Player1Turn;

    [SerializeField] int player1Health;
    [SerializeField] int player2Health;

    [SerializeField] float chanceToShoot;

    // Start is called before the first frame update
    void Start()
    {
        chanceToShoot = Random.Range(1, 7);
        player1Health = 5;
        player2Health = 5;
        Player1Turn = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Player1Shoot()
    {
        if (chanceToShoot == 1 && Player1Turn == true)
        {
            player1Health--;
            Debug.Log("Player1 hit");
            Player1Turn = false;
        }
        else
        {
            Debug.Log("Player1 missed");
            Player1Turn = false;
        }

    }
    public void Player2Shoot()
    {
        if (chanceToShoot == 1 && Player1Turn == false)
        {
            player2Health--;
            Debug.Log("Player2 hit");
            Player1Turn = true;
        }
        else if (chanceToShoot != 0 && Player1Turn)
        {
            Debug.Log("Player2 missed");
            Player1Turn = true;
        }

    }
}
