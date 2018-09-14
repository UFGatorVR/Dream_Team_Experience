using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PenguinBehavior : MonoBehaviour
{



    public Transform myTransform;
    public float speed = 1.0f;
    Vector3 vel = new Vector3(0,0,0);
    public float curTime = 0f;
    public float switchDirection = 3f;
    // Use this for initialization
    void Start()
    {
        SetVel();
    }

    void SetVel(){
        if (Random.value > .5)
        {
            vel.x = 10* 10 * Random.value;
        }
        else
        {
            vel.x = -10 * 10 * Random.value;
        }
        if (Random.value > .5)
        {
            vel.z = 10 * 10 * Random.value;
        }
        else
        {
            vel.z = -10 * 10 * Random.value;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (curTime < switchDirection)
        {
            curTime += 1 * Time.deltaTime;
        }
        else
        {
            SetVel();
            if (Random.value > .5)
            {
                switchDirection += Random.value;
            }
    else {
                    switchDirection -= Random.value;
                }
                if (switchDirection < 1)
                {
                    switchDirection = 1 + Random.value;
                }
                curTime = 0;
            }

        }

	private void FixedUpdate()
	{
        transform.Translate(vel * Time.deltaTime);
	}

}