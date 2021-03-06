﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHurtBox : MonoBehaviour
{
    Animator m_Animator;
    AudioSource m_MyAudioSource;
    public GameObject hurtbox;
    public float time= 5.0f;
    private float timeactual;
   
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        m_MyAudioSource = GetComponent<AudioSource>();
        timeactual = time;
    }

    // Update is called once per frame
    void Update()
    {
        timeactual -= Time.deltaTime;
     
        if(timeactual <= 0.0f)
        {
            GameObject hurtboxob = (GameObject)Instantiate(hurtbox);
            m_MyAudioSource.Play();
            m_Animator.SetTrigger("H");
            hurtboxob.transform.position = gameObject.transform.position;
            timeactual = time;
        }
     
    }
}
  
