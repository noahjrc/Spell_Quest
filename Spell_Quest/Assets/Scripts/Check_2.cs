using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Check_2 : MonoBehaviour
{
    public CPMenu cpMenu; // Assign this in the inspector

    public int listNum;

    public List<string> list4 = new List<string> { "Het", "Hit", "Hut" };
    public List<string> list5 = new List<string> { "Blue", "Blu", "Blooe" };
    public List<string> list6 = new List<string> { "Bean", "Been", "Ban" };

    public List<string> checkpointTexts;

    private void Start()
    {
        int randomNumber = Random.Range(4, 7);

        if (randomNumber == 4)
        {
            checkpointTexts = list4;
            listNum = 4;
        }
        else if (randomNumber == 5)
        {
            checkpointTexts = list5;
            listNum = 5;
        }
        else if (randomNumber == 6)
        {
            checkpointTexts = list6;
            listNum = 6;
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