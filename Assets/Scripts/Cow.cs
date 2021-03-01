using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : MonoBehaviour
{
	public Bucket bucket;

	BoxCollider2D boxCollider;
	bool fed = false;
	void Start()
	{
		boxCollider = GetComponent<BoxCollider2D>();
	}
	public void Feed()
	{
		fed = true;
		// Mooooooooo noise
	}
	public void Interact(string pickupName)
	{
		if (pickupName == "Bucket" && fed)
		{
			Destroy(boxCollider);
			bucket.BroadcastMessage("Fill");
		}
	}
}
