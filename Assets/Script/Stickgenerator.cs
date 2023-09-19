using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stickgenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject completedstick;
    public GameObject newstick;
    public int Ojc=0;//初期値０

    public AudioClip sound1;
    AudioSource audioSource;

    //private Text t;
    //public string subText = "";

    //int newObjectCount=completedstick.transform.childCount;
    //public int startObjectCount=this.transform.childCount;
    void Start()
    {
        //Debug.Log(Ojc);
        //t = gameObject.GetComponent<Text>();
        audioSource=GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        int newObjectCount=completedstick.transform.childCount;
        
        if(newObjectCount==Ojc+1)
        {
            //stick増やす処理


            Ojc=newObjectCount;
            //Debug.Log(Ojc);//作った串団子の数
            Instantiate(newstick);
            audioSource.PlayOneShot(sound1);
        }
    }
    
}
