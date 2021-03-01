using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haystack : MonoBehaviour
{
	public Sprite cutSprite;
	public Cow cow;

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
			cow.BroadcastMessage("Feed");
			// Cut noise

		}
	}
}
