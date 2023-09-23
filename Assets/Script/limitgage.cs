using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class limitgage : MonoBehaviour
{
    // Start is called before the first frame update
    private int i = 5;
    public GameObject Finish_Object; //「終了」の画像
    public GameObject BGM;
    public GameObject Life5;
    public GameObject Life4;
    public GameObject Life3;
    public GameObject Life2;
    public GameObject Life1;


    //public GameObject Dango;
    //public GameObject stickGenerator;
    public GameObject GameOverObject;
    public AudioClip damage;
    public AudioClip GameOver;
    Rigidbody2D rd2d1;
    AudioSource audioSource;

    //public TMPro.TMP_Text Limit;
    void Start()
    {
        Finish_Object.SetActive(false);
        //Debug.Log(i);
        audioSource=GetComponent<AudioSource>();
        //rd2d1=Life1.GetComponent<Rigidbody2D>();


        
        //Limit.text=string.Format("{0000}",i);
    }

    // Update is called once per frame
    void Update()
    {
        if(i==0)
        {
            //Debug.Log("game Over");
            BGM.SetActive(false);//BGM消す
            Life5.SetActive(false);
            //Dango.SetActive(false);//団子消す
            //stickGenerator.SetActive(false);//串を消す
            Finish_Object.SetActive(true);//「終了」を表示
            GameOverObject.SetActive(true);
           
            Invoke("ScoreMenu",3.0f);
            //audioSource.Play(GameOver);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Dango"&&i>=1)
        {
        i-=1;
        //Debug.Log(i);
        audioSource.PlayOneShot(damage);
        if(i==4)
        { 
            Life1.SetActive(false);
        }
                if(i==3)
        { 
            Life2.SetActive(false);
        }
                if(i==2)
        { 
            Life3.SetActive(false);
        }
                if(i==1)
        { 
            Life4.SetActive(false);
        }
        //Limit.text=string.Format("{0000}",i);
        }

    }

    void ScoreMenu()
    {
        SceneManager.LoadScene("ScoreMenu");
    }
        

    
}
