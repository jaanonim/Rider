using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class sterowanieS : MonoBehaviour {

    public Slider s1;
    public Slider s2;
    public Slider s3;
    public Slider s4;
    public Slider s5;
    public Slider s6;
    public TextMeshProUGUI t1;
    public TextMeshProUGUI t2;
    public TextMeshProUGUI t3;
    public TextMeshProUGUI t4;
    public TextMeshProUGUI t5;
    public TextMeshProUGUI t6;
    public auto a;
    public PhysicsMaterial2D p;
    public SkinsData skins;

    // Use this for initialization
    public void ok() {
        s1.value = a.speed;
        t1.text = a.speed.ToString();

        s2.value = a.maxSpeed;
        t2.text = a.maxSpeed.ToString();

        s3.value = a.speedRot;
        t3.text = a.speedRot.ToString();

        s4.value = a.maxSpeedRot;
        t4.text = a.maxSpeedRot.ToString();

        s5.value = p.friction;
        t5.text = p.friction.ToString();

        s6.value = p.bounciness;
        t6.text = p.bounciness.ToString();
    }
    private void Start()
    {
        a.speed = PlayerPrefs.GetFloat("s", a.speed);
        a.maxSpeed = PlayerPrefs.GetFloat("ms", a.maxSpeed);
        a.speedRot = PlayerPrefs.GetFloat("rs", a.speedRot);
        a.maxSpeedRot = PlayerPrefs.GetFloat("mrs", a.maxSpeedRot);

        ok();
    }

    public void Skin(int v)
    {
         
        a.t = skins.s[v];
        PlayerPrefs.SetInt("skin", v);

    }



}
