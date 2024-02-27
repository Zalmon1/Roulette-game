using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class CardScript : MonoBehaviour
{

    [SerializeField] int chance = 50;



    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Randomize();
        }
    }

    public void Randomize()
    {
        int luck = Random.Range(1, 100);

        if (chance >= luck)
        {
            // You get the card


        }
        else
        {
            // You dont get the card

        }
    }

    void Cards()
    {

    }
}
