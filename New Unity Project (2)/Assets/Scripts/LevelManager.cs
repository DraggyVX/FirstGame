using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    
    //Variables
    public GameObject currentCheckPoint;

    public Rigidbody2D PC;

    //Particles
    public GameObject deathParticle;

    public GameObject respawnParticle;

    //Respawn Delay
    public float respawnDelay;

    //Life Penalty on Death
    public int lifePenaltyOnDeath;

    //Store Gravity Value
    private float gravityStore;


	// Use this for initialization
	void Start () {
        //PC = FindObjectOfType<Rigidbody2D>();
	}

    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo(){
        //generate death penealty
        Instantiate(deathParticle, PC.transform.position, PC.transform.rotation); //The first thing is what we want to create (deathParticle), The second thing is where we want it to create it at (players position), Third is the rotation of the player.

        //Hide Player
        //PC.enabled = false;
        PC.GetComponent<Renderer>().enabled = false;

        gravityStore = PC.GetComponent<Rigidbody2D>().gravityScale;
        PC.GetComponent<Rigidbody2D>().gravityScale = 0f;
        PC.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        //life penalty
        scoreManager.AddPoints(-lifePenaltyOnDeath);

        //point message
        Debug.Log("Player respawn");

        //respawn delay
        yield return new WaitForSeconds(respawnDelay);

        //Gravity restore
        PC.GetComponent<Rigidbody2D>().gravityScale = gravityStore;

        //Match Players transform position
        PC.transform.position = currentCheckPoint.transform.position;

        PC.GetComponent<Renderer>().enabled = true;

        Instantiate(respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);

    }
}
