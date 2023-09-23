using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;
    void Start()
    {
        audioSource=GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound1);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
