using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class loadscene : MonoBehaviour {

    public GameObject screan;
    public Slider slider;

    public TextMeshProUGUI text;
	
	public void loadlewel (string name)
    {
        Time.timeScale = 1f;
        StartCoroutine(LoadAsynchronusly(name));
	}

     IEnumerator LoadAsynchronusly (string name)
     {
        AsyncOperation op = SceneManager.LoadSceneAsync(name);

        screan.SetActive(true);


        while(!op.isDone)
        {
            float progress = Mathf.Clamp01(op.progress / .9f);

            slider.value = progress;
            text.text = Mathf.Round(progress * 100) + "%";

            yield return null;

        }
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}
