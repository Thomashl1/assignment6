using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

    public Text scoreText;
    private float timeElapsed = 0f;
	
	// Update is called once per frame
	void Update () {
        timeElapsed += Time.deltaTime;
        scoreText.text = "Time: " + FormatTime (timeElapsed);
	}

    string FormatTime(float value)
    {
        TimeSpan t = TimeSpan.FromSeconds (value);
        return string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
    }
}
