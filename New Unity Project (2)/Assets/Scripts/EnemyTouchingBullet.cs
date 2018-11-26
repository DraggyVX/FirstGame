using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTouchingBullet : MonoBehaviour {

	public int PointsToAdd;
    public float DestroyDelay;
    
    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.layer == 0) {
            scoreManager.AddPoints(PointsToAdd);
            Destroy(gameObject, DestroyDelay);
        }
    }
}
