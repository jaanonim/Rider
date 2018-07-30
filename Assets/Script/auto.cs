using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="NewAuto", menuName ="Auto")]

public class auto : ScriptableObject
{
    public float speed;
    public float maxSpeed;
    public float speedRot;
    public float maxSpeedRot;
    public Sprite t;

    public void S(float v)
    {
        speed = v;
        PlayerPrefs.SetFloat("s", v);
    }
    public void MaxS(float v)
    {
        maxSpeed = v;
        PlayerPrefs.SetFloat("ms", v);
    }
    public void RotS(float v)
    {
        speedRot = v;
        PlayerPrefs.SetFloat("rs", v);
    }
    public void MaxRotS(float v)
    {
        maxSpeedRot = v;
        PlayerPrefs.SetFloat("mrs", v);
    }
    public void Skin(Sprite v)
    {
        t = v;
    }

}


