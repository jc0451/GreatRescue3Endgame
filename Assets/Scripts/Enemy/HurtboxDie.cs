﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtboxDie : MonoBehaviour
{
    float time = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            Destroy(gameObject);
        }
    
    }

}
