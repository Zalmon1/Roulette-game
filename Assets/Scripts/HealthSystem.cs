using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public int life = 3;

    [SerializeField] Sprite[] healthSprite;
    SpriteRenderer spriteRenderer;

    int onDamage = 1;
    int timesHit;

    private void Start()
    {
        
    }


    void Update() 
    {
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
                Debug.LogError("Block sprite is missing from array " + gameObject.name);
            }

        }
    }
}
