using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseBackground : MonoBehaviour
{
    [SerializeField]
    private GameObject[] weathers;

    // Start is called before the first frame update
    void Start()
    {
        int n = PlayerPrefs.GetInt("weather");
        weathers[n].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
