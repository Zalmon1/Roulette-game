using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamuelRouletteScript : MonoBehaviour
{
    [SerializeField] Sprite[] Healthsprites;
    [SerializeField] int PlayerHealth;
    [SerializeField] int EnemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RandomShoot()
    { 
       if( Random.Range(0f, 1f) == 0)
        {

        }
       else
        {

        }

       
    }

    public void TakeEnemyHealth()
    {

    }

    public void TakePlayerHealth()
    {

    }
}
