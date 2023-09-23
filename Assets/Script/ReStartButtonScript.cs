using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReStartButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip sound1;
    //public AudioClip sound2;
    AudioSource audioSource;
    void Start()
    {
        audioSource=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("GameMain");
        audioSource.PlayOneShot(sound1);
    }
    //void Restart()
    //if()
    //{

    //}
}
