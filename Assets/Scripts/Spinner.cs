using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float spinSpeed;

    void FixedUpdate()
    {
        transform.Rotate
        (
            transform.rotation.x, 
            -spinSpeed * Time.deltaTime, 
            transform.rotation.z
        );
    }
}
