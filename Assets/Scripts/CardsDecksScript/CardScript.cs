using UnityEngine;

[CreateAssetMenu(fileName = "card", menuName = "Deck/Card")]
public class CardScript : ScriptableObject
{
    [SerializeField] DeckScript Deck;

    [SerializeField] bool doubleDmg;
    [SerializeField] bool helmet;

    [SerializeField] int extraHealth;
   
    public bool GetDoubleDamage()
    {
        return doubleDmg;
    }

    public bool GetHelmet() 
    {
        return helmet;
    }

    public int GetExtraHealth() 
    { 
        return extraHealth;
    }
}