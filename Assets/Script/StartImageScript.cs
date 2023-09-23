using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartImageScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject startimage;//「開始」の読み込み
    void Start()
    {
        //startimage.SetActive(true);
        Invoke("Noimage",6.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Restart();
        GoHome();
    }

    void Restart()//ゲーム再開のショートカット
    {
        if(Input.GetKey(KeyCode.Space)&&Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("GameMain");
        }
    }
    void GoHome()//ホームメニューへのショートカット
    {
        if(Input.GetKey(KeyCode.Space)&&Input.GetKey(KeyCode.M))
        {
            SceneManager.LoadScene("TitleMenu");
        }

        
    }
    void Noimage()
    {
        startimage.SetActive(false);
    }
}
