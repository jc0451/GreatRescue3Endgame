using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changescene : MonoBehaviour
{
    [SerializeField]
    public string scenename= "0. StartScene";
    // Start is called before the first frame update
    public void ChangeScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scenename);
    }


    // Update is called once per frame
    void Update()
    { }
       

}
