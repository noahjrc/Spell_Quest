using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public Button myButton; // Assign this in the inspector
    private List<string> buttonTexts = new List<string> { "Play", "Start", "Go", "Run", "Begin" };

    private void Start()
    {
        RandomizeButtonText();
    }


private void RandomizeButtonText()
{
    if (myButton == null)
    {
        Debug.LogError("myButton is not assigned in the inspector");
        return;
    }

    int index = Random.Range(0, buttonTexts.Count);
    string randomText = buttonTexts[index];
    TextMeshProUGUI textMesh = myButton.GetComponentInChildren<TextMeshProUGUI>();

    if (textMesh != null)
    {
        textMesh.text = randomText;
    }
    else
    {
        Debug.LogError("No TextMeshProUGUI component found in the children of myButton");
    }
}
}