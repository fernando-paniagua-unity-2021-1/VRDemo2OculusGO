using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float speed;
    private Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        Destroy(gameObject, 5);
    }

    private void Start()
    {
        rigidbody.AddForce(transform.forward * speed);
    }

    
}
