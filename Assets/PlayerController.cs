// Kristopher Herbert; PlayerController is used to control the player movement.
// Use W and S to move forward and backwards respectively.
// Use A and D to turn left and right respectively.
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // private variables for movement speed and rotation speed.
    private float speed = 3.0f;
    private float rotSpeed = 90.0f;

    // private variable for the character controller.
    private CharacterController controller;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // This all is used in conjunction with the SimpleMove function to make the player move.
        float horzInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, horzInput * rotSpeed *  Time.deltaTime);

        Vector3 moveDirection = transform.forward * vertInput * speed;

        controller.SimpleMove(moveDirection);
    }
}
