using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 1;
    public Vector3 axic;
    public bool isFish;
    private float timer=0;

    // Update is called once per frame
    void Update()
    {
       // transform.RotateAroundLocal(/*transform.position, */axic, speed * Time.deltaTime);
        transform.Rotate(axic, speed * Time.deltaTime);
        if(isFish)
        {
            timer = timer + Time.deltaTime;
                    if (timer > 0.1)
                    {
                        timer = timer - 0.1f;
                        speed = -speed;
                    }
        }
            
    }
    
}
