using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class Spin : MonoBehaviour
{
    [SerializeField] float spinSpeed;
    [SerializeField] Rigidbody barRigi;

    private void Update()
    {
        //transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }

    void FixedUpdate()
    {
        //barRigi.maxAngularVelocity = float.MaxValue;
        barRigi.AddTorque(-Vector3.up * 9999);

    }
}
