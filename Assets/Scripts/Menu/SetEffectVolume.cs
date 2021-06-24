using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetEffectVolume : MonoBehaviour
{
    public AudioMixer EffectMixer;

    public void SetLevel(float sliderValue)
    {
        EffectMixer.SetFloat("EffectVolume", (Mathf.Log10(sliderValue) + 0.3f) * 20.0f);
    }

    void Start()
    {
        float value;
        bool result = EffectMixer.GetFloat("EffectVolume", out value);
        if (result)
        {
            if (value == 0)
            {
                gameObject.GetComponent<Slider>().value = 0.5013082f;
            }
            else
            {
                Debug.Log(Mathf.Pow(10, (value / 20) + 0.3f));
                gameObject.GetComponent<Slider>().value = Mathf.Pow(10, (value / 20) - 0.3f);
            }
        }
        else
        {
            gameObject.GetComponent<Slider>().value = 0.5013082f;
        }
    }
}
