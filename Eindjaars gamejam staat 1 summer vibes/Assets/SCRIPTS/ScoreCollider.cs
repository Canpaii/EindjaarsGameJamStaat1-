using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreCollider : MonoBehaviour
{
    public TMP_Text scoreTextP1, scoreTextP2;
    public bool player1;
    public int scoreToWin;

    public GameObject p2Panel, p1Panel;
    public float p1Score, p2Score;
    public BeachBall beachBall;
    public void Start()
    {
        scoreTextP1.text = p1Score.ToString();
        scoreTextP2.text = p2Score.ToString();
    }

   void OnTriggerEnter (Collider other)
   {    
        if(other.tag == ("Ball"))
        {
            if(player1)
            {
                AddPointsP2();

                scoreTextP2.text = p2Score.ToString();
                beachBall.ResetBeachBallP2();
            }
            else
            {
                AddPointsP1();

                scoreTextP1.text = p1Score.ToString();
                beachBall.ResetBeachBallP1();
            }
        } 
   }

   void AddPointsP1()
   {
        p1Score ++;
        if(p1Score == scoreToWin)
        {
            p1Panel.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.Confined;
        }
   }
   void AddPointsP2()
   {
        p2Score ++;
        if(p2Score == scoreToWin)
        {
            p2Panel.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.Confined;
        }
   }
}
