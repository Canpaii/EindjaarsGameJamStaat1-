using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BeachBall : MonoBehaviour
{
   public float floatiness; // Higher values make the ball float more
   public float shotup, shotforward;
   public float hitMultiplier;
    public Transform spawn1, spawn2;
    public Transform orientationP1, orientationP2;
    /* public Vector3 windForce = new Vector3(0.5f, 0.0f, 0.0f); // Simulate wind force
 */
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Apply additional upward force to simulate buoyancy
        rb.AddForce(Vector3.up * floatiness, ForceMode.Acceleration);

        // Apply wind force
       /*  rb.AddForce(windForce, ForceMode.Force); */
    }
    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has a Rigidbody
        Rigidbody playerRb = collision.collider.GetComponent<Rigidbody>();
        if (playerRb != null)
        {
            // Calculate the force to apply
            Vector3 force = (playerRb.velocity * hitMultiplier)/95;

            rb.AddForce(Vector3.up * shotup/100, ForceMode.Impulse);
            // Apply the force to the ball
            rb.AddForce(force, ForceMode.Acceleration);

            if (collision.transform.tag == ("Player1"))
            {
                rb.AddForce(orientationP1.right * shotforward/10, ForceMode.Impulse);
            }
            else
            {
                rb.AddForce(-orientationP2.right * shotforward/10, ForceMode.Impulse);
            }
        }
    }
    public void ResetBeachBallP1()
    {
        transform.position = spawn1.position;
        rb.velocity = Vector3.zero;
    }
    public void ResetBeachBallP2()
    {
        transform.position = spawn2.position;
        rb.velocity = Vector3.zero;
    }
}
