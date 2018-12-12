using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLife : MonoBehaviour {

    public int Health;
    public int PointsToAdd;
    public float DestroyDelay;

	// Use this for initialization
	void Start () {
        Health = 100;
	}

    private void OnCollisionEnter2D(Collision2D collision) {
        if (Health <= 10 && collision.gameObject.layer == 11) {
            scoreManager.AddPoints(PointsToAdd);
            Destroy(gameObject, DestroyDelay);
        }

        else if (collision.gameObject.layer == 11) {
            Health -= 10;
        }
    }
}
