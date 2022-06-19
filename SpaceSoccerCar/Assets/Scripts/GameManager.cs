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

    public GameObject freezer;

    public GameObject stopGoal;
    public GameObject stopGoalIzquierdo;
    public GameObject stopGoalDerecho;

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
        //freezer.GetComponent<Freezer>().Reset();
        //stopGoal.GetComponent<StopGoal>().Reset();
        stopGoalIzquierdo.GetComponent<StopGoalIzquierdo>().Reset();
        stopGoalDerecho.GetComponent<StopGoalDerecho>().Reset();
        

    }

    public void FreezerPlayer1() // Funcion que freeza al player1
    {
        jugador1.GetComponent<CarMovement>().StartFreezer();
        freezer.GetComponent<Freezer>().StartFreezerPosition();

    }

    public void FreezerPlayer2() // Funcion que freeza al player2
    {
        jugador2.GetComponent<CarVerdeMovement>().StartFreezer();
        freezer.GetComponent<Freezer>().StartFreezerPosition();
    }

    public void StopGoalPlayer1() 
    {
        stopGoalIzquierdo.GetComponent<StopGoalIzquierdo>().StartStopGoalIzquierdo();
        stopGoal.GetComponent<StopGoal>().StartStopGoalPosition();

    }

    public void StopGoalPlayer2()
    {
        stopGoalDerecho.GetComponent<StopGoalDerecho>().StartStopGoalDerecho();
        stopGoal.GetComponent<StopGoal>().StartStopGoalPosition();
    }

}
