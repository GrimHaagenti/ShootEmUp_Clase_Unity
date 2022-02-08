using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI_script : MonoBehaviour
{

    int score;
    int prev_score;
    Text text_score;
    // Start is called before the first frame update
    void Start()
    {
       
        
        text_score = GetComponentInChildren<Text>();
        Debug.Log(text_score);
        text_score.text = "SCORE: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
            text_score.text = "SCORE: " + GameManager.score;
        
    }


}
