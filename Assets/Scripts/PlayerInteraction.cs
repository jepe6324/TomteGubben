using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    PlayerPickup playerPickup;
    GameObject interactable;

    void Start()
	{
        playerPickup = GetComponent<PlayerPickup>();
	}
    void Update()
    {
        if (playerPickup.pickup != null && interactable != null && Input.GetKeyDown("space"))
		{
            string pickupName = playerPickup.pickup.name;
            string interactableName = interactable.gameObject.name;
            interactable.BroadcastMessage("Interact", pickupName);
		}
    }
    void OnTriggerEnter2D(Collider2D other)
	{
        if (other.gameObject.CompareTag("Interactable"))
		{
            interactable = other.gameObject;
		}
	}
    void OnTriggerExit2D(Collider2D other)
	{
        if (interactable != null && other.name == interactable.name)
		{
            interactable = null;
		}
	}
}
