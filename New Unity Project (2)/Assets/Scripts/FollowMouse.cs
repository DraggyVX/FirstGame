using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {

    public float depth = 10.0f;
    
    void LateUpdate() {
        FollowMousePosition();
    }
	
    void FollowMousePosition() {
        var mousePos = Input.mousePosition;
        var wantedPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, depth));
        transform.position = wantedPos;
    }
}
