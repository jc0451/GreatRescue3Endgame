using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Animator m_Animator;
    AudioSource m_MyAudioSource;
    public static int health = 5;
    public static bool pierceshot = false;
    public static bool multishot = false;

    public float piercingtime = 5f;
    public float multiTime = 5f;
    public static float timeelapsedP = 0;
    public static float timeelapsedM = 0;
    private float ImmunityTimer = 0;


    public GameObject PwSound;
    private GameObject PwSoundInstace;
    public GameObject dethloc;
    public GameObject dethparticle;

    public GameObject top;
    public GameObject left;
    public GameObject right;
    public GameObject bottom;

    private Vector2 topb;
    private Vector2 leftb;
    private Vector2 rightb;
    private Vector2 bottomb;
    private Vector2 playerpos;

    [SerializeField]
    private float speed = 3.0f; //Change this to change the speed of the player character

    Transform PlayerManager;

    private Vector2 direction;
    private Vector2 orgpos;
    void Die()
    {
        dethparticle = Instantiate(dethparticle) as GameObject;
        dethparticle.transform.position = dethloc.transform.position;
        Destroy(gameObject);
    }

    void Start()
    {
        Time.timeScale = 1.0f;
        m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.SetBool("IsWalking", false);
        m_Animator.SetBool("Backwards", false);
        topb = top.transform.position;
        bottomb = bottom.transform.position;
        rightb = right.transform.position;
        leftb = left.transform.position;

        timeelapsedP = piercingtime;
        timeelapsedM = multiTime;

        orgpos.x = -64;
        orgpos.y = -2;
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    void Awake()
    {
        PlayerManager = transform.Find("PlayerManager");
    }

    void Update() //Calls functions once per frame
    {
        if (BgScroll.MoveBg == true)
        {
            m_Animator.SetBool("IsWalking", true);
        }
            playerpos = gameObject.transform.position;
        if (pierceshot == true)
        {
            PlayerBullet.pierce = true;
            if (BgScroll.MoveBg == false)
            {
                timeelapsedP -= Time.deltaTime;
            }

            if (timeelapsedP <= 0)
            {
                pierceshot = false;
                PlayerBullet.pierce = false;
                timeelapsedP = piercingtime;
            }

        }

        if (multishot == true)
        {
            PlayerGun.multi = true;
            if (BgScroll.MoveBg == false) {
                timeelapsedM -= Time.deltaTime;
            }
            
            if (timeelapsedM <=0)
            {
                multishot = false;
                PlayerGun.multi = false;
                timeelapsedM = multiTime;
            }
        }

        if (health > 5)
        {
            health = 5;
        }
        if (health <= 0)
        {
            m_MyAudioSource.Play();
            Die();
        }
        if (ImmunityTimer > 0)
        {
            ImmunityTimer -= Time.deltaTime;
        }
        //if (BgScroll.MoveBg == false)
        //{
        GetInput();
        PlayerMovement();
        //}
        //if (BgScroll.MoveBg == true)
        // {
        //gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, orgpos, 70 * Time.deltaTime);
        //}
    }


    private void GetInput()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            if (playerpos.y <= topb.y - 12)
            {
                direction += Vector2.up;
            }
            m_Animator.SetBool("IsWalking", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            m_Animator.SetBool("IsWalking", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (playerpos.x >= leftb.x + 11)
            {

                direction += Vector2.left;
            }
            m_Animator.SetBool("Backwards", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            m_Animator.SetBool("Backwards", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (playerpos.y >= bottomb.y + 15)
            {
                direction += Vector2.down;
            }
            m_Animator.SetBool("IsWalking", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
            m_Animator.SetBool("IsWalking", false);

        if (Input.GetKey(KeyCode.D))
        {
            if (playerpos.x <= rightb.x - 12)
            {
                direction += Vector2.right;
            }
            m_Animator.SetBool("IsWalking", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
            m_Animator.SetBool("IsWalking", false);
    }

    public void PlayerMovement()
    {
        //This will move the player according to their direction * speed * time in seconds
        transform.Translate(direction * speed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        //checks if colliding with enemies
        if (ImmunityTimer <= 0)
        {
            if (col.gameObject.tag == "RangedEnemy1" || col.gameObject.name == "EnemyBulletGO(Clone)" || col.gameObject.tag =="chadb")
            {
                HealthScore.HealthValue -= 1;
                m_MyAudioSource.Play();
                health--;

                ImmunityTimer = 0.2f;
            }
        }
        //checks if colliding with piercing powerup
        if (col.gameObject.tag == "piercing")
        {
            PwSoundInstace = Instantiate(PwSound) as GameObject;
            if (pierceshot == false)
            {
                pierceshot = true;
            }
            else if(pierceshot==true)
            {
                timeelapsedP += piercingtime;
            }
            
        }
        if (col.gameObject.tag == "Powerup")
        {
            PwSoundInstace = Instantiate(PwSound) as GameObject;

        }

        if (col.gameObject.tag == "multi")
        {
            PwSoundInstace = Instantiate(PwSound) as GameObject;
           
            if (multishot == false)
            {
                multishot = true;
            }
            else if (multishot == true)
            {
               timeelapsedM += multiTime;
            }
        }
        //checks is colliding with enemy hurtbox
      

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (ImmunityTimer <= 0)
        {
            if (col.gameObject.tag == "pointy" || col.gameObject.tag == "laser" || col.gameObject.tag == "RangedEnemy1" || col.gameObject.tag == "chadb")
            {
                HealthScore.HealthValue -= 1;
                m_MyAudioSource.Play();
                health--;

                ImmunityTimer = 0.2f;
            }
        }
    }

}
