using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestTime : MonoBehaviour
{
    static public float seconds;
    static public float mins;

    public Text textS;
    public Text textM;
    void Start()
    {
    }

    void Update()
    {
        seconds += Time.deltaTime;
        textS.text = seconds.ToString("f0");
        if (seconds >= 60)
        {
            seconds = 0;
            mins++;
        }
        textM.text = mins.ToString("f0");
    }
}
