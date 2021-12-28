using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float spinSpeed;
    // Rigidbody rigidBody;
    // Vector3 eulerAngleVelocity;

    // void Start()
    // {
    //     rigidBody = GetComponent<Rigidbody>();
    //     eulerAngleVelocity = new Vector3(0, spinSpeed,0);
    // }
    
    void FixedUpdate()
    {
        transform.Rotate
        (
            transform.rotation.x, 
            -spinSpeed * Time.deltaTime, 
            transform.rotation.z
        );
        // Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
        // rigidBody.MoveRotation(rigidBody.rotation * deltaRotation);
    }
}
