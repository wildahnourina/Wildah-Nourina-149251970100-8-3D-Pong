using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode rightKey;
    public KeyCode leftKey;
    public KeyCode forwardKey;
    public KeyCode backKey;    

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        movepaddle(GetInput());
    }

    private Vector3 GetInput()
    {
        if (Input.GetKey(rightKey))
        {
            return Vector3.right * speed;
        }
        else if (Input.GetKey(leftKey))
        {
            return Vector3.left * speed;
        }
        else if (Input.GetKey(forwardKey))
        {
            return Vector3.forward * speed;
        }
        else if (Input.GetKey(backKey))
        {
            return Vector3.back * speed;
        }
        
        return Vector3.zero;
    }

    private void movepaddle(Vector3 move)
    {
        rb.velocity = move;
    }
}
