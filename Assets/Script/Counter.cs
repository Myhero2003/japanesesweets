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
    //public  Text scoreText;
    public  TMPro.TMP_Text scoreText;


    //public Text TextFrame;
    void Start()
    {
         //ti=GameObject.Find("Ojc").GetComponent<Stickgenerator>();
         Debug.Log(Ojc);
         //scoreText=this.GetComponentsInChildren<Text>();
         //scoreText.text="0";

    }

    // Update is called once per frame
    void Update()
    {
        int newObjectCount=completedstick.transform.childCount;
        
        if(newObjectCount==Ojc+1)
        {
            //stick増やす処理


            Ojc=newObjectCount;
            Debug.Log(Ojc);
            //scoreText.text=string.Format("{0000}",Ojc);
            scoreText.text=string.Format("{0000}",Ojc);
        }
    }
}
