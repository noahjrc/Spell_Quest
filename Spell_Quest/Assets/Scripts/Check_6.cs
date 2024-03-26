using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Check_6 : MonoBehaviour
{
    public CPMenu cpMenu; // Assign this in the inspector

    public int listNum;

    public List<string> list16 = new List<string> { "Bloc", "Block", "Blok" };
    public List<string> list17 = new List<string> { "Fense", "Fince", "Fence" };
    public List<string> list18 = new List<string> { "Wrong", "Rong", "Wronge" };

    public List<string> checkpointTexts;

    private void Start()
    {
        int randomNumber = Random.Range(16, 19);

        if (randomNumber == 16)
        {
            checkpointTexts = list16;
            listNum = 16;
        }
        else if (randomNumber == 17)
        {
            checkpointTexts = list17;
            listNum = 17;
        }
        else if (randomNumber == 18)
        {
            checkpointTexts = list18;
            listNum = 18;
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