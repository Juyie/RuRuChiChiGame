using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPromise : MonoBehaviour
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

    // Start is called before the first frame update
    void Start()
    {
        text1.text = PlayerPrefs.GetString("PromiseText1");
        text2.text = PlayerPrefs.GetString("PromiseText2");
        text3.text = PlayerPrefs.GetString("PromiseText3");
        text4.text = PlayerPrefs.GetString("PromiseText4");
        if (PlayerPrefs.GetInt("PromiseCircle1") == 1)
            circle1.SetActive(true);
        if (PlayerPrefs.GetInt("PromiseCircle2") == 1)
            circle2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
