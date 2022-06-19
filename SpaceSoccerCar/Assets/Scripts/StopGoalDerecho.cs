using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGoalDerecho : MonoBehaviour
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

    public void StartStopGoalDerecho()
    {
        StartCoroutine(StopGoalPositionDerecho());
    }

    public IEnumerator StopGoalPositionDerecho()
    {
        pos = new Vector3(7.719666f, -1.7878f, 7.156094f); // Posicion 
        transform.position = pos;
        yield return new WaitForSeconds(5);
        pos = new Vector3(-15f, -1.7878f, 7.156094f); // Posicion 
        transform.position = pos;

    }
}
