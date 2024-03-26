using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class CPMenu : MonoBehaviour
{
     public PlayerLife playerLife; // Assign this in the inspector
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

    public void CloseMenu()
    {
        menuPanel.SetActive(false); // Hide the menu
        Time.timeScale = 1f;
    }

 public void OnButton1Click() {
    switch (chosenNumList) {
        case 1:
            CloseMenu();
            break;
        case 2:
            CloseMenu();
            playerLife.Die();
            break;
        case 3:
            CloseMenu();
            playerLife.Die();
            break;
        case 4:
            CloseMenu();
            playerLife.Die();
            break;
        case 5:
            CloseMenu();
            break;
        case 6: 
            CloseMenu();
            break;
        case 7:
            CloseMenu();
            playerLife.Die();
            break;
        case 8:
            CloseMenu();
            playerLife.Die();
            break;
        case 9:
            CloseMenu();
            playerLife.Die();
            break;
        case 10:
            CloseMenu();
            playerLife.Die();
            break;
        case 11:
            CloseMenu();
            break;
        case 12:
            CloseMenu();
            playerLife.Die();
            break;
        case 13:
            CloseMenu();
            playerLife.Die();
            break;
        case 14:
            CloseMenu();
            break;
        case 15:
            CloseMenu();
            playerLife.Die();
            break;
        case 16:
            CloseMenu();
            playerLife.Die();
            break;
        case 17:
            CloseMenu();
            playerLife.Die();
            break;
        case 18:
            CloseMenu();
            break;
        case 19:
            CloseMenu();
            break;  
        case 20:
            CloseMenu();
            playerLife.Die();
            break;
        case 21:
            CloseMenu();
            playerLife.Die();
            break;
        case 22:
            CloseMenu();
            playerLife.Die();
            break;
        case 23:
            CloseMenu();
            break;
        case 24:
            CloseMenu();
            playerLife.Die();
            break;
        case 25:
            CloseMenu();
            break;
        case 26:
            CloseMenu();
            playerLife.Die();
            break;
        case 27:
            CloseMenu();
            break;
    }
}
 public void OnButton2Click() {
    switch (chosenNumList) {
        case 1:
            CloseMenu();
            playerLife.Die();
            break;
        case 2:
            CloseMenu();
            playerLife.Die();
            break;
        case 3:
            CloseMenu();
            break;
        case 4:
            CloseMenu();
            break;
        case 5:
            CloseMenu();
            playerLife.Die();
            break;
        case 6: 
            CloseMenu();
            playerLife.Die();
            break;
        case 7:
            CloseMenu();
            playerLife.Die();
            break;
        case 8:
            CloseMenu();
            break;
        case 9:
            CloseMenu();
            playerLife.Die();
            break;
        case 10:
            CloseMenu();
            break;
        case 11:
            CloseMenu();
            playerLife.Die();
            break;
        case 12:
            CloseMenu();
            break;
        case 13:
            CloseMenu();
            playerLife.Die();
            break;
        case 14: 
            CloseMenu();
            playerLife.Die();
            break;
        case 15:
            CloseMenu();
            break;
        case 16:
            CloseMenu();
            break;
        case 17:
            CloseMenu();
            playerLife.Die();
            break;
        case 18:
            CloseMenu();
            playerLife.Die();
            break;
        case 19:
            CloseMenu();
            playerLife.Die();
            break;
        case 20:
            CloseMenu();
            playerLife.Die();
            break;
        case 21:
            CloseMenu();
            break;
        case 22:
            CloseMenu();
            break;
        case 23:
            CloseMenu();
            playerLife.Die();
            break;
        case 24:
            CloseMenu();
            playerLife.Die();
            break;
        case 25:
            CloseMenu();
            playerLife.Die();
            break;
        case 26:
            CloseMenu();
            break;
        case 27:
            CloseMenu();
            playerLife.Die();
            break;
    }
}
 public void OnButton3Click() {
    switch (chosenNumList) {
        case 1:
            CloseMenu();
            playerLife.Die();
            break;
        case 2:
            CloseMenu();
            break;
        case 3:
            CloseMenu();
            playerLife.Die();
            break;
       case 4:
            CloseMenu();
            playerLife.Die();
            break;
        case 5:
            CloseMenu();
            playerLife.Die();
            break;
        case 6: 
            CloseMenu();
            playerLife.Die();
            break;
        case 7:
            CloseMenu();
            break;
        case 8:
            CloseMenu();
            playerLife.Die();
            break;
         case 9:
            CloseMenu();
            break;
        case 10:
            CloseMenu();
            playerLife.Die();
            break;
        case 11:
            CloseMenu();
            playerLife.Die();
            break;
        case 12:
            CloseMenu();
            playerLife.Die();
            break;
        case 13:
            CloseMenu();
            break;
        case 14:
            CloseMenu();
            playerLife.Die();
            break;
        case 15:
            CloseMenu();
            playerLife.Die();
            break;
        case 16:
            CloseMenu();
            playerLife.Die();
            break;
        case 17:
            CloseMenu();
            break;
        case 18:
            CloseMenu();
            playerLife.Die();
            break;
        case 19:
            CloseMenu();
            playerLife.Die();
            break;
        case 20:
            CloseMenu();
            break;
        case 21:
            CloseMenu();
            playerLife.Die();
            break;  
        case 22:
            CloseMenu();
            playerLife.Die();
            break;
        case 23:
            CloseMenu();
            playerLife.Die();
            break;
        case 24:
            CloseMenu();
            break;
        case 25:
            CloseMenu();
            playerLife.Die();
            break;
        case 26:    
            CloseMenu();
            playerLife.Die();
            break;
        case 27:
            CloseMenu();
            playerLife.Die();
            break;  
    }
}
}