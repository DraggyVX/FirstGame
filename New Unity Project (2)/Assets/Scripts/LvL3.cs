using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvL3 : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer != 0 && other.gameObject.layer != 11)
            SceneManager.LoadScene("LvL3");

    }
}
