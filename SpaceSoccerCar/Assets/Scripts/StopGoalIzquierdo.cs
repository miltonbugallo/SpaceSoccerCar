using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGoalIzquierdo : MonoBehaviour
{
    Vector3 pos;

    void Start()
    {
        Reset();
    }

    public void Reset()
    {
        pos = new Vector3(-15f, -1.7878f, 7.156094f);
        transform.position = pos;
    }

    public void StartStopGoalIzquierdo()
    {
        StartCoroutine(StopGoalPositionIzquierdo());
    }

    public IEnumerator StopGoalPositionIzquierdo()
    {
        pos = new Vector3(-7.484447f, -1.7878f, 0.4931629f); // Posicion 
        transform.position = pos;
        yield return new WaitForSeconds(5);
        pos = new Vector3(-15f, -1.7878f, 0.4931629f); // Posicion 
        transform.position = pos;

    }
}

