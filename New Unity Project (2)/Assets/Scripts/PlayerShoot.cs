using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public Transform firePoint;

    public GameObject projectile;

    public float Period;

    private float NextAction = 0;

    public static int totalSpawnObjects;

    public float period;
    private float nextActionTime = 0;

    public Animator animator;

    private int spriteNumber;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        projectile = Resources.Load("Prefabs/projectile") as GameObject;
    }

	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Mouse0) && totalSpawnObjects < 5) {
            Instantiate(projectile, firePoint.position, firePoint.rotation);
            animator.SetBool("isAttacking", true);
            //totalSpawnObjects++; add once added

            }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            animator.SetBool("isAttacking", false);
        }

    } 
        
	}
    

