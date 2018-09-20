using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour {

    //Player movement variables
    public int MoveSpeed;
    public float JumpHeight;
    private bool doubleJump;

    //Player ground controls
    public Transform groundCheck;
    public Transform rotation;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
 
    //potatos
    //Non-slide/stick variable
    private float moveVelocity;

	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate()
	{
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown (KeyCode.Space) && grounded || Input.GetKeyDown(KeyCode.W) && grounded || Input.GetKeyDown(KeyCode.UpArrow) && grounded) {
            Jump();

        }

        //Double Jump code
        if (grounded) {
            doubleJump = false;

        }
        
        if (Input.GetKey(KeyCode.Space) && !doubleJump && !grounded){
            Jump();
            doubleJump = true;

        }

        moveVelocity = 0f;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = MoveSpeed;

        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            // GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = -MoveSpeed;

        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

	}

    //Function Jump
    public void Jump() {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);

    }

}
