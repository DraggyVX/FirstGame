using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void OnTriggerEnter(Collider other) {
        //if (Input.GetKeyDown(KeyCode.F)) {
            SceneManager.LoadScene("LvL1");
        //}
    }
    // Update is called once per frame
    void Update () {

	}

    
}
