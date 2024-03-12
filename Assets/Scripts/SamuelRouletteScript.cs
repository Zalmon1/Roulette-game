using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class SamuelRouletteScript : MonoBehaviour
{
    [SerializeField] int PlayerHealth;
    [SerializeField] int EnemyHealth;
    [SerializeField] bool Player1turn;
    [SerializeField] bool Player2turn;

    
    public void PlayerTakeDamage()
    {
        PlayerHealth--;
    }

    public void EnemyTakeDamage()
    {
        EnemyHealth--;
    }

    public void Player1Shoot()
    {
        float Player1ChanceToShoot = Random.Range(0f, 5f);

        if (Player1turn == true && Player1ChanceToShoot > 1f)
        {
            Debug.Log("You missed");
            Player1turn = false;
            Player2turn = true;

        }
        else if (Player1turn == true && Player1ChanceToShoot < 1f) 
        {
            Debug.Log("You hit");
            Player1turn = false;   
            EnemyTakeDamage();
        }
        
    }

    public void Player2Shoot()
    {
        float PlayerChanceToShoot = Random.Range(0f, 5f);

        if (Player2turn == true && PlayerChanceToShoot > 1f)
        {
            Debug.Log("Player2 missed");
            Player1turn = true;
            Player2turn = false;
        }
        else if (Player2turn && PlayerChanceToShoot < 1f)
        {
            Debug.Log("Player2 hit");
            Player2turn = true;
            PlayerTakeDamage();
        }


    }



}