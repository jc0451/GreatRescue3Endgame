using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P : MonoBehaviour
{
    public static int ScoreValue = 0;
    float t;
    float r;
    Text Score;


    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        t = PlayerScript.timeelapsedP;
        r = Mathf.Round(t);
        Score.text = "" + r;
    }
}
