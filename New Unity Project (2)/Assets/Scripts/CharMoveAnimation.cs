using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMoveAnimation : MonoBehaviour {

    public float period;
    private float nextActionTime = 0;

    public Sprite s1;
    public Sprite s2;

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
