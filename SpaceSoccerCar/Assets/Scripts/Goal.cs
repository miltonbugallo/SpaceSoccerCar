using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool playerVerdeGoal;
    public GameObject gameManager;


    private void OnTriggerEnter2D(Collider2D collision) 
    { 
        if (collision.CompareTag("pelota"))
        {
            if (playerVerdeGoal) {
                gameManager.GetComponent<GameManager>().PuntajeJugador2();
            }
            else
            {
                gameManager.GetComponent<GameManager>().PuntajeJugador1();
            }
        }
        
    }
}
