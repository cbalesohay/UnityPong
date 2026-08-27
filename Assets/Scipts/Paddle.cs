using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float id;
    public float moveSpeed = 2f;

    private void Update()
    {
        float movement = ProcessInput();
        Move(movement);
    }

    private float ProcessInput()
    {
        float movement = 0f;

        if (id == 1)
        {
            movement = Input.GetAxis("MovePlayer1");
        }
        else if (id == 2)
        {
            movement = Input.GetAxis("MovePlayer2");
        }

        return movement;
    }

    private void Move(float movement)
    {
        Vector2 velocity = rb2d.linearVelocity;
        velocity.y = movement * moveSpeed;
        rb2d.linearVelocity = velocity;
    }
}
