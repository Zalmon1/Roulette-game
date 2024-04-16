using UnityEngine;
public enum CardType
{
    DoubleDamage,
    Helmet,
    ExtraHealth,
    Total
}
[CreateAssetMenu(fileName = "card", menuName = "Deck/Card")]
public class CardScript : ScriptableObject
{
    public CardType myCardType = CardType.DoubleDamage;
    [SerializeField] DeckScript Deck;
    [SerializeField] RoundScript DmgScript;

    [SerializeField] bool doubleDmg;
    [SerializeField] bool helmet;

    [SerializeField] int extraHealth;

    public int Value = 0;
    [SerializeField] GameObject Card1;

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