using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Check_3 : MonoBehaviour
{
    public CPMenu cpMenu; // Assign this in the inspector

    public int listNum;

    public List<string> list7 = new List<string> { "Ked", "Kide", "Kid" };
    public List<string> list8 = new List<string> { "Care", "Car", "Kar" };
    public List<string> list9 = new List<string> { "Bot", "Bute", "But" };

    public List<string> checkpointTexts;

    [SerializeField] private AudioSource KidSoundEffect;
    [SerializeField] private AudioSource CarSoundEffect;
    [SerializeField] private AudioSource ButSoundEffect;

    private void Start()
    {
        int randomNumber = Random.Range(7, 10);

        if (randomNumber == 7)
        {
            checkpointTexts = list7;
            listNum = 7;
        }
        else if (randomNumber == 8)
        {
            checkpointTexts = list8;
            listNum = 8;
        }
        else if (randomNumber == 9)
        {
            checkpointTexts = list9;
            listNum = 9;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            cpMenu.OpenMenu(checkpointTexts, listNum);
            if(listNum == 7)
            {
                KidSoundEffect.Play();
            }
            else if(listNum == 8)
            {
                CarSoundEffect.Play();
            }

            else
            {
                ButSoundEffect.Play();
            }
        }
    }
}