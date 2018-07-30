using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ziemia : MonoBehaviour {

    // Use this for initialization
    public Transform t;
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector2(t.position.x, transform.position.y);
	}
}
