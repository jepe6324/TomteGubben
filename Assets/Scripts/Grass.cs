using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
	public Sprite cutSprite;

	SpriteRenderer spriteRenderer;
	BoxCollider2D boxCollider;

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
		boxCollider = GetComponent<BoxCollider2D>();
	}

	void Interact(string pickupName)
	{
		if (pickupName == "Scissors")
		{
			Destroy(boxCollider);
			spriteRenderer.sprite = cutSprite;
			// Grass cut noise
		}
	}
}
