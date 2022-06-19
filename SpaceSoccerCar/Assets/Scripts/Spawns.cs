using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns : MonoBehaviour
{
    public GameObject[] newPowerUp;

    public void SpawnsReset() 
    {
        GameObject Newobject = Instantiate(newPowerUp[0], this.transform) as GameObject;
        Newobject.transform.localPosition = new Vector3(Random.Range(-5f,5f), -2.0f, 0);

    }
    
}
