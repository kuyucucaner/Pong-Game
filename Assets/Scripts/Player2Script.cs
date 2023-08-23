using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour
{
    public float racketSpeed;

    private Rigidbody2D rigidBody2D;

    private Vector2 racketDirection;
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical2");

        racketDirection = new Vector2(0, directionY).normalized;
    }
    private void FixedUpdate()
    {
        rigidBody2D.velocity = racketDirection * racketSpeed;
    }
}
