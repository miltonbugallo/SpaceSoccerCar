using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishMatch : MonoBehaviour
{
    
    public void LoadScenePlayer1()
    {
        SceneManager.LoadScene("Player1Win");
    }

    public void LoadScenePlayer2()
    {
        SceneManager.LoadScene("Player2Win");
    }
}
