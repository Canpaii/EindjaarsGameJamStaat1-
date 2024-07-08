using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreCollider : MonoBehaviour
{
    public TMP_Text scoreText;
    public bool player1;

    public float p1Score, p2Score;
    public BeachBall beachBall;
    public void Start()
    {
        scoreText.text = p1Score.ToString() + "-" + p2Score.ToString();
    }
   void OnTriggerEnter (Collider other)
   {    
        if(other.tag == ("Ball"))
        {
            if(player1)
            {
                p2Score ++;
                scoreText.text = p1Score.ToString()  +  " - "  +  p2Score.ToString();
                beachBall.ResetBeachBall();
            }
            else
            {
                p1Score ++;
                scoreText.text = p1Score.ToString() + "-" + p2Score.ToString();
                beachBall.ResetBeachBall();
            }
        } 
   }
}
