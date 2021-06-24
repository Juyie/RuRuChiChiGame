using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenClosetButton : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObject1;

    [SerializeField]
    private GameObject gameObject2;

    [SerializeField]
    private GameObject gameObject3;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip dubbing;

    float time = 1.0f;
    bool countdown = false;
    bool b1 = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        if (time > 0 && countdown == true)
        {
            time -= 1 * Time.deltaTime;
            Debug.Log(time);
        }
        if (time < 0 && b1)
        {
            LookWindow();
            audioSource.clip = dubbing;
            audioSource.Play();
            b1 = false;
        }
    }

    public void OpenCloset()
    {
        gameObject1.SetActive(false);
        gameObject3.SetActive(false);
        countdown = true;
    }

    public void LookWindow()
    {
        gameObject2.SetActive(false);
    }
}
