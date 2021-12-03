using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_movement : MonoBehaviour
{
    private Rigidbody rb;

    public float maxVelocity = 3;
    public float RotationSpeed = 2;
    public float speed = 1f;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        float yAxis = Input.GetAxis("Hover");
        float xAxis = Input.GetAxis("Horizontal");
            
        ThrustForward(yAxis * speed);
        Rotate(transform, xAxis * -RotationSpeed);
    }

    private void ClampVelocity()
    {
        float x = Mathf.Clamp(rb.velocity.x, -maxVelocity, maxVelocity);
        float y = Mathf.Clamp(rb.velocity.x, -maxVelocity, maxVelocity);

        rb.velocity = new Vector2(x,y);
    }

    private void ThrustForward(float amount)
    {
        Vector2 force = transform.up * amount;

        rb.AddForce(force);
    }

    private void Rotate(Transform t, float amount, int x = 0, int y = 0)
    {
        t.Rotate(x, y, amount);
    }
}
