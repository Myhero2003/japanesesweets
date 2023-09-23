using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreViewer : MonoBehaviour
{
    // Start is called before the first frame update
    
    public  TMPro.TMP_Text HighScore;
    public TMPro.TMP_Text Score;
    void Start()
    {
        HighScore.text=string.Format("{0000}",PlayerPrefs.GetInt("highscore",0));
        Score.text=string.Format("{0000}",PlayerPrefs.GetInt("Score",0));
        
    }

    // Update is called once per frame
    void Update()
    {
        ResetHighScore();
    }

    void ResetHighScore()
    {
        if(Input.GetKey(KeyCode.Space)&&Input.GetKey(KeyCode.LeftShift))
        {
            PlayerPrefs.SetInt("highscore",0);
            PlayerPrefs.Save();
            HighScore.text=string.Format("{0000}",PlayerPrefs.GetInt("highscore",0));
            
        }
    }
}
