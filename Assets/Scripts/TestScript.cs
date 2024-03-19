using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClicked()
    {
        int chance = Random.Range(1, 6);

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
