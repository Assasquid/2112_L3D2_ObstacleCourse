using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1;
    Vector2 moveInput;
    Rigidbody myRigidBody;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Move();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }

    void Move()
    {
        Vector3 playerVelocity = new Vector3 (  moveInput.x * moveSpeed * Time.deltaTime, 
                                                myRigidBody.velocity.y,     
                                                moveInput.y * moveSpeed * Time.deltaTime);

        myRigidBody.velocity = playerVelocity;
    }
}
