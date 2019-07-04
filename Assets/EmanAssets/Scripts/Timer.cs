using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerTextTMPro;
    public float currentTime;
    
    // Update is called once per frame
    void Update()
    {
        currentTime = currentTime + Time.deltaTime;
        timerTextTMPro.text = "TIME: " + Mathf.Round(currentTime);
    }
}
