using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Check_9 : MonoBehaviour
{
    public CPMenu cpMenu; // Assign this in the inspector

    public int listNum;

    public List<string> list25 = new List<string> { "Exclude", "Xclude", "Excloode" };
    public List<string> list26 = new List<string> { "Generul", "General", "Genral" };
    public List<string> list27 = new List<string> { "Already", "Allready", "Alredy" };

    public List<string> checkpointTexts;

    private void Start()
    {
        int randomNumber = Random.Range(25, 28);

        if (randomNumber == 25)
        {
            checkpointTexts = list25;
            listNum = 25;
        }
        else if (randomNumber == 26)
        {
            checkpointTexts = list26;
            listNum = 26;
        }
        else if (randomNumber == 27)
        {
            checkpointTexts = list27;
            listNum = 27;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            cpMenu.OpenMenu(checkpointTexts, listNum);
        }
    }
}