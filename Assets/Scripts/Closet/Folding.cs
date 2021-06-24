using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Folding : MonoBehaviour
{
    [SerializeField]
    private GameObject nextImage;

    [SerializeField]
    private GameObject nextSlider;

    [SerializeField]
    private GameObject image;

    [SerializeField]
    private GameObject slider;

    private bool done = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.GetComponent<Slider>().value > 0.9f && done == false)
        {
            nextImage.SetActive(true);
            nextSlider.SetActive(true);
            image.SetActive(false);
            slider.SetActive(false);
            done = true;
            Debug.Log("done");
        }
    }
}
