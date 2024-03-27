using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Check_1 : MonoBehaviour
{
    public CPMenu cpMenu; // Assign this in the inspector

    public int listNum;

    public List<string> list1 = new List<string> { "Cat", "Kat", "Cate" };
    public List<string> list2 = new List<string> { "Doge", "Dug", "Dog" };
    public List<string> list3 = new List<string> { "Bole", "Bowl", "Bol" };

    public List<string> checkpointTexts;

    [SerializeField] private AudioSource CatSoundEffect;
    [SerializeField] private AudioSource DogSoundEffect;
    [SerializeField] private AudioSource BowlSoundEffect;

    private void Start()
    {
        int randomNumber = Random.Range(1, 4);

        if (randomNumber == 1)
        {
            checkpointTexts = list1;
            listNum = 1;
            

        }
        else if (randomNumber == 2)
        {
            checkpointTexts = list2;
            listNum = 2;
            
        }
        else if (randomNumber == 3)
        {
            checkpointTexts = list3;
            listNum = 3;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            cpMenu.OpenMenu(checkpointTexts, listNum);
            if(listNum == 1)
            {
                CatSoundEffect.Play();
            }
            else if(listNum == 2)
            {
                DogSoundEffect.Play();
            }

            else
            {
                BowlSoundEffect.Play();
            }
        }
    }
}