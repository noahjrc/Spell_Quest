using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    private int MelonCounter = 0;

    [SerializeField] private Text MelonText;
    [SerializeField] private AudioSource CollectSound;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Melon"))
        {
            collision.gameObject.SetActive(false);
            MelonCounter += 1;
            MelonText.text = "Melons: " + MelonCounter;
            CollectSound.Play();

            //Destroy(collision.gameObject);
        }

    }
}
