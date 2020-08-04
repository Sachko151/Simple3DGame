using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Movement movement;
    public GameObject endGamePanel;
    public GameObject winGamePanel;
    public GameObject jumpBoostPanel;
    public GameObject blinkAbilityPanel;
    
    public void EndGame()
    {
        movement.movementIsEnabled = false;
        endGamePanel.SetActive(true);
    }

    public void winGame()
    {
        winGamePanel.SetActive(true);
    }

    public void showJumpBoostPanel()
    {
            jumpBoostPanel.SetActive(true);
    }

    public void showBlinkAbilityPanel()
    {
            blinkAbilityPanel.SetActive(true);   
    }
    public void hideBlinkAbilityPanel()
    {
            blinkAbilityPanel.SetActive(false);
        }
    }
   

