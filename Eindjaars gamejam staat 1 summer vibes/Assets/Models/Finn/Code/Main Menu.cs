using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playPress()
    {
        SceneManager.LoadScene("CanScene");         
    }
    public void quitpressed()
    {
        Application.Quit();
    }
}
