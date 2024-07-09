using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreCollider : MonoBehaviour
{
    public TMP_Text scoreTextP1, scoreTextP2;
    public bool player1;

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
                p2Score ++;
                scoreTextP2.text = p2Score.ToString();
                beachBall.ResetBeachBallP2();
            }
            else
            {
                p1Score ++;
                scoreTextP1.text = p1Score.ToString();
                beachBall.ResetBeachBallP1();
            }
        } 
   }
}
