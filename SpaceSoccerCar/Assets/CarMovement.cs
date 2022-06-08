using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class CarMovement : MonoBehaviour
{
    WheelJoint2D wheel1;
    WheelJoint2D wheel2;
    public float runSpeedAcelerate;
    public float runSpeedBrake;
    public float walkSpeed;
    public float maxSpeed = 10;
    Rigidbody2D rb;
    public Vector2 posicionInicial;
    //public float jumpHeight;
    private bool isJumping = false; // this doesn't need to be public

    void Start()
    {
        runSpeedAcelerate = 1;
        runSpeedBrake = -1;
        walkSpeed = 0;
        rb = GetComponent<Rigidbody2D>();
        transform.position = posicionInicial;
    }

    // Update is called once per frame
    void Update()
    {

        // Aceleracion
        //float input = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (runSpeedAcelerate < maxSpeed) runSpeedAcelerate += (Time.deltaTime*2);
            rb.velocity = new Vector2(runSpeedAcelerate, rb.velocity.y);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            runSpeedAcelerate = 0;
            rb.velocity = new Vector2(runSpeedAcelerate, rb.velocity.y);
        }
      
        //Frenado
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (runSpeedBrake > -maxSpeed) runSpeedBrake -= Time.deltaTime;
            rb.velocity = new Vector2(runSpeedBrake, rb.velocity.y);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            runSpeedBrake = 0;
            rb.velocity = new Vector2(runSpeedBrake, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && !isJumping)
        {
            float jumpVelocity = 5f;
            rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);
            isJumping = true;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            float jumpVelocity = 0;
            rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);
        }

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ground") // GameObject is a type, gameObject is the property
        {
            print("hola");
            isJumping = false;
        }
    }

    public void Reset()
    {
        transform.position = posicionInicial;
        rb.velocity = Vector2.zero;
    }


}
