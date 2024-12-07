using System;
using Unity.VisualScripting;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject pauseMenu;

    private void Awake()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    private void Update()
    {
        OpenMenu();
    }

    public void OpenMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void CloseMenu()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
            
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        Application.LoadLevel(0);
    }
    
}
