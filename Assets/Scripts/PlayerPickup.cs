using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    Pickup pickup;
    void Update()
    {
		if (Input.GetKeyDown("space"))
		{
            //If a pickup is ready
            //pick it up
		}
    }

    void OnTriggerEnter2D(Collider2D other)
	{
        //Ready object for being picked up
	}
    void OnTriggerExit2D(Collider2D other)
    {
        //Unready object for being picked up
    }
}
