using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class SamuelRouletteScript : MonoBehaviour
{
    [SerializeField] int PlayerHealth;
    [SerializeField] int EnemyHealth;


   [SerializeField] bool YourTurn = true;

    void Start()
    {
        EnemyHealth = 10;
        PlayerHealth = 10;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    public void EnemyRandomShoot()
    {
        float RandomEnemyShot = Random.Range(0f, 5f);

        if (RandomEnemyShot < 0f)
    }

    public void PlayerRandomShoot()
    {
        float RandomShot = Random.Range(0f, 5f);

        if (RandomShot > 1f && YourTurn == true) // check if the value is larger than 1, if its true you don't hit
        {
            Debug.Log("You missed the enemy");

            YourTurn = false;

            return;
        }
        else if (RandomShot < 1f && YourTurn == true) // else if random is smaller than one, you get to shoot
        {
            Debug.Log("You hit the enemy");

            YourTurn = false;

            EnemyHealth--;

            return; 
        }

    }






    public void RandomPlayerShoot()
    {
       

        if (Random.Range(0f, 5f) <= 1 && YourTurn == true)
        {
            EnemyHealth--;
            
            YourTurn = false;
            Debug.Log("You hit the enemy");
        }
        else
        {
            YourTurn = false;
            Debug.Log("You didn't hit the enemy");
            return;
        }





    }
    public void RandomEnemyShoot()
    {


        float randomNumber = Random.Range(0f, 5f);
        //Debug.Log(randomNumber);
        if (randomNumber < 1 && YourTurn == false)
        {
            PlayerHealth--;
            YourTurn = true;
           Debug.Log("The enemy hit you");
        }
        else if(randomNumber > 1 && YourTurn == false)
        {
            YourTurn = true;
            Debug.Log("The enemy missed you");
            return;
        }


    }
   

}