﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("3. MainScene");
        }
    }
}