using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject startPanel, optionsPanel;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0;
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

}
