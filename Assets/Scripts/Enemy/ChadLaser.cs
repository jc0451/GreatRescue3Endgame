using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChadLaser : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    public GameObject hurtbox;
    public float time = 4.0f;
    private float timeactual;
    float wait;
    float ult;
    bool ultrue = false;

    // Start is called before the first frame update
    void Start()
    {
        wait = 0;
        m_MyAudioSource = GetComponent<AudioSource>();
        timeactual = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (ult >= 10)
        {
            ultrue = true;
        }
        if (ultrue == true)
        {
            gameObject.transform.GetChild(6).gameObject.SetActive(true);
            var hurtboxob = (GameObject)Instantiate(hurtbox);
            hurtboxob.transform.position = gameObject.transform.position;
            hurtboxob.transform.parent = gameObject.transform;

        }
        if (ultrue == false)
        {
            ult += Time.deltaTime;
            timeactual -= Time.deltaTime;


            if (timeactual <= 2.0f)
            {


                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                gameObject.transform.GetChild(5).gameObject.SetActive(true);

            }
            if (timeactual <= 1.9f)
            {

                gameObject.transform.GetChild(1).gameObject.SetActive(true);
                gameObject.transform.GetChild(0).gameObject.SetActive(false);


            }
            if (timeactual <= 1.8f)
            {

                gameObject.transform.GetChild(2).gameObject.SetActive(true);
                gameObject.transform.GetChild(1).gameObject.SetActive(false);

            }
            if (timeactual <= 1.7f)
            {

                gameObject.transform.GetChild(3).gameObject.SetActive(true);
                gameObject.transform.GetChild(2).gameObject.SetActive(false);

            }
            if (timeactual <= 1.6f)
            {

                gameObject.transform.GetChild(4).gameObject.SetActive(true);
                gameObject.transform.GetChild(3).gameObject.SetActive(false);

            }
            if (timeactual <= 1.5f)
            {
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                gameObject.transform.GetChild(4).gameObject.SetActive(false);
            }
            if (timeactual <= 1.4f)
            {
                gameObject.transform.GetChild(1).gameObject.SetActive(true);
                gameObject.transform.GetChild(0).gameObject.SetActive(false);
            }
            if (timeactual <= 1.3f)
            {
                gameObject.transform.GetChild(2).gameObject.SetActive(true);
                gameObject.transform.GetChild(1).gameObject.SetActive(false);
            }
            if (timeactual <= 1.2f)
            {
                gameObject.transform.GetChild(3).gameObject.SetActive(true);
                gameObject.transform.GetChild(2).gameObject.SetActive(false);
            }
            if (timeactual <= 1.1f)
            {
                gameObject.transform.GetChild(4).gameObject.SetActive(true);
                gameObject.transform.GetChild(3).gameObject.SetActive(false);
            }
            if (timeactual <= 1.0f)
            {
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                gameObject.transform.GetChild(4).gameObject.SetActive(false);
            }
            if (timeactual <= 0.9f)
            {
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                gameObject.transform.GetChild(4).gameObject.SetActive(false);
            }
            if (timeactual <= 0.9f)
            {
                gameObject.transform.GetChild(1).gameObject.SetActive(true);
                gameObject.transform.GetChild(0).gameObject.SetActive(false);
            }
            if (timeactual <= 0.8f)
            {
                gameObject.transform.GetChild(2).gameObject.SetActive(true);
                gameObject.transform.GetChild(1).gameObject.SetActive(false);
            }
            if (timeactual <= 0.7f)
            {
                gameObject.transform.GetChild(3).gameObject.SetActive(true);
                gameObject.transform.GetChild(2).gameObject.SetActive(false);
            }
            if (timeactual <= 0.6f)
            {
                gameObject.transform.GetChild(4).gameObject.SetActive(true);
                gameObject.transform.GetChild(3).gameObject.SetActive(false);
            }
            if (timeactual <= 0.5f)
            {
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                gameObject.transform.GetChild(4).gameObject.SetActive(false);
            }
            if (timeactual <= 0.4f)
            {
                gameObject.transform.GetChild(1).gameObject.SetActive(true);
                gameObject.transform.GetChild(0).gameObject.SetActive(false);
            }
            if (timeactual <= 0.3f)
            {
                gameObject.transform.GetChild(2).gameObject.SetActive(true);
                gameObject.transform.GetChild(1).gameObject.SetActive(false);
            }
            if (timeactual <= 0.2f)
            {
                gameObject.transform.GetChild(3).gameObject.SetActive(true);
                gameObject.transform.GetChild(2).gameObject.SetActive(false);
            }
            if (timeactual <= 0.1f)
            {
                gameObject.transform.GetChild(4).gameObject.SetActive(true);
                gameObject.transform.GetChild(3).gameObject.SetActive(false);
            }



            if (timeactual <= 0.0f)
            {
                SendMessageUpwards("shootingup");
                gameObject.transform.GetChild(4).gameObject.SetActive(false);
                gameObject.transform.GetChild(0).gameObject.SetActive(false);
                gameObject.transform.GetChild(5).gameObject.SetActive(false);
                var hurtboxob = (GameObject)Instantiate(hurtbox);
                hurtboxob.transform.position = gameObject.transform.position;
                hurtboxob.transform.parent = gameObject.transform;

                timeactual = time;
            }
        }
    }
}
