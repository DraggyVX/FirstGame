using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CoinPickup : MonoBehaviour{
    public int pointsToAdd;

	void OnTriggerEnter2D(Collider2D other){
        if (other.GetComponent<Rigidbody2D>()== null){
            return;
        }

        scoreManager.AddPoints(pointsToAdd);

        Destroy(gameObject);
	}
}
