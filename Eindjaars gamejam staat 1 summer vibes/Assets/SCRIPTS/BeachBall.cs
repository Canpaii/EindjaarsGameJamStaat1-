using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeachBall : MonoBehaviour
{
   public float floatiness = 0.5f; // Higher values make the ball float more
   public float shot;
   public float hitMultiplier;
    public Transform spawn1, spawn2;
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

            rb.AddForce(Vector3.up * shot/100, ForceMode.Impulse);
            // Apply the force to the ball
            rb.AddForce(force, ForceMode.Acceleration);
        }
    }
    public void ResetBeachBall()
    {

    }
}
