using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class RoundScript : MonoBehaviour
{
    public CardScript ActiveCard = null;
    [SerializeField] bool friendlyTurn;

    [SerializeField] public int player1Health;
    [SerializeField] public int player2Health;

    [SerializeField] AudioClip emptyclip;
    [SerializeField] AudioClip shoot;
    [SerializeField] int chanceToShoot;

    [SerializeField] float damageMultiplier = 2.0f;

    float damageValuehAtStart;
    
    SceneLoader loader;
    public void SetActiveCard(CardScript aCard)
    {
        ActiveCard = aCard;
    }
    // Start is called before the first frame update
    void Start()
    {
      
        player1Health = 8;
        player2Health = 8;

        friendlyTurn = true;

        loader = gameObject.GetComponent<SceneLoader>();
    }

    // Update is called once per frame
    void Update() //check if win or lose
    {
        CheckPlayer1Health();
        CheckPlayer2Health();

    }



    public void CheckTurn() //check whos turn it is to distribute dmg accordingly
    {
        chanceToShoot = Random.Range(1, 7);

        if (friendlyTurn) 
        {
            ShootFunction();
        }
        else
        {
            EnemyShoot();
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

    private void DealDamageToEnemy()
    {
        int dmgToDeal = 1;
        if(ActiveCard != null)
        {
            if (ActiveCard.myCardType == CardType.DoubleDamage)
            {
                dmgToDeal *= 2;
            }
        }
      
        player2Health-= dmgToDeal;
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