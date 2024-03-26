using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Check_7 : MonoBehaviour
{
    public CPMenu cpMenu; // Assign this in the inspector

    public int listNum;

    public List<string> list19 = new List<string> { "Ability", "Abilety", "Abilitey" };
    public List<string> list20 = new List<string> { "Distroy", "Destroi", "Destroy" };
    public List<string> list21 = new List<string> { "Nirvous", "Nervous", "Nervus" };

    public List<string> checkpointTexts;

    private void Start()
    {
        int randomNumber = Random.Range(19, 22);

        if (randomNumber == 19)
        {
            checkpointTexts = list19;
            listNum = 19;
        }
        else if (randomNumber == 20)
        {
            checkpointTexts = list20;
            listNum = 20;
        }
        else if (randomNumber == 21)
        {
            checkpointTexts = list21;
            listNum = 21;
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