using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klocki : MonoBehaviour {

    Rigidbody2D r;
    float timer;
    bool yes;

    // Use this for initialization
    void Start ()
    {
        r = (gameObject.GetComponent<Rigidbody2D>() as Rigidbody2D);
        r.bodyType = RigidbodyType2D.Static;
        yes = false;
	}

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer>0.2&&yes)
        {
            r.bodyType = RigidbodyType2D.Dynamic;
        }
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            timer = 0;
            yes = true;
        }
    }
    
}
