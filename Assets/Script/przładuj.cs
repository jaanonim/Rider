using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class przładuj : MonoBehaviour {

    float timer;
    bool start = false;
    public GameObject ls;

    // Update is called once per frame
    void Update ()
    {
        timer += Time.deltaTime;
        if (start && timer > 2)
        {
            ls.SendMessage("loadlewel", "start");
        }
	}
    public void play()
    {
        start = true;
        timer = 0;
    }
}
