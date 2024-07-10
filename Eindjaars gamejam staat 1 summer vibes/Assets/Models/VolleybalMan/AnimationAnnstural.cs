using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAnnstural : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.GetComponent<Movement>().walk == true)
        {
            GetComponent<Animator>().SetBool("Walkin", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Walkin", false);
        }
        if (Player.GetComponent<Movement>().jump == true)
        {
            GetComponent<Animator>().SetTrigger("Jump");
        }
    }
}
