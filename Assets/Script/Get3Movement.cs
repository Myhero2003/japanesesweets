using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get3Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject stick;//成功した串団子
    public Transform clear;
    //public GameObject newstick=Resources.Load("stick"); //新しい串
    public Transform SpawnPoint;//生成場所

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Dango")
        {
            
            Destroy(gameObject);
            Destroy(collision.gameObject);
            //Component[] components =stick.GetComponentsInChildren<Component>();
            foreach(Transform child in clear)
            {
                Destroy(child.gameObject);
            }
            //Vector2 nowposi=clearstick.transform.position;
            //nowposi.x+=10f;


            //明日はここから！！！！！！！！！！！！！！！！！！！！！！
            stick.SetActive(false);//成功した串を非表示にする
            GameObject completedstick= GameObject.Find("Completedstick");//個数を数えるための部屋を見つける
            GameObject StickGenerator= GameObject.Find("Stick Generator");



            stick.transform.parent=completedstick.transform;//部屋に入れる作業







            //Destroy(clearstick);
            //GameObject nextstick= Instantiate(newstick);
            //nextstick.transform.position=new Vector2(SpawnPoint.position.x,SpawnPoint.position.y);


        }
    }
}
