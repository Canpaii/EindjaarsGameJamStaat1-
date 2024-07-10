using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject startPanel, optionsPanel, creditsPanel;
    public bool timescale0;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        if(timescale0)
        {
            Time.timeScale = 0;
        }
    }

    public void StartScherm()
    {
        startPanel.SetActive(true);
    }
    public void ResetScene()
    {
        print("click");
        SceneManager.LoadScene("CanScene");
        Time.timeScale = 1;
    }
    public void OpenOptions()
    {
        optionsPanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void Continue()
    {
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void Credits()
    {
        creditsPanel.SetActive(true);
    }
    public void CreditsClose()
    {
        creditsPanel.SetActive(false);
    }

}
