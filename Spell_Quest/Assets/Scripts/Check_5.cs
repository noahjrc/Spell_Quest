using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Check_5 : MonoBehaviour
{
    public CPMenu cpMenu; // Assign this in the inspector

    public int listNum;

    public List<string> list13 = new List<string> { "Lait", "Lite", "Light" };
    public List<string> list14 = new List<string> { "Tiger", "Tyger", "Tigur" };
    public List<string> list15 = new List<string> { "Hapie", "Happy", "Hapy" };

    public List<string> checkpointTexts;

    [SerializeField] private AudioSource LightSoundEffect;
    [SerializeField] private AudioSource TigerSoundEffect;
    [SerializeField] private AudioSource HappySoundEffect;

    private void Start()
    {
        int randomNumber = Random.Range(13, 16);

        if (randomNumber == 13)
        {
            checkpointTexts = list13;
            listNum = 13;
        }
        else if (randomNumber == 14)
        {
            checkpointTexts = list14;
            listNum = 14;
        }
        else if (randomNumber == 15)
        {
            checkpointTexts = list15;
            listNum = 15;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            cpMenu.OpenMenu(checkpointTexts, listNum);
            if(listNum == 13)
            {
                LightSoundEffect.Play();
            }
            else if(listNum == 14)
            {
                TigerSoundEffect.Play();
            }

            else
            {
                HappySoundEffect.Play();
            }
        }
    }
}