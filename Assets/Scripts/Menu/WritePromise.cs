using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WritePromise : MonoBehaviour
{
    [SerializeField]
    private Text text1;

    [SerializeField]
    private Text text2;

    [SerializeField]
    private Text text3;

    [SerializeField]
    private Text text4;

    [SerializeField]
    private GameObject circle1;

    [SerializeField]
    private GameObject circle2;

    [SerializeField]
    private GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickCircle1()
    {
        if(circle1.activeSelf == false)
        {
            circle1.SetActive(true);
        }
        else
        {
            circle1.SetActive(false);
        }
    }

    public void ClickCircle2()
    {
        if (circle2.activeSelf == false)
        {
            circle2.SetActive(true);
        }
        else
        {
            circle2.SetActive(false);
        }
    }

    public void ClickSave()
    {
        PlayerPrefs.SetString("PromiseText1", text1.text);
        PlayerPrefs.SetString("PromiseText2", text2.text);
        PlayerPrefs.SetString("PromiseText3", text3.text);
        PlayerPrefs.SetString("PromiseText4", text4.text);
        if (circle1.activeSelf == true)
            PlayerPrefs.SetInt("PromiseCircle1", 1);
        else
            PlayerPrefs.SetInt("PromiseCircle1", 0);
        if (circle2.activeSelf == true)
            PlayerPrefs.SetInt("PromiseCircle2", 1);
        else
            PlayerPrefs.SetInt("PromiseCircle2", 0);

        canvas.SetActive(false);
    }
}
