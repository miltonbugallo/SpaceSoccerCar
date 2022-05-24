using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    WheelJoint2D wheel1;
    WheelJoint2D wheel2;
    public float runSpeedAcelerate;
    public float runSpeedBrake;
    public float walkSpeed;
    public float maxSpeed = 10;
    Rigidbody2D rb;

    void Start()
    {
        runSpeedAcelerate = 1;
        runSpeedBrake = -1;
        walkSpeed = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        // Aceleracion
        //float input = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (runSpeedAcelerate < maxSpeed) runSpeedAcelerate += Time.deltaTime;
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
    }
}
