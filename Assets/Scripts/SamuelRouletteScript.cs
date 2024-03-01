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
    [SerializeField] Image PlayerHeart = null;
    [SerializeField] Image EnemyHeart = null;


    bool YourTurn = true;

    // Start is called before the first frame update
    void Start()
    {
        EnemyHealth = 3;
        PlayerHealth = 3;
      
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void RandomPlayerShoot()
    {
       

        if (Random.Range(0f, 5f) == 0 && YourTurn == true)
        {
            Thread.Sleep(20000);
            EnemyHealth--;
            
            YourTurn = false;
        }
        else
        {
            YourTurn = false;
            return;
        }





    }
    public void RandomEnemyShoot()
    {
        if (Random.Range(0f, 5f) == 0 && YourTurn == false)
        {
            PlayerHealth--;
            YourTurn = true;

        }
        else
        {
            YourTurn = true;
            return;
        }


    }
   

}