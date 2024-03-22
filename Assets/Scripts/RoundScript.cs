using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class RoundScript : MonoBehaviour
{
    [SerializeField] bool player1Turn;

    [SerializeField] int player1Health;
    [SerializeField] int player2Health;

    [SerializeField] float chanceToShoot;

    public Object arrow;

    // Start is called before the first frame update
    void Start()
    {
        chanceToShoot = Random.Range(1, 7);
        player1Health = 10;
        player2Health = 10;

        player1Turn = true;

        arrow = GameObject.FindGameObjectWithTag("FriendArrow");

        Debug.Log(arrow);

        
        
    }

    // Update is called once per frame
    void Update()
    {


        ArrowChange();
    }
    
    public void ButtonToShoot()
    {
        if (chanceToShoot == 6)
        {

        }
    }

    public void ArrowChange()
    {
        if(player1Turn  == true)
        {
            
        }
        else
        {

        }
        
    }



    public void Player1Shoot()
    {
        if (chanceToShoot == 1 && player1Turn == true)
        {
            player1Health--;
            Debug.Log("Player1 hit");
            player1Turn = false;
        }
        else
        {
            Debug.Log("Player1 missed");
            player1Turn = false;
        }

    }
 }