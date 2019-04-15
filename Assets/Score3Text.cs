using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score3Text : MonoBehaviour
{

    public static int scoreValue2 = 0;
    Text score1;

    // Use this for initialization
    void Start()
    {
        score1 = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score1.text = "Current Score: " + scoreValue2;
    }
}
