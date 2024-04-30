using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    [SerializeField] List<Sprite> allHeartsSprites;
    [SerializeField] Image currentImage;
    
    private int healthOfCharacter;

    // Start is called before the first frame update
    void Start()
    {
            
            

        currentImage.sprite = allHeartsSprites[3];  
    }


    public void ChageSpriteOfHeart() { 
        
        if(healthOfCharacter == 3)
        {
            currentImage.sprite = allHeartsSprites[2];
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
