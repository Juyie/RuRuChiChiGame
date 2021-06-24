using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAudio : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = clip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AudioPlay()
    {
        audioSource.Play();
    }
}
