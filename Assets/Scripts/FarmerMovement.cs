using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerMovement : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float speed, turnRate;

    enum State
	{
        TURNING,
        WALKING
	}

    private State state = State.TURNING;
    private uint patrolPointIndex = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
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


        //Walk to current patrol point
        //increment patrolpointindex
        //switch to turnstate
	}
    void TurnUpdate()
	{

        float angle = Vector2.Angle(gameObject.transform.position, patrolPoints[patrolPointIndex].position); // The end angle we want
        float rotation = gameObject.transform.eulerAngles.z;

        float delta = Mathf.Abs(rotation - angle);

        if (delta > 1)
        {
            gameObject.transform.eulerAngles += Vector3.forward * turnRate * Time.deltaTime;
        }
        else {
            state = State.WALKING;
        }
	}
}
