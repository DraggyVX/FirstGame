﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvL0 : MonoBehaviour {

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
