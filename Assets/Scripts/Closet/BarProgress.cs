using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarProgress : MonoBehaviour
{
    public Image bar;
    public RectTransform rectTransform;
    public float value = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        changeGage(value);
    }

    void changeGage(float value)
    {
        float amount = (value / 100.0f) * 180.0f / 360.0f;
        bar.fillAmount =  amount;
        float buttonAngle = amount * 360;
        rectTransform.eulerAngles = new Vector3(0, 0, -buttonAngle);
    }
}
