using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody _myBody;
    private float _moveForce = 10f;

    private void Awake()
    {
        _myBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        _myBody.velocity = new Vector3(-h * _moveForce, 0f, 0f );
    }
}
