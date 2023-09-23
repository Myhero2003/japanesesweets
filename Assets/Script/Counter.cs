using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    // Start is called before the first frame update
    //private Stickgenerator ti;
    public GameObject completedstick;
    public int Ojc=0;//初期値０
    public int highscore=0;
    public int score=0;
    public string updatescore;
    //public  Text scoreText;
    public  TMPro.TMP_Text scoreText;



    //public Text TextFrame;
    void Start()
    {
         //ti=GameObject.Find("Ojc").GetComponent<Stickgenerator>();
         //Debug.Log(Ojc);
         //scoreText=this.GetComponentsInChildren<Text>();
         //scoreText.text="0";
         //Ojc=PlayerPrefs.GetInt("SCORE",0)


         //ハイスコアを読み込む
         highscore=PlayerPrefs.GetInt("highscore",0);
         score=PlayerPrefs.GetInt("Score",0);
         PlayerPrefs.SetInt("Score",0);//初期値

         updatescore=PlayerPrefs.GetString("update","n");
         PlayerPrefs.SetString("update","n");//初期値

    }

    // Update is called once per frame
    void Update()
    {
        int newObjectCount=completedstick.transform.childCount;
        
        if(newObjectCount==Ojc+1)
        {
            //stick増やす処理


            Ojc=newObjectCount;
            //Debug.Log(Ojc);
            //scoreText.text=string.Format("{0000}",Ojc);
            scoreText.text=string.Format("{0000}",Ojc);
            SetHighScore(Ojc);
            Debug.Log(highscore);
            PlayerPrefs.SetInt("Score",Ojc);
            PlayerPrefs.Save();

            
        }
    }
    void SetHighScore(int Ojc)
    {
        if(Ojc>highscore)
        {
            //ハイスコア書き換え
            highscore=Ojc;
            PlayerPrefs.SetInt("highscore",highscore);
            PlayerPrefs.SetString("update","y");
            PlayerPrefs.Save();

        }

    }
}
