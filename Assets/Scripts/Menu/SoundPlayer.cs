using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField]
    AudioClip sound;

    [SerializeField]
    AudioSource audioSource;

    public void click()
    {
        audioSource.clip = sound;
        audioSource.PlayScheduled(2.0f);
    }
}
