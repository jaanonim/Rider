using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gracz : MonoBehaviour {

    // Use this for initialization
    public Rigidbody2D r;
    public auto auto;
    public bool kolizja;
    public bool move;
    public bool ded;
    public GameObject bum;
    public float timer;
    private Vector3 lastPosition;
    public float m;
    public GameObject o;

    private void Start()
    {
        SpriteRenderer s = gameObject.GetComponent<SpriteRenderer>() as SpriteRenderer;
        s.sprite = auto.t;
        auto.speed = PlayerPrefs.GetFloat("s", auto.speed);
        auto.maxSpeed = PlayerPrefs.GetFloat("ms", auto.maxSpeed);
        auto.speedRot = PlayerPrefs.GetFloat("rs", auto.speedRot);
        auto.maxSpeedRot = PlayerPrefs.GetFloat("mrs", auto.maxSpeedRot);
    }
    // Update is called once per frame
    void Update () {

        timer += Time.deltaTime;
        m=speed();


        if(Input.GetButtonDown("Fire1"))
        {
            move = true;
        }
        if(Input.GetButtonUp("Fire1"))
        {
            move = false;
        }


        //Debug.Log(r.angularVelocity);
    }

    private void FixedUpdate()
    {
        if (move)
        {
            if (!kolizja)
            {
                if (auto.maxSpeedRot * 10 > r.angularVelocity)
                {

                    r.AddTorque(auto.speedRot * Time.fixedDeltaTime);
                }
            }
            else
            {

                if (auto.maxSpeed > m)
                {
                    Vector2 move = new Vector2(auto.speed, 0) * Time.fixedDeltaTime;
                    r.AddForce(transform.rotation * move);

                }
            }
        }
        else
        {
            if((auto.maxSpeedRot/20 < r.angularVelocity) &&(!kolizja))
            {
                r.AddTorque(-auto.speedRot/50* Time.deltaTime);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        kolizja = true;
        if(collision.gameObject.tag=="del")
        {
            del();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        kolizja = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        timer = 0;
      
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(timer>0.5f)
        {
            del();
        }

    }
 
    void del()
    {
        gameObject.SendMessage("save");
        Destroy(Instantiate(bum, transform.position, Quaternion.Euler(Vector3.up)), 1.5f);
        o.SendMessage("play");
        Destroy(gameObject);
    }


    private float speed()
    {
        float S = (((transform.position - lastPosition).magnitude) / Time.deltaTime);
        lastPosition = transform.position;
        return S;
    }
}
        