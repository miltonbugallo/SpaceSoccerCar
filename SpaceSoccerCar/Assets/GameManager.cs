using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject pelota;

    public GameObject jugador1;
    public GameObject jugador1Gol;

    public GameObject jugador2;
    public GameObject jugador2Gol;

    public int puntajeJugador1;
    public int puntajeJugador2;

    public Text textoPuntaje1;
    public Text textoPuntaje2;

    public void PuntajeJugador1()
    {
        puntajeJugador1++;
        textoPuntaje1.text = puntajeJugador1.ToString();
        ResetPosition();
    }

    public void PuntajeJugador2()
    {
        puntajeJugador2++;
        textoPuntaje2.text = puntajeJugador2.ToString();
        ResetPosition();
    }

    public void ResetPosition()
    {
        pelota.GetComponent<BallMovement>().Reset();
        jugador1.GetComponent<CarMovement>().Reset();
        jugador2.GetComponent<CarVerdeMovement>().Reset();
    }
}
