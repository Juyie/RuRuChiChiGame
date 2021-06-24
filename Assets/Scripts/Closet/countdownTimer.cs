using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdownTimer : MonoBehaviour
{
    [SerializeField]
    private float time;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            Debug.Log(time);
        }
        if (time < 0) gameObject.SetActive(false);
    }
}
