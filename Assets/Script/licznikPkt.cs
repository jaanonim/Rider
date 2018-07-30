using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class licznikPkt : MonoBehaviour {

    public int ptk;
    public int odleglosc = 15;
    public TextMeshProUGUI text;
    public Rigidbody2D r;
    public auto a;
    float timer;
    bool obrut;
    bool koilzja;
    

    void plus()
    {
        ptk++;
        text.text = ptk.ToString();
    }

    // Update is called once per frame
    void Start()
    {
        
        obrut = false;
        ptk = 0;
        text.text = ptk.ToString();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (transform.position.x > odleglosc)
        {
            odleglosc += 10;
            plus();
        }
        //Debug.Log(r.angularVelocity);

        if (timer > 0.5 && !koilzja && obrut && transform.rotation.eulerAngles.z>-10 && transform.rotation.eulerAngles.z < 10)
       {
            plus();
            timer = 0;
            obrut = false;
        }
       else if (!koilzja && !obrut && r.angularVelocity>a.maxSpeedRot/2)
       {
           
           obrut = true;
           timer = 0;
       }
        

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        koilzja = false;
        obrut = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        koilzja = true;
    }

    public void save()
    {
        if(ptk>PlayerPrefs.GetInt("HS",0))
        {
            PlayerPrefs.SetInt("HS", ptk);
        }

    }

}
