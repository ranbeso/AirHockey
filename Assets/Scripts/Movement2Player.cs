using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    private Vector2 startingPosition;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingPosition = rb.position;



    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    public void ResetPosition()
    {
        rb.position = startingPosition;
    }
}
