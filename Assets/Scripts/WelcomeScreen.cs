using UnityEngine;

public class WelcomeScreen : MonoBehaviour
{
    public GameObject welcomePanel;

    public void EnterGame()
    {
        welcomePanel.SetActive(false);
    }
}