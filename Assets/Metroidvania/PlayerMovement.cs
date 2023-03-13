using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    //necessary for animations and physics
    private Rigidbody2D rb2D;
    private Animator myAnimator;

    // variables to play with
    public float speed = 2.0f;
    public float horizMovement;// = 1[OR]-1[OR]0
    private void Start()
    {
        // define the gameobjects found on the player
        rb2D = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        
    }
    //handles input for physics
    private void Update()
    {
        // check direction given by player
        horizMovement = Input.GetAxis("Horizontal");
    }

    //handles running the physics
    private void FixedUpdate() 
    {
        // move the character left and right
        rb2D.velocity = new Vector2(horizMovement*speed, rb2D.velocity.y);

        
    }
}
