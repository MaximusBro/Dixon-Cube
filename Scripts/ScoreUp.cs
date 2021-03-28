using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUp : MonoBehaviour
{
    public Text scoreText;
    public float score;
    public float pointIncr;

    
    
    
    void Start()
    {
        score = 0f;
        pointIncr = 1f;

        
    }

    void Update()
    {
        scoreText.text = (int)score + " ";
        score += pointIncr * Time.deltaTime;
       
    }
    


}
