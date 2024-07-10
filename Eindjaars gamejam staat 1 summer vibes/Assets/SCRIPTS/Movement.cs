using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float hor;
    private float vert;
    public float speed, jumpHeight, gravity, rayLength;
    public bool player1, grounded;
    private Rigidbody rb;
    private UnityEngine.Vector3 moveDirection;
    public Transform orientation;
    public LayerMask whatIsGround;
    

    bool dashP1;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Inputs();
        CheckGround();
      
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void Inputs()
    {       
        if(player1)
        {
            hor = Input.GetAxisRaw("Horizontal");
            vert = Input.GetAxisRaw("Vertical");

            if(Input.GetKeyDown(KeyCode.Space) && grounded)
            {
                Jump();
            }
        }
        else
        {
            hor = Input.GetAxisRaw("HorizontalP2");
            vert = Input.GetAxisRaw("VerticalP2");

            if(Input.GetKeyDown(KeyCode.RightShift) && grounded)
            {
                Jump();
            }
        }
    }  

    public void MovePlayer()
    {   
        moveDirection = orientation.transform.forward * vert + orientation.transform.right * hor;

        rb.AddForce(UnityEngine.Vector3.down * gravity * Time.deltaTime * 10, ForceMode.Force);

        if(!grounded)
        {
             rb.AddForce(moveDirection.normalized * speed * 50 * Time.deltaTime, ForceMode.Force);
        }
        else
        {
             rb.AddForce(moveDirection.normalized * speed * 100 * Time.deltaTime, ForceMode.Force);
        }
    }

    private void CheckGround()
    {   
        Ray ray = new Ray(transform.position, UnityEngine.Vector3.down);

        grounded = Physics.Raycast(ray, rayLength * 0.5f + 0.2f, whatIsGround);

        if(!grounded)
        {
            rb.drag = 1.5f;
        }
        else
        {
            rb.drag = 1.5f;
        }
    }

    private void Jump()
    {
        rb.velocity = new UnityEngine.Vector3(rb.velocity.x , 0 , rb.velocity.z);

        rb.AddForce(transform.up * jumpHeight, ForceMode.Impulse);
    }
}
