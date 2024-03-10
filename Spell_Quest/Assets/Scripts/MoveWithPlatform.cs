using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveWithPlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.name == "Player")
        {
            collider.gameObject.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.name == "Player")
        {
            collider.gameObject.transform.SetParent(null);
        }
    }
}
