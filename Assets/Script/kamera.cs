using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour {

    public Transform gracz;


    void Update()
    {
        if (gracz != null)
        {
            transform.position = gracz.position + new Vector3(3.5f, 0, -1);
        }
    }
}
