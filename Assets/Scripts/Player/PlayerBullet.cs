using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField]
    public float bulletVelocity;
    public static bool pierce = false;
    private int pierced = 0;
    AudioSource m_MyAudioSource;
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * bulletVelocity);

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        if ((transform.position.x < min.x) || (transform.position.x > max.x) || (transform.position.y) < min.y || (transform.position.y > max.y))
        { Destroy(gameObject); }
        //  Destroy();
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "RangedEnemy1" || col.gameObject.tag == "orc")
        {
            m_MyAudioSource.Play();
            pierced++;
            if (pierce == false)
            { Destroy(gameObject); }
            if (pierced >= 2)
            {
                ScreenShake.shakeDuration = 0.5f;
            }
        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "chad")
        {
            m_MyAudioSource.Play();
            pierced++;
            if (pierce == false)
            { Destroy(gameObject); }
            if (pierced >= 2)
            {
                ScreenShake.shakeDuration = 0.5f;
            }
        }
    }
}