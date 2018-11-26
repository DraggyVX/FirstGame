using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyonTouch : MonoBehaviour {

	public float DestroyDelay;
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.layer != 0) { //0 is the player layer
            Destroy(gameObject, DestroyDelay);
        }
    }
}
