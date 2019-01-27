using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour {

private Rigidbody2D rb;
[SerializeField] private float maxVelocity = 3;
[SerializeField] private float rotS;

private void Start()
{
    rb = GetComponent<Rigidbody2D>();
}

private void Update()
{
    float yAxis = Input.GetAxis("Vertical");
    float xAxis = Input.GetAxis("Horizontal");
    
    ThrustForward(yAxis);
    Rotate(transform, xAxis * -rotS);
    
}

private void ClampVelocity()
{
    float x = Mathf.Clamp(rb.velocity.x, 0, maxVelocity);
    float y = Mathf.Clamp(rb.velocity.y, 0, maxVelocity);
    
    rb.velocity = new Vector2(x,y);
}


private void ThrustForward(float amount)
{
    Vector2 force = transform.up * amount;
    rb.AddForce(force);
}

private void Rotate(Transform t, float amount)
{
    t.Rotate(0,0, amount);
}
}
