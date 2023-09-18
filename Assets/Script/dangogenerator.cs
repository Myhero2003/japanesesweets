using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dangogenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject greenPrefab;
    float span =3.0f; //生成速度
    float delta=0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta+=Time.deltaTime;
        if(this.delta>this.span)
        {
            this.delta=0;
            GameObject go =Instantiate(greenPrefab);
            int px = Random.Range(-10,10);
            int py = Random.Range(12,20);
            go.transform.position=new Vector2(px,py);
        }

    }
}
