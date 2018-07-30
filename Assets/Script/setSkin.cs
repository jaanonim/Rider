using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setSkin : MonoBehaviour {

    public auto a;
	
	// Update is called once per frame
	void Update () {
        Image i = gameObject.GetComponent<Image>() as Image;
        i.sprite = a.t;
	}
}
