using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToNext : MonoBehaviour
{
    [SerializeField]
    private GameObject bubble;

    [SerializeField]
    private GameObject next;

    [SerializeField]
    private float time;

    private bool bTag;

    // Start is called before the first frame update
    void Start()
    {
        bTag = true;
    }

    // Update is called once per frame
    void Update()
    {
        bubble.SetActive(false);

        if(time < 0 && bTag)
        {
            next.SetActive(true);
            gameObject.SetActive(false);
            bTag = false;
        }
        if (time > 0)
            time -= Time.deltaTime;
    }
}
