using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerMovement : MonoBehaviour
{
    enum State
    {
        TURNING,
        WALKING
    }

    public Transform[] patrolPoints;
    public float speed, turnRate;

    private State state = State.TURNING;
    private uint patrolPointIndex = 0;
    private float angle;
    void Update()
    {
        if (state == State.WALKING)
		{
            WalkUpdate();
		}
		else
		{
            TurnUpdate();
		}
    }

    void WalkUpdate()
	{
        Vector3 position = transform.position;
        Vector3 destination = patrolPoints[patrolPointIndex].position;
        Vector3 direction = (destination - position).normalized;
        position += direction* speed * Time.deltaTime;

        transform.position = position;

        if (Vector3.Distance(position, destination) < 0.2f)
		{
            IncrementIndex();
            state = State.TURNING;
        }
	}
    void TurnUpdate()
    {
        angle = Vector2.Angle( transform.up, patrolPoints[patrolPointIndex].position - transform.position);
        transform.Rotate(transform.forward, turnRate * Time.deltaTime);
        if (angle < 0.5)
        {
            state = State.WALKING;
        }

	}
    void IncrementIndex()
	{
        patrolPointIndex++;
        if (patrolPointIndex >= patrolPoints.Length)
		{
            patrolPointIndex = 0;
		}
	}
}
