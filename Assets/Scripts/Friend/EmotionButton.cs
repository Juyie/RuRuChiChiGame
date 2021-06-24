using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionButton : MonoBehaviour
{
    [SerializeField]
    private GameObject[] consoles;

    [SerializeField]
    private float[] times;

    private bool bTag;
    private int num;

    // Start is called before the first frame update
    void Start()
    {
        bTag = true;
        num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(times[0] < 0 && bTag)
        {
            consoles[0].SetActive(true);
            consoles[1].SetActive(false);
            consoles[2].SetActive(false);
            consoles[3].SetActive(false);
            bTag = false;
        }

        if(times[0] > 0)
            times[0] -= Time.deltaTime;
    }
}
