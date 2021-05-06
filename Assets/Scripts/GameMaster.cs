using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public GameObject restartPanel;
    public void GoToGameScene()
    {
        SceneManager.LoadScene("TinyPlanets");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Main menu");
    }

    public void GoToPushEffects()
    {
        SceneManager.LoadScene("PushEffects");
    }
    public void PauseButtonPushed()
    {
        restartPanel.SetActive(true);
    }
}
