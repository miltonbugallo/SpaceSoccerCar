using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    WheelJoint2D wheel1;
    WheelJoint2D wheel2;
    JointMotor2D motor;
    public float runSpeed;
    public float walkSpeed;
    public float maxSpeed = 500;
    Rigidbody2D rb;
    void Start()
    {
        wheel1 = gameObject.GetComponents<WheelJoint2D>()[0];
        wheel2 = gameObject.GetComponents<WheelJoint2D>()[1];
        motor = new JointMotor2D();
        runSpeed = 5;
        walkSpeed = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (runSpeed < maxSpeed)
            {
                runSpeed += Time.deltaTime;
            }

            rb.velocity = new Vector2(input * runSpeed, rb.velocity.y);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            runSpeed = 5;
        }
        else
        {
            rb.velocity = new Vector2(input * walkSpeed, rb.velocity.y);
        }

    }
}
