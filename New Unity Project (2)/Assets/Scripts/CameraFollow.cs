using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public CharMove pc;

    public bool isFollowing;

    public float xOffset;
    public float yOffset;


	// Use this for initialization
	void Start () {
        pc = FindObjectOfType<CharMove>();

        isFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
        if(isFollowing) {
            transform.position = new Vector3(pc.transform.position.x + xOffset, pc.transform.position.y + yOffset, transform.position.z);

        }
	}
}
