using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chad : MonoBehaviour
{
    private Vector2 target1;
    private Vector2 target2;
    private Vector2 target3;
    private Vector2 target4;
    private Vector2 target5;
    private Vector2 target6;
    private Vector2 position;

    public GameObject deathloc;
    public GameObject DeathSound;
    public GameObject DeathParticle;

    public GameObject targ1;
    public GameObject targ2;
    public GameObject targ3;
    public GameObject targ4;
    public GameObject targ5;
    public GameObject targ6;

    public float speed;
    public int health = 3;
    public float time;
    public float timec;
    public float waittime;
    public float colortime = 0.5f;

    private bool wait=true;
    private int posnr;
    private bool changecolor = false;
    private bool move1 = false;
    private bool move2 = false;
    private bool move3 = false;
    private bool move4 = false;
    private bool move5 = false;
    private bool move6 = false;


    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        posnr = 1;
        target1 = targ1.transform.position;
        target2 = targ2.transform.position;
        target3 = targ3.transform.position;
        target4 = targ4.transform.position;
        target5 = targ5.transform.position;
        target6 = targ6.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {

           
            DeathParticle = Instantiate(DeathParticle) as GameObject;
            DeathParticle.transform.position = deathloc.transform.position;
            DeathSound.transform.position = gameObject.transform.position;
            Destroy(gameObject);
        }

        if (changecolor == true)
        {
            timec += Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 255);
            if (timec >= colortime)
            {
                timec = 0;
                changecolor = false;
                GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
            }
        }

        position = transform.position;
        position = gameObject.transform.position;
        if (move1 == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target1, speed * Time.deltaTime);
        }
        if (move2 == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target2, speed * Time.deltaTime);
        }
        if (move3 == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target3, speed * Time.deltaTime);
        }
        if (move4 == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target4, speed * Time.deltaTime);
        }
        if (move5 == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target5, speed * Time.deltaTime);
        }
        if (move6 == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target6, speed * Time.deltaTime);
        }
        

        if (wait == true)
        {
            time += Time.deltaTime;
           
            if (time >=waittime)
            {
                time = 0;
                wait = false;
                if (posnr == 1)
                {
                    move1 = true;
                    wait = true;
                    if (position == target1)
                    {
                        move1 = false;
                        posnr++;
                        
                       
                    }
                }
                if (posnr == 2)
                {
                    move2 = true;
                    wait = true;
                    if (position == target2)
                    {
                        move2 = false;
                        
                        posnr++;
                    }
                }
                if (posnr == 3)
                {
                    move3 = true;
                    wait = true;
                    if (position == target3)
                    {
                        move3 = false;
                        
                        posnr++;
                    }
                }
                if (posnr == 4)
                {
                    move4 = true;
                    wait = true;
                    if (position == target4)
                    {
                        move4 = false;
                       
                        posnr++;
                    }
                }
                if (posnr == 5)
                {
                    move5 = true;
                    wait = true;
                    if (position == target5)
                    {
                        move5 = false;
                       
                        posnr++;
                    }
                }
                if (posnr == 6)
                {
                    move6 = true;
                    wait = true;
                    if (position == target6)
                    {
                        move6 = false;
                       
                        posnr=1;
                    }
                }
            }
        }


    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.name == "BulletPrefab(Clone)")
        {

            changecolor = true;
            health--;
        }
    }

}
