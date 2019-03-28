using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiIcon : MonoBehaviour
{

    float t;
    [SerializeField]
    public Renderer Rend1;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        t = PlayerScript.timeelapsedM;
        if (PlayerScript.multishot == true)
        {
            Rend1.enabled = true;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }

        else
        {
            Rend1.enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }

    }
}