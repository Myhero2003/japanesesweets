using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitgage : MonoBehaviour
{
    // Start is called before the first frame update
    public int i = 3;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(i<=0)
        {
            //Debug.Log("game Over");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Dango")
        {
        i-=1;
        //Debug.Log(i);
        }

    }
        

    
}
