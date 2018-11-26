using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public Transform firePoint;

    public GameObject projectile;

    public float Period;

    private float NextAction = 0;

    private int totalSpawnObjects = 0;

    public float period;
    private float nextActionTime = 0;

    public Sprite s1, s2;

    private int spriteNumber;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //projectile = Resources.Load("Prefabs/projectile") as GameObject;
    }

	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Mouse0) && totalSpawnObjects < 5) {
            Instantiate(projectile, firePoint.position, firePoint.rotation);
            if (Time.time > nextActionTime) {
                if (spriteNumber == 1) {
                    spriteRenderer.sprite = s2;
                    spriteNumber = 2;
                }
                else {
                    spriteRenderer.sprite = s1;
                    spriteNumber = 1;
                }
                nextActionTime += period;
                
            }
            
        } 
        
	}
    
}
