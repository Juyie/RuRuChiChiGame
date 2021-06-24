using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Clapping : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    private GameManager3 gameManager;

    [SerializeField]
    private GameObject bar;

    [SerializeField]
    private GameObject effect;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip clip;

    private bool b;

    public void OnPointerDown(PointerEventData eventData)
    {
        bar.GetComponent<Slider>().value += 0.05f;
    }

    // Start is called before the first frame update
    void Start()
    {
        b = true;   
    }

    // Update is called once per frame
    void Update()
    {
        if(bar.GetComponent<Slider>().value == 1.0f && b)
        {
            bar.SetActive(false);
            effect.SetActive(true);
            audioSource.clip = clip;
            audioSource.Play();
            gameManager.SetBool();
            b = false;
        }
    }
}
