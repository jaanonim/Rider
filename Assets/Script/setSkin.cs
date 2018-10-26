using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setSkin : MonoBehaviour {

    public auto a;
    public SkinsData s;
    Image i;

    private void Start()
    {
        i = gameObject.GetComponent<Image>() as Image;
    }

    // Update is called once per frame
    void Update () {

        if (PlayerPrefs.GetInt("skin", -1) == -1)
        {
            i.sprite = a.t;
        }
        else
        {
            i.sprite = s.s[PlayerPrefs.GetInt("skin", 0)];
        }

	}
}
