using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject startPanel, optionsPanel;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
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
    }

}
