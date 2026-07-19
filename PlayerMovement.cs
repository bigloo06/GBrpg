using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator anim;
    public float moveSpeed;

    private Rigidbody2D rb;

    private float x;
    private float y;

    private float lastX;
    private float lastY;

    private Vector2 input;

    public SpriteRenderer spriteRenderer;
    private bool moving;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        GetInput();
        Animate();
    }

    private void FixedUpdate()
    {
        rb.velocity = input * moveSpeed;
    }

    private void GetInput()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        input = new Vector2(x, y);
        input.Normalize();
    }

    private void Animate()
    {
        if (input.magnitude > 0.1f || input.magnitude < -0.1f)
        {
            moving = true;
        }
        else
        {
            moving = false;
        }
        if (moving)
        {
            lastX = x;
            lastY = y;
            if (x < 0)
            {
                spriteRenderer.flipX = true;
            }
            else if (x > 0)
            {
                spriteRenderer.flipX = false;
            }
        }
        anim.SetFloat("X", lastX);
        anim.SetFloat("Y", lastY);
        anim.SetBool("Moving", moving);
        Debug.Log(x);
    }
}
