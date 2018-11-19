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
    public Sprite s3, s4;
    private int spriteNumber;
    private SpriteRenderer spriteRenderer;
    private float nextActionTime = 0;
    public float period;

    //Non-slide/stick variable
    private float moveVelocity;

	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
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
        
        if (Input.GetKey(KeyCode.Space) && !doubleJump && !grounded || Input.GetKey(KeyCode.W) && !doubleJump && !grounded){
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

        if (GetComponent<Rigidbody2D>().velocity.x > 0){
            transform.localScale = new Vector3(5f, 5f, 5f);
        }
        else if (GetComponent<Rigidbody2D>().velocity.x < 0) {
            transform.localScale = new Vector3(-5f, 5f, 5f);
        }

	}

    //Function Jump
    public void Jump() {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
        while (Time.time > nextActionTime)
        {
            if (Time.time > nextActionTime)
            {
                if (spriteNumber == 1)
                {
                    spriteRenderer.sprite = s4;
                    spriteNumber = 2;
                }
                else
                {
                    spriteRenderer.sprite = s3;
                    spriteNumber = 1;
                }
                nextActionTime += period;
            }
        }

        /*for (int i = 0; i < spriteNumber; i++){
            if (i == 1 && Time.time > nextActionTime)
            {
                spriteRenderer.sprite = s3;
                spriteNumber++;
                i++;
            }
            else if (i == 2 && Time.time > nextActionTime)
            {
                spriteRenderer.sprite = s4;
                spriteNumber++;
                i++;
            }
            else if (i == 3 && Time.time > nextActionTime)
            {
                spriteRenderer.sprite = s5;
                spriteNumber++;
                i++;
            }
            else if (i == 4 && Time.time > nextActionTime)
            {
                spriteRenderer.sprite = s6;
                spriteNumber++;
                i++;
            }
            else if (i == 5 && Time.time > nextActionTime)
            {
                spriteRenderer.sprite = s7;
                spriteNumber++;
                i++;
            }
            else if (i == 6 && Time.time > nextActionTime)
            {
                spriteRenderer.sprite = s8;
                spriteNumber++;
                i++;
            }
            else
            {
                spriteRenderer.sprite = s9;
                spriteNumber = 1;
                i++;
            }
            nextActionTime += period;
        }
        */

    }

}
