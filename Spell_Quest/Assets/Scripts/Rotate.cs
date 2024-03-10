using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    [SerializeField] private float speed = 2f;
    
    private void Update()
    {
       transform.Rotate(0f, 0f, Time.deltaTime * 360 * speed); 
    }
}
