using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public GameObject GameOverScreen;
    public GameObject VictoryScreen;
   // public Animator animator;
    //bool MovingRight;
    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.isPaused)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            //animator.SetBool("IsGoingRight?", (movement));
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
       // if (moveSpeed = 0)
        {
            //animator.SetBool("IsGoingRight?", (moveSpeed));
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Zombie"))
        {
            GameOverScreen.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
