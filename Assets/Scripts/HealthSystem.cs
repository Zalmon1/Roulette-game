using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;

    [SerializeField] Sprite[] healthSprite;
    SpriteRenderer spriteRenderer;

    int onDamage;

    void Update()
{
        void ShowNextHitSprite()
        {
            int spriteIndex = onDamage - 1;
            spriteRenderer.sprite = healthSprite spriteIndex];

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