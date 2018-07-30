using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sliderW : MonoBehaviour {
    

	public void ile (float v)
    {
        TextMeshProUGUI text =gameObject.GetComponent<TextMeshProUGUI>()as TextMeshProUGUI;
        text.text = v.ToString();
        
	}
}
