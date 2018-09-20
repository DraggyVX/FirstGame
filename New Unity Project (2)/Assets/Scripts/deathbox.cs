using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathbox : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
        if (other.name == "PC"){
            Debug.Log("Player Enter death Zone");
            Destroy(other);
        }
	}
}

