using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectOn : MonoBehaviour
{
    [SerializeField]
    private GameObject effect;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip clip;

    private float time = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(effect.active == true)
        {
            if(time < 0)
            {
                effect.SetActive(false);
                time = 1.0f;
            }
            time -= Time.deltaTime;
        }
    }

    public void Effect()
    {
        effect.SetActive(true);
        audioSource.clip = clip;
        audioSource.Play();
    }
}
