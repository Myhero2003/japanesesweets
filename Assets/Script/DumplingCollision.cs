using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumplingCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb2d;
    //public GameObject bump2;
    //public GameObject bump1;
  

    void Start()
    {
        rb2d=GetComponent<Rigidbody2D>();
        //Vector2 startposi=this.transform.position; //スタートの初期地点
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 nowposi=this.transform.position; //毎フレームごとの地点
        //Debug.Log(posi);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Destroy")
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.tag=="Get")//１個ゲットしたら…
        {
            //Debug.Log("ゲット");
            Vector2 collisionposi=collision.gameObject.transform.position;
            //Debug.Log(collisionposi);
 
            //Destroy(collision.gameObject);
            //nowposi.x=collisionposi.x;
            //nowposi.y=collisionposi.y;
            GameObject stick= GameObject.Find("stick");
            GameObject get=this.gameObject;
            if(stick!=null && get!=null)
            {
                get.transform.parent=stick.transform;

            }


            GameObject stick2= GameObject.Find("stick(Clone)");
            if(stick2!=null && get!=null)
            {
                get.transform.parent=stick2.transform;
                
            }
            rb2d.velocity=Vector2.zero;
            rb2d.simulated=false; //重力なし
            


            //this.transform.position=collision.gameObject.transform.position;
 

        }


    } 

    
}
