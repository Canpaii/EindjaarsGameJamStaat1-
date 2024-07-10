using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCollider : MonoBehaviour
{
    public TMP_Text scoreTextP1, scoreTextP2;
    public bool player1;
    public bool infiniteScore;
    public int scoreToWin;
    public GameObject p2Panel, p1Panel;
    public float p1Score, p2Score;
    public BeachBall beachBall;
    public FireWork fireWork; 
    public FireWork2 fireWork2; 
    public AudioClip fireWorks;

    public void Start()
    {
        scoreTextP1.text = p1Score.ToString();
        scoreTextP2.text = p2Score.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            if (player1)
            {
                AddPointsP2();
                scoreTextP2.text = p2Score.ToString();
                beachBall.ResetBeachBallP2();
                fireWork.SpawnFireworks(15);
                SFXManager.instance.PlaySFXClip(fireWorks, transform, 0.2f, 1);
            }
            else
            {
                AddPointsP1();
                scoreTextP1.text = p1Score.ToString();
                beachBall.ResetBeachBallP1();
                fireWork2.SpawnFirework2(15);
                SFXManager.instance.PlaySFXClip(fireWorks, transform, 0.2f, 1);
            }
        }
    }

    void AddPointsP1()
    {
        p1Score++;

        if(!infiniteScore)
        {
            if (p1Score == scoreToWin)
            {
                p1Panel.SetActive(true);
                Time.timeScale = 0;
                Cursor.lockState = CursorLockMode.Confined;
            }
        }
       
    }

    void AddPointsP2()
    {
        p2Score++;

        if(!infiniteScore)
        {
            if (p2Score == scoreToWin)
            {
                p2Panel.SetActive(true);
                Time.timeScale = 0;
                Cursor.lockState = CursorLockMode.Confined;
            }
        }   
    }
}