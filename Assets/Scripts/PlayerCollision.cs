using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    CircleCollider2D collisionRadius;
    // Start is called before the first frame update
    void Start()
    {
        collisionRadius = GetComponent<CircleCollider2D>();
    }
    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision!");
    }
}
