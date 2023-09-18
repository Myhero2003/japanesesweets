using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            Move();
    }
    //棒の移動
    void Move()
    {
        Vector2 position = transform.position;

        if(Input.GetKey("left"))
        {
            position.x-=speed;

        }
        else if(Input.GetKey("right"))
        {
            position.x+=speed;
        }
        transform.position=position;
    }
}
