using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarVerdeMovement : MonoBehaviour
{
    public float runSpeedAcelerateVerde;
    public float runSpeedBrakeVerde;
    public float walkSpeedVerde;
    public float maxSpeedVerde = 10;
    Rigidbody2D rbVerde;

    void Start()
    {
        runSpeedAcelerateVerde = 1;
        runSpeedBrakeVerde = -1;
        walkSpeedVerde = 0;
        rbVerde = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        // Aceleracion
        //float inputVerde = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.A))
        {
            if (runSpeedAcelerateVerde < maxSpeedVerde)
            {
                runSpeedAcelerateVerde += Time.deltaTime;
            }

            rbVerde.velocity = new Vector2(-runSpeedAcelerateVerde, rbVerde.velocity.y);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            runSpeedAcelerateVerde = 0;
            rbVerde.velocity = new Vector2(-runSpeedAcelerateVerde, rbVerde.velocity.y);
        }
        else

        //Frenado
        if (Input.GetKey(KeyCode.D))
        {
            if (runSpeedBrakeVerde > -maxSpeedVerde)
            {
                runSpeedBrakeVerde -= Time.deltaTime;
            }

            rbVerde.velocity = new Vector2(-runSpeedBrakeVerde, rbVerde.velocity.y);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            runSpeedBrakeVerde = 0;
            //if (runSpeed > 0)
            //{
            //    runSpeed -= Time.deltaTime;
            //}

            //if (runSpeed < 0) 
            //{
            //    runSpeed = 0;
            //}

            rbVerde.velocity = new Vector2(-runSpeedBrakeVerde, rbVerde.velocity.y);
        }
        else
        {
            rbVerde.velocity = new Vector2(walkSpeedVerde, rbVerde.velocity.y);
        }

    }
}
