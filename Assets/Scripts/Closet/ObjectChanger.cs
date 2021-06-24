using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChanger : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objects;

    [SerializeField]
    private bool[] bools;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void change()
    {
        for(int i = 0; i < objects.Length; i++)
        {
            if (bools[i] == true)
                objects[i].SetActive(true);
            else
                objects[i].SetActive(false);
        }
    }
}
