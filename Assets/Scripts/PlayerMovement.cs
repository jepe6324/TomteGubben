using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    public float maxX, minX, maxY, minY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        ClampPosition();
    }

    void HandleMovement()
	{
        Vector3 position = gameObject.transform.position;

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        position.x += x * speed * Time.deltaTime;
        position.y += y * speed * Time.deltaTime;

        gameObject.transform.position = position;
    }
    void ClampPosition()
	{
        Vector3 position = gameObject.transform.position; // having to do this twice feels kinda wasteful

        position.x = Mathf.Clamp(position.x, minX, maxX);
        position.y = Mathf.Clamp(position.y, minY, maxY);

        gameObject.transform.position = position;
    }
}
