using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousefollower : MonoBehaviour
{

    Vector3 mousePosition;
    public float MoveSpeed = 0.1f;
    Rigidbody2D rb;
    Vector2 position = Vector2.zero;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition); 
        position = Vector2.Lerp(transform.position, mousePosition, MoveSpeed);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(position);
    }

}
