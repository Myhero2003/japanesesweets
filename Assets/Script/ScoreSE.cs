using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreSE : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip score;
    public AudioClip HighScore;
    
    AudioSource audioSource;
    void Start()
    {
        audioSource=GetComponent<AudioSource>();
        if(PlayerPrefs.GetString("update","n")=="y")
        {
            audioSource.PlayOneShot(HighScore);
        }
        else
        {
            audioSource.PlayOneShot(score);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
