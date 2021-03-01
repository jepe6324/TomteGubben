using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerDetection : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
            GetComponent<AudioSource>().Play();
		}
	}
}
