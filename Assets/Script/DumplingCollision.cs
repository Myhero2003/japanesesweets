using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumplingCollision : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
  

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        //Vector2 startposi=this.transform.position; //スタートの初期地点
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 nowposi=this.transform.position; //毎フレームごとの地点
        //Debug.Log(posi);
        //下に落ちたときに消す
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Destroy")
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.tag=="Get")
        {
            Debug.Log("ゲット");
            //this.transform.position=collision.gameObject.transform.position;
            rb.velocity=Vector2.zero;  

        }
    } 

    
}
