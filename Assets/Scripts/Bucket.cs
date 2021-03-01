using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    public Sprite filledSprite;

    SpriteRenderer spriteRenderer;
    BoxCollider2D boxCollider;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    public void Fill()
	{
        spriteRenderer.sprite = filledSprite;
        // Bucket noise
	}
}
