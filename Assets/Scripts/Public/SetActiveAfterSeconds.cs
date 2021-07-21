using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveAfterSeconds : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;

    [SerializeField]
    private GameObject canvas2;

    private float time = 5f;
    private bool b = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (b)
        {
            if (time < 0)
            {
                canvas.SetActive(false);
                canvas2.SetActive(true);
                b = false;
            }
            else
            {
                time -= Time.deltaTime;
            }
        }
    }
}
