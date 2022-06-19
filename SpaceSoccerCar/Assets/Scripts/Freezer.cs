using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freezer : MonoBehaviour
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
            gameManager.GetComponent<GameManager>().FreezerPlayer2(); // Funcion que freeza al player2

        }
        if (collision.CompareTag("player2"))
        {
            gameManager.GetComponent<GameManager>().FreezerPlayer1(); // Funcion que freeza al player1

        }

    }

    public void Reset()
    {
        pos = new Vector3(Random.Range(-7f, 3.5f), -0.15f, 0); // Posicion en x e y en donde puede aparecer
        transform.position = pos;
    }


    public void StartFreezerPosition()
    {
        StartCoroutine(FreezerPosition());
    }

    public IEnumerator FreezerPosition()
    {
        pos = new Vector3(-12f, -2.0f, 0); // Posicion en x e y fuera de vista para que desaparezca temporalmente
        transform.position = pos;
        yield return new WaitForSeconds(5);
        pos = new Vector3(Random.Range(-7f, 3.5f), -0.15f, 0); // Posicion en x e y en donde puede aparecer
        transform.position = pos;
        
    }

}
