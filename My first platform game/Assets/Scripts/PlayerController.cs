using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    private Animator animator;
    private Rigidbody2D rigidbody;


    void Start()
    {
        animator = GetComponent<Animator>();

        rigidbody = GetComponent<Rigidbody2D>();
        animator.Play("Idle", 0, 0.25f);
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");

        rigidbody.MovePosition(rigidbody.position + Vector2.right * moveX * speed * Time.deltaTime);
    }
}
