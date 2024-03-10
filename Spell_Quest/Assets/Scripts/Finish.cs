using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    private AudioSource finishSound;

    private bool IsFinished = false;
    
    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !IsFinished)
        {
            finishSound.Play();

            IsFinished = true;

            //Calls CompleteLevel() with a delay of 2 seconds
            Invoke("CompleteLevel", 2f);
        }
    }

    private void CompleteLevel()
    {
        //Loads the next level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    
}
