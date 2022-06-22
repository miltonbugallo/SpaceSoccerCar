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

    public GameObject finishMatch;

    public float timeValue = 90;
    public Text timerText;

    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
            DisplayTime(timeValue);
        }
        else
        {
            finishMatchTime(puntajeJugador1,puntajeJugador2);
        }

    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void PuntajeJugador1()
    {
        puntajeJugador1++;
        if (puntajeJugador1 == 5)
        {
            finishGameScore(1);
        }
        textoPuntaje1.text = puntajeJugador1.ToString();
        ResetPosition();
    }

    public void PuntajeJugador2()
    {
        puntajeJugador2++;
        if (puntajeJugador2 == 5)
        {
            finishGameScore(2);
        }
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

    public void finishGameScore(int player)
    {
        
        if (player == 1)
        {
            finishMatch.GetComponent<FinishMatch>().LoadScenePlayer1();
        }
        if (player == 2)
        {
            finishMatch.GetComponent<FinishMatch>().LoadScenePlayer2();
        }
    }

    void finishMatchTime(int puntajeJugador1, int puntajeJugador2)
    {
        
        if (puntajeJugador1 > puntajeJugador2)
        {
            finishMatch.GetComponent<FinishMatch>().LoadScenePlayer1();
        }
        if (puntajeJugador1 < puntajeJugador2)
        {
            finishMatch.GetComponent<FinishMatch>().LoadScenePlayer2();
        }
        //if (puntajeJugador1 == puntajeJugador2)
        //{
        //    finishMatch.GetComponent<FinishMatch>().LoadSceneTie();
        //}
        

    }

}
