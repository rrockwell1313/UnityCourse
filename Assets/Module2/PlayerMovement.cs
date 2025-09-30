using System;
using UnityEngine;

// Simple demo script for Module2 showing variables, lifecycle methods, and basic movement
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Start()
    {

    }

    void Update()
    {
        HandleRawMovement();
    }

    private void HandleRawMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + Vector3.forward * (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + Vector3.back * (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + Vector3.left * (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + Vector3.right * (moveSpeed * Time.deltaTime);
        }
    }
    
    private void HandleMovement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 moveInput = new(horizontal, 0f, vertical);
        transform.position = transform.position + moveInput * (moveSpeed * Time.deltaTime);
    }
}
