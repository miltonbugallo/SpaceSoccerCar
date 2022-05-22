using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarVerdeMovement : MonoBehaviour
{
    WheelJoint2D wheel1;
    WheelJoint2D wheel2;
    public float runSpeed;
    public float walkSpeed;
    public float maxSpeed = 10;
    Rigidbody2D rb;

    void Start()
    {
        wheel1 = gameObject.GetComponents<WheelJoint2D>()[0];
        wheel2 = gameObject.GetComponents<WheelJoint2D>()[1];
        runSpeed = 5;
        walkSpeed = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        // Aceleracion
        float input = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.D))
        {
            if (runSpeed < maxSpeed)
            {
                runSpeed += Time.deltaTime;
            }

            rb.velocity = new Vector2(input * runSpeed, rb.velocity.y);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            runSpeed = 0;
            //if (runSpeed > 0)
            //{
            //    runSpeed -= Time.deltaTime;
            //}

            //if (runSpeed < 0) 
            //{
            //    runSpeed = 0;
            //}

            rb.velocity = new Vector2(input * runSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(input * walkSpeed, rb.velocity.y);
        }

        //Frenado
        if (Input.GetKey(KeyCode.A))
        {
            if (runSpeed > -maxSpeed)
            {
                runSpeed -= Time.deltaTime;
            }

            rb.velocity = new Vector2(input * runSpeed, rb.velocity.y);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            runSpeed = 0;
            //if (runSpeed > 0)
            //{
            //    runSpeed -= Time.deltaTime;
            //}

            //if (runSpeed < 0) 
            //{
            //    runSpeed = 0;
            //}

            rb.velocity = new Vector2(input * runSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(input * walkSpeed, rb.velocity.y);
        }

    }
}
