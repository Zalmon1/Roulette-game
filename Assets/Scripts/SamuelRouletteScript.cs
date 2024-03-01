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
        EnemyHealth = 3;
        PlayerHealth = 3;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void RandomPlayerShoot()
    {
        if (Random.Range(0f, 5f) == 0)
        {
            EnemyHealth--;
        }
        else
        {
            return;
        }





    }
    public void RandomEnemyShoot()
    {
        if (Random.Range(0f, 5f) == 0)
        {
            PlayerHealth--;
        }
        else
        {
            return;
        }


    }
   

}