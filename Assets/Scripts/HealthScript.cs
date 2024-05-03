using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    [SerializeField] List<Sprite> allHeartsSprites;
    [SerializeField] Image currentImage;
    
    private int healthOfCharacter;

    private static int trackHealthOfPlayer1;

    private static int trackHealthOfPlayer2;

    // currentImage.sprite = allHeartsSprites[3];  


    // Start is called before the first frame update
    void Start()
    {
            
        
    }

    void Update()
    {
        trackHealthOfPlayer2 = RoundScript.player2Health;
        trackHealthOfPlayer1 = RoundScript.player1Health;
    }

   // public void ChangeSpriteOfHeart() { 
        
      //  if(healthOfCharacter == 3)
       // {
       //     currentImage.sprite = allHeartsSprites[2];
       // }
   
   // }

    public void CheckHealthOfPlayer1()
    {
        if (trackHealthOfPlayer1 ==  4)
        {
            currentImage.sprite = allHeartsSprites[0];
        }
        else if (trackHealthOfPlayer1 == 3)
        {
            currentImage.sprite = allHeartsSprites[1];
        }
        else if (trackHealthOfPlayer1 == 2)
        {
            currentImage.sprite = allHeartsSprites[2];
        }
        else if (trackHealthOfPlayer1 == 1)
        {
            currentImage.sprite = allHeartsSprites[3];
        }
    }

    public void CheckHealthOfPlayer2() 
    { 
    
    }
}
