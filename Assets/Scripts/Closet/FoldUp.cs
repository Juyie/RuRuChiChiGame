using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoldUp : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObject1;

    [SerializeField]
    private GameObject gameObject2;

    [SerializeField]
    private GameObject upper;

    [SerializeField]
    private GameObject pants;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip clip;

    public void changeImage()
    {
        audioSource.clip = clip;
        audioSource.Play();
        gameObject1.SetActive(true);
        gameObject2.SetActive(true);
        upper.SetActive(false);
        pants.SetActive(false);
        gameObject.SetActive(false);
    }
}
