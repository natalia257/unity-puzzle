using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int numberElementInRightPosition;
    public GameObject WinPanel;
    public GameObject StartPanel;

    private void Start()
    {
        LoadMenu();
    }

    public void ResetGame()
    {
        WinPanel.SetActive(false);
        StartPanel.SetActive(false);
    }

    public void AddElementInRightPosition()
    {
        numberElementInRightPosition++;
        if(numberElementInRightPosition == 16)
        {
            FindObjectOfType<Points>().AddPoints(10);
            WinPanel.SetActive(true);
        }
    }

    public void LoadMenu()
    {
        numberElementInRightPosition = 0;
        WinPanel.SetActive(false);
        StartPanel.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
