using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Check_4 : MonoBehaviour
{
    public CPMenu cpMenu; // Assign this in the inspector

    public int listNum;

    public List<string> list10 = new List<string> { "Apel", "Apple", "Apale" };
    public List<string> list11 = new List<string> { "Pizza", "Petza", "Pitsa" };
    public List<string> list12 = new List<string> { "Huny", "Honey", "Honee" };

    public List<string> checkpointTexts;

    [SerializeField] private AudioSource AppleSoundEffect;
    [SerializeField] private AudioSource PizzaSoundEffect;
    [SerializeField] private AudioSource HoneySoundEffect;

    private void Start()
    {
        int randomNumber = Random.Range(10, 13);

        if (randomNumber == 10)
        {
            checkpointTexts = list10;
            listNum = 10;
        }
        else if (randomNumber == 11)
        {
            checkpointTexts = list11;
            listNum = 11;
        }
        else if (randomNumber == 12)
        {
            checkpointTexts = list12;
            listNum = 12;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            cpMenu.OpenMenu(checkpointTexts, listNum);
            if(listNum == 10)
            {
                AppleSoundEffect.Play();
            }
            else if(listNum == 11)
            {
                PizzaSoundEffect.Play();
            }

            else
            {
                HoneySoundEffect.Play();
            }
        }
    }
}