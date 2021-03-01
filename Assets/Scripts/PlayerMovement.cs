using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float maxX, minX, maxY, minY;

    Vector2 direction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        ClampPosition();
        RotatePlayer();
    }

    void HandleMovement()
	{
        Vector3 position = gameObject.transform.position;

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (x != 0 || y != 0)
		{
            direction.x = x;
            direction.y = y;
            direction.Normalize();
		}

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
    void RotatePlayer()
	{
        float angle = Vector2.SignedAngle(Vector2.up, direction);
        Vector3 rotateVector = new Vector3(0, 0, angle);

        transform.eulerAngles = rotateVector;
	}
}
