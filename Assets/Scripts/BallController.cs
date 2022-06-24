using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    //public Vector3 ResetPosition;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = speed;
    }

    void Update()
    {
        
    }

    //public void ResetBall()
    //{
    //    transform.position = new Vector3(ResetPosition.x, ResetPosition.y, ResetPosition.z);
    //}
}
