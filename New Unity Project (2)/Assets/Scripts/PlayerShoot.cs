using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public Transform firePoint;

    public GameObject projectile;

    public float Period;

    private float NextAction = 0;

    private int totalSpawnObjects = 0;

    private void FixedUpdate()
    {
        /*
        if (NextAction <= Time.time)
        {
            Destroy(GameObject.Find("projectile(Clone)"));
        }
        */

    }

	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Mouse0) && totalSpawnObjects < 5) {
            totalSpawnObjects = totalSpawnObjects + 1;
            Instantiate(projectile, firePoint.position, firePoint.rotation);
           // Spawn();
        }
        if (GameObject.Find("projectile(Clone)"))
        {
            Destroy(GameObject.Find("projectile(Clone)"), Period);

        }
        if (totalSpawnObjects >= 5 && NextAction <= Time.time){
            totalSpawnObjects--;
        }

	}
    /*
    void Spawn()
    {
        NextAction = (Time.time + Period);
    }
    */
}
