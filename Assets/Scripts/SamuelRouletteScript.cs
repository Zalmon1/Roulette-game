using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class SamuelRouletteScript : MonoBehaviour
{
    [SerializeField] int PlayerHealth;
    [SerializeField] int EnemyHealth;
    [SerializeField] bool YourTurn;

    
    public void PlayerTakeDamage()
    {
        PlayerHealth--;
    }

    public void EnemyTakeDamage()
    {
        EnemyHealth--;
    }







}