using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndMenu : MonoBehaviour
{
    public void MainMenu()
    {
       SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
