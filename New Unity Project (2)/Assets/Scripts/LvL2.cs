using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvL2 : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D other)
    {

        SceneManager.LoadScene("LvL2");

    }
}
