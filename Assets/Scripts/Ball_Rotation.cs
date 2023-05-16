using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Rotation : MonoBehaviour
{
    [SerializeField] GameObject CenterCircle;
    bool direction = false;
    public float speed_ball;
    private void FixedUpdate()
    {
        if (direction == false) { 
        CenterCircle.transform.Rotate(0, 0, speed_ball * Time.deltaTime);
        }
        else
        {
            CenterCircle.transform.Rotate(0, 0, -speed_ball * Time.deltaTime);
        }
    }

    public void ChangeDirection()
    {
        direction = !direction; 
}
}
