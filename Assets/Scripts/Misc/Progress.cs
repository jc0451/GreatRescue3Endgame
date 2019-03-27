using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    public GameObject N1;
    public GameObject N2;
    public GameObject N3;
    public GameObject N4;
    public GameObject N5;
    public GameObject N6;
    public GameObject N7;
    public GameObject N8;
    private int wavenr;
    private bool bghasmoved=false;
   
    // Start is called before the first frame update
    void Start()
    {
        wavenr = 1;
        transform.position = N1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(BgScroll.MoveBg == true)
        {
            bghasmoved = true;
           
        }
        if(BgScroll.MoveBg == false)
        {
            if (bghasmoved == true)
            {
                bghasmoved = false;
                wavenr++;
            }
                
        }
     
        if (wavenr == 2)
        {
            transform.position = Vector2.MoveTowards(transform.position, N2.transform.position, 30 * Time.deltaTime);
        }
        if (wavenr == 3)
        {
            transform.position = Vector2.MoveTowards(transform.position, N3.transform.position, 30 * Time.deltaTime);
        }
        if (wavenr == 4)
        {
            transform.position = Vector2.MoveTowards(transform.position, N4.transform.position, 30 * Time.deltaTime);
        }
        if (wavenr == 5)
        {
            transform.position = Vector2.MoveTowards(transform.position, N5.transform.position, 30 * Time.deltaTime);
        }
        if (wavenr == 6)
        {
            transform.position = Vector2.MoveTowards(transform.position, N6.transform.position, 30 * Time.deltaTime);
        }
        if (wavenr == 7)
        {
            transform.position = Vector2.MoveTowards(transform.position, N7.transform.position, 30 * Time.deltaTime);
        }
        if (wavenr == 8)
        {
            transform.position = Vector2.MoveTowards(transform.position, N8.transform.position, 30 * Time.deltaTime);
        }
    }
}
