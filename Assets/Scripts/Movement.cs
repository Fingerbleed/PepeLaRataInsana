using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 8.0f;
    public float gravity = -9.81f;
    public float jumpHeight = 3.0f;

    private float horizontalAxis;
    private float verticalAxis;
    private Vector3 verticalMovement;
    private Vector3 velocity;

    private bool isGrounded;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    /*
    public Camera cam;
    public float range = 100.0f;

    private IDamageable collisionObject;

    public Gun[] gun; //arreglo para guardas las pistolas
    private int index;*/


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y <= 0)
        {
            velocity.y = -2.0f;
        }

        verticalMovement = transform.right * horizontalAxis;

        controller.Move(verticalMovement * moveSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2.0f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {

    }
}