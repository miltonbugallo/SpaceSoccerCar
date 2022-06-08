using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class CarVerdeMovement : MonoBehaviour
{
    public float runSpeedAcelerateVerde;
    public float runSpeedBrakeVerde;
    public float walkSpeedVerde;
    public float maxSpeedVerde = 10;
    Rigidbody2D rbVerde;
    public Vector2 posicionInicial;

    void Start()
    {
        runSpeedAcelerateVerde = 1;
        runSpeedBrakeVerde = -1;
        walkSpeedVerde = 0;
        rbVerde = GetComponent<Rigidbody2D>();
        transform.position = posicionInicial;
    }

    // Update is called once per frame
    void Update()
    {

        // Aceleracion
        //float inputVerde = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.G))
        {
            if (runSpeedAcelerateVerde < maxSpeedVerde) runSpeedAcelerateVerde += Time.deltaTime;
            rbVerde.velocity = new Vector2(-runSpeedAcelerateVerde, rbVerde.velocity.y);
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            runSpeedAcelerateVerde = 0;
            rbVerde.velocity = new Vector2(runSpeedAcelerateVerde, rbVerde.velocity.y);
        }


        //Frenado
        if (Input.GetKey(KeyCode.J))
        {
            if (runSpeedBrakeVerde > -maxSpeedVerde) runSpeedBrakeVerde -= Time.deltaTime;
            rbVerde.velocity = new Vector2(-runSpeedBrakeVerde, rbVerde.velocity.y);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            runSpeedBrakeVerde = 0;
            rbVerde.velocity = new Vector2(runSpeedBrakeVerde, rbVerde.velocity.y);
        }
    }


    public void Reset()
    {
        transform.position = posicionInicial;
        rbVerde.velocity = Vector2.zero;
    }

}
