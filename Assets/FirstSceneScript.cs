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
            ScoreScript.ScoreValue = 0;
            BodyCount.Chad = 0;
            BodyCount.Goblin = 0;
            BodyCount.Troll = 0;
            BodyCount.Orc = 0;
            PlayerBullet.pierce = false;
            PlayerScript.multishot = false;
            PlayerScript.pierceshot = false;


            PlayerScript.health = 5;
            HealthScore.HealthValue = 5;
            UnityEngine.SceneManagement.SceneManager.LoadScene("0. StartScene");
        }


    }
}
