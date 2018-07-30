using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggs : MonoBehaviour {

    public GameObject l;
    float timer;
    bool ok1 =false;
    bool ok3 = false;
    bool ok2 = false;
    bool ok4 = false;

    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        if(timer<4 && ok1 && ok2 && ok3 &&ok4)
        {
            l.SendMessage("loadlewel", "egg");
        }
    }

    public void b1()
    {
        ok1 = true;
        timer = 0;
    }

    public void b2()
    {
        ok2= true;
    }

    public void b3()
    {
        ok3 = true;
    }

    public void b4()
    {
        ok4 = true;
    }

    public void reset()
    {
        PlayerPrefs.DeleteKey("HS");
    }

    public void back()
    {
        l.SendMessage("loadlewel", "start");
    }
}
