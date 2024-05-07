using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class RoundScript : MonoBehaviour
{
    public CardScript ActiveCard = null; 
    [SerializeField] bool friendlyTurn; // turn checker

    [SerializeField] public static int player1Health;
    [SerializeField] public static int player2Health; 

    [SerializeField] AudioClip emptyclip; // audio to not shoot a bullet
    [SerializeField] AudioClip shoot; // audio to shoot a bullet
    [SerializeField] int chanceToShoot; // chance to shoot

    [SerializeField] float damageMultiplier = 2.0f;
    
    SceneLoader loader;
    public void SetActiveCard(CardScript aCard)
    {
        ActiveCard = aCard;
    }
    // Start is called before the first frame update
    void Start() // setting the health and turns, while also getting the sceneloader
    {
      
        player1Health = 4;
        player2Health = 4;

        friendlyTurn = true;

        loader = gameObject.GetComponent<SceneLoader>();
    }

    // Update is called once per frame
    void Update() //check if win or lose
    {
        CheckPlayer1Health(); //check if player 1 health is below 1
        CheckPlayer2Health(); //check if player 2 health is below 1

    }



    public void CheckTurn() //check whos turn it is to distribute dmg accordingly
    {
        chanceToShoot = Random.Range(1, 7);

        if (friendlyTurn) 
        {
            ShootFunction(); //calls the friendly shoot function
        }
        else
        {
            EnemyShoot(); // calls the enemy shoot function
        }
    }
    
    public void ShootFunction() //friendlyshoot
    {

        if (chanceToShoot >= 5 && friendlyTurn == true)
        {
            AudioSource.PlayClipAtPoint(shoot, Camera.main.transform.position);
            Debug.Log("player hit");
            friendlyTurn = false;
            DealDamageToEnemy();
        }
        else if (friendlyTurn == true)
        {
            AudioSource.PlayClipAtPoint(emptyclip, Camera.main.transform.position);
            Debug.Log("player missed");
            friendlyTurn = false;
        }
        else
        {
            Debug.Log("Not player turn");
            friendlyTurn = false;
            return;
        }


    }

    private void DealDamageToEnemy() // Makes so that double dmg works ( in progress )
    {
        int damageMultiplier = 1;
        if(ActiveCard != null)
        {

            if (ActiveCard.myCardType == CardType.DoubleDamage)
            {
                damageMultiplier *= 2;
            }
        }
      
        player2Health-= damageMultiplier;
    }

    public void EnemyShoot() //oppshoot
    {
        if (chanceToShoot >= 5 && friendlyTurn == false)
        {
            AudioSource.PlayClipAtPoint(shoot, Camera.main.transform.position);
            Debug.Log("enemy hit");
            friendlyTurn = true;
            player1Health--;
            
        }
        else if (friendlyTurn == false)
        {
            AudioSource.PlayClipAtPoint(emptyclip, Camera.main.transform.position);
            Debug.Log("enemy missed");
            friendlyTurn = true;
        }
        else
        {
            Debug.Log("Not enemy turn");
            friendlyTurn = true;
            return;
        }

    }

    public void CheckPlayer1Health()
    {
        if (player1Health <= 0)
        {
            loader.Player2Win();
        }
        else
        {
            return;
        }

    }

    public void CheckPlayer2Health()
    {
        if (player2Health <= 0)
        {
            loader.Player1Win();
        }
        else
        {
            return;
        }

    }
}