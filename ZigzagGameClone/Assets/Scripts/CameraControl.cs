using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform locationBall;
    Vector3 addCube;
    void Start()
    {
        addCube = transform.position - locationBall.position;
    }

    void Update()
    {
        if (BallControl.isFall == false)
        {
            transform.position = locationBall.position + addCube;
        }
        
    }
}
