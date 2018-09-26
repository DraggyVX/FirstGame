using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

    //Movement Variables
    public float moveSpeed;
    public bool moveRight;

    //Wall Variables
    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    public bool hittingWall;

    //Edge Variables
    private bool notAtEdge;
    public Transform EdgeCheck;

	// Update is called once per frame
	void Update () {

        //Defining variables
        notAtEdge = Physics2D.OverlapCircle(EdgeCheck.position, wallCheckRadius, whatIsWall);
        hittingWall = Physics2D.OverlapCircle(EdgeCheck.position, wallCheckRadius, whatIsWall);

        if (hittingWall || !notAtEdge) {
            moveRight = !moveRight;
        } //ends if

        if (moveRight) {
            transform.localScale = new Vector3(-6f, 6f, 6f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        } //ends if

        else {
            transform.localScale = new Vector3(6f, 6f, 6f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        } //ends else

	} //ends update

} //ends class

