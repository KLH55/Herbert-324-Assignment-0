using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float speed = 3.0f;
    private float rotSpeed = 90.0f;

    private CharacterController controller;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horzInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, horzInput * rotSpeed *  Time.deltaTime);

        Vector3 moveDirection = transform.forward * vertInput * speed;

        controller.SimpleMove(moveDirection);
    }
}
