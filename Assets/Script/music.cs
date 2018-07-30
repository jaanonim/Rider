using UnityEngine;
using System.Collections;

public class music : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Application.LoadLevel("Start");
    }

}
