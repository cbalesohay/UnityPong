using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ball : MonoBehaviour
{
    public GameManager gameManager;
    public Rigidbody2D rb2d;
    public float maxInitialAngle = 0.15f; // 8.5 degrees in radians
    public float moveSpeed = 1f;
    public float startX = 0f;
    public float startY = 0f;

    private void Start()
    {
        InitialPush();
    }

    private void InitialPush()
    {
        Vector2 direction = Vector2.left;

        if (Random.value < 0.5f)
        {
            direction = Vector2.right;
        }

        direction.y = Random.Range(-maxInitialAngle, maxInitialAngle);
        rb2d.linearVelocity = direction * moveSpeed;
    }

    private void ResetBall()
    {
        Vector2 startPosition = new Vector2(startX, startY);
        transform.position = startPosition;

    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        ScoreZone scoreZone = trigger.GetComponent<ScoreZone>();

        if (scoreZone == null)
        {
            Debug.LogWarning("The trigger does not have a ScoreZone component.");
            return;
        }

        gameManager.OnScoreZoneReached(scoreZone.id);
        ResetBall();
        InitialPush();
    }
}
