using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("f1"))
        {

            UnityEngine.SceneManagement.SceneManager.LoadScene("0. StartScene");
        }


    }
}
