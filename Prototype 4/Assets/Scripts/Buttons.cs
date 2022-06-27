using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void ResetButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    
    public void QuitButton()
    {
        Application.Quit();
    }


    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            ResetButton();
        }
    }
}
