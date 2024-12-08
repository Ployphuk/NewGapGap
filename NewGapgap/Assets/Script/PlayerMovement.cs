using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed; // Movement speed
    private Rigidbody2D Playerrigidbody;
    private Vector3 change;
    private Animator animator;
    private bool isMoving;

    public LayerMask collisionLayer; // Layer for objects that block the player

    void Start()
    {
        Playerrigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        UpdateAnimationAndMove();
    }

    void UpdateAnimationAndMove()
    {
        if (change != Vector3.zero)
        {
            if (CanMove())
            {
                MoveCharacter();
                animator.SetFloat("moveX", change.x);
                animator.SetFloat("moveY", change.y);
                animator.SetBool("isMoving", true);
            }
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }

    void MoveCharacter()
    {
        Playerrigidbody.MovePosition(transform.position + change * speed * Time.deltaTime);
    }

    bool CanMove()
    {
        
        Vector2 moveDirection = change.normalized;
        float moveDistance = speed * Time.fixedDeltaTime;

      
        RaycastHit2D hit = Physics2D.Raycast(transform.position, moveDirection, moveDistance, collisionLayer);

        if (hit.collider != null)
        {
           
            return false; 
        }

        return true; 
    }
}
