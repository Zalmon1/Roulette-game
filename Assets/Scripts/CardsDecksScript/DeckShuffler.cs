using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ListExtensions
{
    private static System.Random rng = new System.Random();

    public static void Shuffle<TypeOfObject>(this IList<TypeOfObject> list)
    {
        int cardsToSHuffle = list.Count;
        while (cardsToSHuffle > 1)
        {
            cardsToSHuffle--;
            int index = rng.Next(cardsToSHuffle + 1);
            TypeOfObject value = list[index];
            list[index] = list[cardsToSHuffle];
            list[cardsToSHuffle] = value;
        }
    }
}

public class DeckShuffler : MonoBehaviour
{
    private void Update()
    {
        FindAnyObjectByType<DeckScript>().
        Randomize();
        List<int> list = new List<int>();
        ListExtensions.Shuffle<int>(list);
    }


}