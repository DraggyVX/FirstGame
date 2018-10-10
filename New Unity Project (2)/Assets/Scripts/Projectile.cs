﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed;

    public Rigidbody2D PC;

    public GameObject enemyDeath;

    public GameObject projectileParticle;

    public int pointsForKill;

	// Use this for initialization
	void Start () {
        PC = FindObjectOfType<Rigidbody2D>();
        if (PC.transform.localScale.x < 0) {
            speed = -speed;
        } //Ends if
	} //Ends Start
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.x);
	} //Ends Update

	void OnTriggerEnter(Collider2D other) {
        if (other.tag == "Enemy" || other.tag == "wall"){
            Instantiate(enemyDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            scoreManager.AddPoints(pointsForKill);

        } //Ends if

        Instantiate(projectileParticle, transform.position, transform.rotation);
        Destroy(gameObject);

	} //Ends OnTriggerEnter

} //Ends Class