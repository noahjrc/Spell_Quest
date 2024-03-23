using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class CPMenu : MonoBehaviour
{
    public GameObject menuPanel; // Assign this in the inspector
    public GameObject button1; // Assign this in the inspector
    public GameObject button2; // Assign this in the inspector
    public GameObject button3; // Assign this in the inspector
    private Dictionary<GameObject, List<List<string>>> checkpointTexts;
    public int chosenNumList;

    private void Start()
    {
        menuPanel.SetActive(false); // Hide the menu at the start
    }

    public void OpenMenu(List<string> checkpointTexts, int listNum)
    {
        menuPanel.SetActive(true); // Show the menu
        Time.timeScale = 0f;
        chosenNumList = listNum;

        TextMeshProUGUI textMesh1 = button1.GetComponentInChildren<TextMeshProUGUI>();
        TextMeshProUGUI textMesh2 = button2.GetComponentInChildren<TextMeshProUGUI>();
        TextMeshProUGUI textMesh3 = button3.GetComponentInChildren<TextMeshProUGUI>();
        // Set the text of each button to the corresponding string from the list
        textMesh1.text = checkpointTexts[0];
        textMesh2.text = checkpointTexts[1];
        textMesh3.text = checkpointTexts[2];
        
    }
}