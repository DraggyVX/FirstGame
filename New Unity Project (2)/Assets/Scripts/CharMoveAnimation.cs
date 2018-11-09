using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMoveAnimation : MonoBehaviour {

    public float period;
    private float nextActionTime = 0;

    public Sprite s1, s2;
    public Sprite s3, s4, s5, s6, s7, s8, s9, s10;

    private int spriteNumber;
    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextActionTime) {
            if (spriteNumber == 1){
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
