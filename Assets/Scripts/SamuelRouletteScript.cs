using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class SamuelRouletteScript : MonoBehaviour
{
    [SerializeField] Sprite[] Healthsprites;
    [SerializeField] int PlayerHealth;
    [SerializeField] int EnemyHealth;
    [SerializeField] Image PlayerHeart;
    [SerializeField] Image EnemyHeart;


   [SerializeField] bool YourTurn = true;

    void Start()
    {
        EnemyHealth = 10;
        PlayerHealth = 10;

      
    }

    // Update is called once per frame
    void Update()
    {
        RandomEnemyShoot();
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
        if (randomNumber <= 1 && YourTurn == false)
        {
            PlayerHealth--;
            YourTurn = true;
           Debug.Log("The enemy hit you");
        }
        else if(randomNumber >= 2 && YourTurn == false)
        {
            YourTurn = true;
            Debug.Log("The enemy missed you");
            return;
        }


    }
   

}