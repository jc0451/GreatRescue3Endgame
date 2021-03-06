﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyGun : MonoBehaviour
{

    AudioSource m_MyAudioSource;
    public GameObject EnemyBulletGO;
    public GameObject soundeffect;
    private GameObject soundinstance;

    float time;
    public float fireratemin=1;
    public float fireratemax=5;
    private float firerate;
  


    // Start is called before the first frame update
    void Start()
    {
      
        firerate = Random.Range(fireratemin, fireratemax);
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (BgScroll.MoveBg == false)
        {
            time += Time.deltaTime;
           
            if (time >= firerate)
            {
                time = 0;

                ResetFire();
                SendMessageUpwards("shootanim");
                Invoke("FireEnemyBullet",0.2f);
            }
        }

    }
    void ResetFire()
    {
        firerate = Random.Range(fireratemin, fireratemax);
    }
   

    void FireEnemyBullet()
    {
        GameObject player = GameObject.Find("PlayerCharacter");
        if (player != null)
        {
            
            GameObject bullet = (GameObject)Instantiate(EnemyBulletGO);
            bullet.transform.position = transform.position;
            Vector2 direction = player.transform.position - bullet.transform.position;
            bullet.GetComponent<EnemyBullet>().SetDirection(direction);
            soundinstance = Instantiate(soundeffect) as GameObject;
            soundinstance.transform.position = gameObject.transform.position;

        }
    }
}

