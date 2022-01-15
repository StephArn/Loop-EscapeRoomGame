using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform groundCheck;
    public LayerMask groundMask;
    public GameObject backToMenu;

    public float speed = 20f;
    public float gravity = -20f;
    public float groundDistance = 0.4f;
    public float jumpHeight = 3f;

    Vector3 velocity;
    bool isGrounded;
    bool showMenu = false;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Escape))
        {

            if (!showMenu)
            {
                backToMenu.SetActive(true);
                showMenu = true;
            }
            else
            {
                backToMenu.SetActive(false);
                showMenu = false;
            }
        }

        if (showMenu)
        {
            return;
        }

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetButton("Fire3"))  
        {
            speed = 40f;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 20f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if (move.z + transform.position.z <= 1450 || move.x + transform.position.x >= 1750 || move.z + transform.position.z >= 2120 || move.x + transform.position.x <= 600)
        {
            return;
        }

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    } 
}
 