using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelgGenerato : MonoBehaviour {

    public generatorinfo[] info;
    public Vector2 position=new Vector2(20.0f,-2f);
    private int r;
    private int ile;
    private int lastR=0;
    public Transform g;
    public List<GameObject> o;

	// Use this for initialization
	void Start () {
        ile = 0;
        for (int i = 0; i < 5; i++)
        {
            Generator();
        }
        
	}

    private void Update()
    {
        if (g != null)
        {
            if (position.x - 30f < g.position.x)
            {
                Generator();
                Destroy(o[ile - 5]);
            }
        }
    }

    // Update is called once per frame
    public void Generator ()
    {
        r = Random.Range(0, info.Length);

        while (lastR==r)
        {
            r = Random.Range(0, info.Length);
        }
        lastR = r;
        o.Add(Instantiate(info[r].prefab, position, Quaternion.Euler(Vector3.zero)));
        ile++;
        position.x += info[r].len;
    }
}
