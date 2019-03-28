using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChadGun : MonoBehaviour
{

    AudioSource m_MyAudioSource;
    public GameObject soundeffect;
    private GameObject soundinstance;
    public GameObject EnemyBulletGO;
    float time;
    float wait;
    float ult;
    bool ultrue=false;
    private bool waited = false;
    public float fireratemin = 1;
    public float fireratemax = 5;
    private float firerate;
    public float ultime;



    // Start is called before the first frame update
    void Start()
    {
        wait = 0;
        firerate = Random.Range(fireratemin, fireratemax);
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (ult >= ultime)
        {
            ultrue = true;
        }
        if (ultrue == true)
        {
            time += Time.deltaTime;

            if (time >= firerate-0.5f)
            {
                time = 0;

                ResetFire();
                soundinstance = Instantiate(soundeffect) as GameObject;
                soundinstance.transform.position = gameObject.transform.position;
                Invoke("FireEnemyBullet", 0.1f);
                Invoke("FireEnemyBullet", 0.15f);
                Invoke("FireEnemyBullet", 0.2f);
                Invoke("FireEnemyBullet", 0.25f);
                Invoke("FireEnemyBullet", 0.3f);
                Invoke("FireEnemyBullet", 0.35f);
                Invoke("FireEnemyBullet", 0.4f);
                Invoke("FireEnemyBullet", 0.45f);
                Invoke("FireEnemyBullet", 0.5f);
                Invoke("FireEnemyBullet", 0.55f);
                Invoke("FireEnemyBullet", 0.6f);
                Invoke("FireEnemyBullet", 0.65f);
                Invoke("FireEnemyBullet", 0.7f);
                Invoke("FireEnemyBullet", 0.75f);
                Invoke("FireEnemyBullet", 0.8f);
                Invoke("FireEnemyBullet", 0.85f);
            }



        }
        
        if (ultrue == false)
        {
            ult += Time.deltaTime;
            if (waited == false)
            {
                wait += Time.deltaTime;
            }
            if (BgScroll.MoveBg == false)
            {

                if (wait >= 3)
                {
                    waited = true;
                    time += Time.deltaTime;

                    if (time >= firerate)
                    {
                        time = 0;

                        ResetFire();
                        soundinstance = Instantiate(soundeffect) as GameObject;
                        soundinstance.transform.position = gameObject.transform.position;
                        Invoke("FireEnemyBullet", 0.1f);
                        Invoke("FireEnemyBullet", 0.15f);
                        Invoke("FireEnemyBullet", 0.2f);
                        Invoke("FireEnemyBullet", 0.25f);
                        Invoke("FireEnemyBullet", 0.3f);
                        Invoke("FireEnemyBullet", 0.35f);
                        Invoke("FireEnemyBullet", 0.4f);
                        Invoke("FireEnemyBullet", 0.45f);
                    }
                }
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
            

        }
    }
}

