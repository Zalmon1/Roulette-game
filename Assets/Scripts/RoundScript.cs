using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class RoundScript : MonoBehaviour
{
    [SerializeField] bool friendlyTurn;

    [SerializeField] int player1Health;
    [SerializeField] int player2Health;

    [SerializeField] AudioClip emptyclip;
    [SerializeField] AudioClip shoot;
    [SerializeField] int chanceToShoot;

    public Object arrow;

    // Start is called before the first frame update
    void Start()
    {
      
        player1Health = 20;
        player2Health = 20;

        friendlyTurn = true;

        arrow = GameObject.FindGameObjectWithTag("FriendArrow");
        
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void CheckTurn()
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
    
    public void ShootFunction()
    {

        
       

        if (chanceToShoot >= 5 && friendlyTurn == true)
        {
            AudioSource.PlayClipAtPoint(shoot, Camera.main.transform.position);
            Debug.Log("player hit");
            friendlyTurn = false;
            player2Health--;
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

    public void EnemyShoot()
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




}