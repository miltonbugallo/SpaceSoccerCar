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
    private int contadorJump = 0; // this doesn't need to be public

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

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (runSpeedAcelerateVerde < maxSpeedVerde) runSpeedAcelerateVerde += (Time.deltaTime * 4);
            rbVerde.velocity = new Vector2(-runSpeedAcelerateVerde, rbVerde.velocity.y);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            runSpeedAcelerateVerde = 0;
            rbVerde.velocity = new Vector2(runSpeedAcelerateVerde, rbVerde.velocity.y);
        }


        //Frenado
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (runSpeedBrakeVerde > -maxSpeedVerde) runSpeedBrakeVerde -= (Time.deltaTime * 4);
            rbVerde.velocity = new Vector2(-runSpeedBrakeVerde, rbVerde.velocity.y);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            runSpeedBrakeVerde = 0;
            rbVerde.velocity = new Vector2(runSpeedBrakeVerde, rbVerde.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && contadorJump < 2)
        {
            float jumpVelocity = 7f;
            rbVerde.velocity = new Vector2(rbVerde.velocity.x, jumpVelocity);
            contadorJump++;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            float jumpVelocity = 0;
            rbVerde.velocity = new Vector2(rbVerde.velocity.x, jumpVelocity);
        }

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ground") // GameObject is a type, gameObject is the property
        {
            contadorJump = 0;
        }
    }


    public void Reset()
    {
        transform.position = posicionInicial;
        rbVerde.velocity = Vector2.zero;
        rbVerde.constraints = RigidbodyConstraints2D.None;
        rbVerde.constraints = RigidbodyConstraints2D.FreezeRotation;
    }


    public void StartFreezer()
    {
        StartCoroutine(Freezer());
    }


    public IEnumerator Freezer()
    {
        rbVerde.velocity = Vector2.zero;
        //Finally freeze the body in place so forces like gravity or movement won't affect it
        rbVerde.constraints = RigidbodyConstraints2D.FreezeAll;
        //Wait for a bit (two seconds)
        yield return new WaitForSeconds(5);
        rbVerde.constraints = RigidbodyConstraints2D.None;
        rbVerde.constraints = RigidbodyConstraints2D.FreezeRotation;
        contadorJump = 0;
    }

}
