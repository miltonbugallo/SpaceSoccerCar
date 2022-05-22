using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float ballSpeed = 5;
    public Rigidbody2D rb;
    public Vector2 posicionInicial;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = posicionInicial;
        Inicio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Inicio()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(ballSpeed * x, ballSpeed * y);
    }

}