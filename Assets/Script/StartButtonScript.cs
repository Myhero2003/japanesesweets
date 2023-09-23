using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip sound;

    AudioSource audioSource;
    void Start()
    {
        audioSource=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        LetsStart();
    }
    public void OnClickStartButton()
    {
        
        audioSource.PlayOneShot(sound);
        Invoke("GoMain",1.0f);
        
    }
    void LetsStart()
    {
        if(Input.GetKey(KeyCode.Return))
        {
        
        audioSource.PlayOneShot(sound);
        Invoke("GoMain",1.0f);  
        }
    }
    void GoMain()
    {
        SceneManager.LoadScene("GameMain");
    }
}
