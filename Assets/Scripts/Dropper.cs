using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToDrop;
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    void Update()
    {
        if(Time.time > timeToDrop)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
