using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthSystem : MonoBehaviour
{
    public int life = 3;

    [SerializeField] Sprite[] healthSprite;
    SpriteRenderer spriteRenderer;

    int onDamage = 1;
    int timesHit;

    void Update()
    {
        HandleHit();
        ShowNextHealthSprite();
    }



    void HandleHit()
        {
            timesHit++;
            int maxHits = healthSprite.Length + 1;

            if (timesHit >= maxHits)
            {
                ShowNextHealthSprite();
            }
        }




        void ShowNextHealthSprite()
        {
            int spriteIndex = life - onDamage;
            spriteRenderer.sprite = healthSprite[spriteIndex];

            if (healthSprite[spriteIndex] != null)
            {
                spriteRenderer.sprite = healthSprite[spriteIndex];
            }
            else
            {
                Debug.LogError("Health sprite is missing from array " + gameObject.name);
            }

        }
    
}
