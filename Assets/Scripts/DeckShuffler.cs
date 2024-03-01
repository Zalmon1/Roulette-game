using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckShuffler : MonoBehaviour
{
    private void Update()
    {
        FindAnyObjectByType<DeckScript>().
        Randomize();
    }
}