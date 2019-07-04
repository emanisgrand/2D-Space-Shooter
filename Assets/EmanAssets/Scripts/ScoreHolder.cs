using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHolder : MonoBehaviour
{
    public float currentScore;

    public TextMeshProUGUI scoreTextTMPro;

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();    
    }

    void UpdateUI()
    {
        scoreTextTMPro.text = "Score: " + currentScore.ToString();
    }

    public void IncreaseScore(){
        currentScore += 31;
        UpdateUI();
    }
}
