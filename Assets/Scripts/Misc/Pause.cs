using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool resumed = false;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        if(resumed == true)
        {
            Time.timeScale = 1.0f;
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            resumed = false;
        }

    }
}
