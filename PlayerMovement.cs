using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public CharacterController Controller;

    public float speed = 12f;
    public float gravity = -9.8f;
    public float jumpheight = 6f;

    public Transform groundcheck;
    public float groundistance = 0.4f;
    public LayerMask groundmask;
    Vector3 velocity;
    bool isgrounded;


    // Update is called once per frame
    void Update()
    {
        isgrounded = Physics.CheckSphere(groundcheck.position, groundistance, groundmask);
        if (isgrounded && velocity.y < 0){
            velocity.y = -4f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        Controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isgrounded){
            velocity.y = jumpheight;
        }

        velocity.y += gravity * Time.deltaTime * 2;
        Controller.Move(velocity * Time.deltaTime);
        
    }
}
