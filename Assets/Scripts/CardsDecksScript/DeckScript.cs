using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;


[CreateAssetMenu(fileName = "Deck", menuName = "Deck/Deck")]
public class DeckScript : ScriptableObject
{
    public List<CardScript> Deck = new List<CardScript>();
    public List<CardScript> ShuffledDeck;

    public void Randomize()
    {
        ShuffledDeck = new List<CardScript>();
        foreach (CardScript card in Deck)
        {
            ShuffledDeck.Add(card);
        }
        ListExtensions.Shuffle<CardScript>(ShuffledDeck);


    }
}
