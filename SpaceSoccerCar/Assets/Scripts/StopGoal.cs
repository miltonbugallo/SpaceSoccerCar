using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGoal : MonoBehaviour
{
    public GameObject gameManager;
    Vector3 pos;

    public void Start()
    {
        Reset();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player1"))
        {
            gameManager.GetComponent<GameManager>().StopGoalPlayer1(); // Funcion que tapa arco al player1

        }
        if (collision.CompareTag("player2"))
        {
            gameManager.GetComponent<GameManager>().StopGoalPlayer2(); // Funcion que tapa arco al player2

        }

    }

    public void Reset()
    {
        pos = new Vector3(Random.Range(-5f, 5f), -1.2f, 0); // Posicion en x e y en donde puede aparecer
        transform.position = pos;
    }


    public void StartStopGoalPosition()
    {
        StartCoroutine(StopGoalPosition());
    }

    public IEnumerator StopGoalPosition()
    {
        pos = new Vector3(-12f, -2.0f, 0); // Posicion en x e y fuera de vista para que desaparezca temporalmente
        transform.position = pos;
        yield return new WaitForSeconds(5);
        Reset();

    }
}
