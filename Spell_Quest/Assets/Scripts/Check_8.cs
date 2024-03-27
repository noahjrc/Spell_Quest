using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Check_8 : MonoBehaviour
{
    public CPMenu cpMenu; // Assign this in the inspector

    public int listNum;

    public List<string> list22 = new List<string> { "Captore", "Capture", "Capsure" };
    public List<string> list23 = new List<string> { "Capable", "Capible", "Capeable" };
    public List<string> list24 = new List<string> { "Mesure", "Mezure", "Measure" };

    public List<string> checkpointTexts;

    [SerializeField] private AudioSource CaptureSoundEffect;
    [SerializeField] private AudioSource CapableSoundEffect;
    [SerializeField] private AudioSource MeasureSoundEffect;

    private void Start()
    {
        int randomNumber = Random.Range(22, 25);

        if (randomNumber == 22)
        {
            checkpointTexts = list22;
            listNum = 22;
        }
        else if (randomNumber == 23)
        {
            checkpointTexts = list23;
            listNum = 23;
        }
        else if (randomNumber == 24)
        {
            checkpointTexts = list24;
            listNum = 24;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            cpMenu.OpenMenu(checkpointTexts, listNum);
            if(listNum == 22)
            {
                CaptureSoundEffect.Play();
            }
            else if(listNum == 23)
            {
                CapableSoundEffect.Play();
            }

            else
            {
                MeasureSoundEffect.Play();
            }
        }
    }
}