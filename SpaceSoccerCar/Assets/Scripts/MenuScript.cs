using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void LoadSceneStart() 
    {
        SceneManager.LoadScene("GameScene");
    }

    public void LoadSceneControles()
    {
        SceneManager.LoadScene("Controles");
    }


}
