using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pelota;


    public void ResetPosition()
    {
        pelota.GetComponent<BallMovement>().Reset();
    }
}
