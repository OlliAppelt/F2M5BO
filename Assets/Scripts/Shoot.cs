using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float shootVelocity = 500f;

    private new Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        //rigidbody.MovePosition(Vector3.forward * shootVelocity + rigidbody.position * Time.deltaTime);
        rigidbody.AddForce(transform.forward * shootVelocity);
    }

    private void Update()
    {
       // rigidbody.MovePosition(Vector3.forward * shootVelocity + rigidbody.position * Time.deltaTime);
    }
}