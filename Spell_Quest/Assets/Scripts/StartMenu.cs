using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMenu : MonoBehaviour
{
    public void Easy()
    {
        SceneManager.LoadScene(1);
    }

    public void Medium() 
    {
        SceneManager.LoadScene( 2);
    }

    public void Hard()
    {
        SceneManager.LoadScene(3);
    }

     public void Quit()
    {
        Application.Quit();
    }
}
    

