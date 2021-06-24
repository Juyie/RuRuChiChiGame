using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectWeather : MonoBehaviour
{
    [SerializeField]
    private Sprite[] weathers = new Sprite[3];

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip[] dubbing;

    [SerializeField]
    private bool first;

    private bool b = true;
    private float time = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        Image weather = gameObject.GetComponent<Image>();
        weather.sprite = weathers[PlayerPrefs.GetInt("weather")];
    }

    // Update is called once per frame
    void Update()
    {
        if(first && b)
        {
            audioSource.clip = dubbing[PlayerPrefs.GetInt("weather")];
            audioSource.Play();
            b = false;
        }

        if(!first && b)
        {
            if(time < 0)
            {
                audioSource.clip = dubbing[PlayerPrefs.GetInt("weather")];
                audioSource.Play();
                b = false;
            }
            time -= Time.deltaTime;
        }
    }
}
