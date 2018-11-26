using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed;

    public float timeOut;

    public GameObject PC;

    public GameObject enemyDeath;

    public GameObject projectileParticle;

    public int pointsForKill;

	// Use this for initialization
	void Start () {
        PC = GameObject.Find("PC");

        enemyDeath = Resources.Load("Prefabs/deathParticle") as GameObject;

        projectileParticle = Resources.Load("Prefabs/ShootParticle") as GameObject;

        if (PC.transform.localScale.x < 0) {
            speed = -speed;
        } //Ends if
        Destroy(gameObject, timeOut); 

	} //Ends Start

	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
	} //Ends Update

    void OnTriggerEnter2D(Collider2D other) {
        //float time = startTime;
        if (other.tag == "Enemy"){
            Instantiate(enemyDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            scoreManager.AddPoints(pointsForKill);

        } //Ends if
        
        Destroy(gameObject);

	} //Ends OnTriggerEnter

  
	void OnCollisionEnter2D(Collision2D other)
	{
        Instantiate(projectileParticle, transform.position, transform.rotation);
        Destroy(gameObject);
	}
	

} //Ends Class
