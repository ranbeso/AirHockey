using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float MaxMovementSpeed;
    private Rigidbody2D rb;
    private Vector2 startingPosition;

    public Rigidbody2D Ball;

    public Transform PlayerBoundaryHolder;
    private Boundary playerBoundary;

    public Transform BallBoundaryHolder;
    private Boundary ballBoundary;

    private Vector2 targetPosition;

    private bool isFirstTimeInOpponentsHalf = true;
    private float offset;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingPosition = rb.position;

        playerBoundary = new Boundary(PlayerBoundaryHolder.GetChild(0).position.y,
                                      PlayerBoundaryHolder.GetChild(1).position.y,
                                      PlayerBoundaryHolder.GetChild(2).position.x,
                                      PlayerBoundaryHolder.GetChild(3).position.x);

        ballBoundary = new Boundary(BallBoundaryHolder.GetChild(0).position.y,
                                      BallBoundaryHolder.GetChild(1).position.y,
                                      BallBoundaryHolder.GetChild(2).position.x,
                                      BallBoundaryHolder.GetChild(3).position.x);
    }
    private void FixedUpdate()
    {
        float movementSpeed;

        if (Ball.position.y < ballBoundary.Up)
        {
            if (isFirstTimeInOpponentsHalf)
            {
                isFirstTimeInOpponentsHalf = false;
                offset = Random.Range(-1f, 1f);
            }
            movementSpeed = MaxMovementSpeed * Random.Range(0.1f, 0.3f);
            targetPosition = new Vector2(Mathf.Clamp(Ball.position.x + offset, playerBoundary.Left, playerBoundary.Right), startingPosition.y);

        }
        else
        {
            isFirstTimeInOpponentsHalf = true;

            movementSpeed = Random.Range(MaxMovementSpeed * 0.4f, MaxMovementSpeed);
            targetPosition = new Vector2(Mathf.Clamp(Ball.position.x, playerBoundary.Left, playerBoundary.Right), Mathf.Clamp(Ball.position.y, playerBoundary.Up, playerBoundary.Down));

        }
        rb.MovePosition(Vector2.MoveTowards(rb.position, targetPosition, movementSpeed * Time.fixedDeltaTime));
    }
}
