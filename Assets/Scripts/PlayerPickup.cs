using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    [HideInInspector] public Pickup pickup;
    Pickup proximity;
    void Update()
    {
		if (Input.GetKeyDown("space"))
		{
            pickup = proximity;
		}
        if (pickup != null)
		{
            pickup.transform.position = transform.position;
		}
    }

    void OnTriggerEnter2D(Collider2D other)
	{
        if (other.CompareTag("Pickup")) {
            proximity = other.GetComponent<Pickup>();
        }
	}
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Pickup") && other.GetComponent<Pickup>() == proximity)
		{
            proximity = null;
		}
    }
}
