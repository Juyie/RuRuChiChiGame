using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAudioPlayOnAwake : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip clip;

    private bool b;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = clip;
        b = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (b)
        {
            audioSource.Play();
            b = false;
        }
    }
}
