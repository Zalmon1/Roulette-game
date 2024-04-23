using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnClicked()
    {
        int chance = Random.Range(1, 6);
        int luckyBastard = Random.Range(1, 1000000);

        if (chance == 1)
        {
            Debug.Log("You hit");
            
        }
        else
        {
            Debug.Log("You missed");
        }



    }
}
