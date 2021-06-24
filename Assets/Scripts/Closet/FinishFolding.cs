using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishFolding : MonoBehaviour
{
    [SerializeField]
    private GameObject background;

    [SerializeField]
    private GameObject originalCloth;

    [SerializeField]
    private GameObject foldedCloth;

    [SerializeField]
    private ClosetGameManager2 gameManager;

    private float time = 1.0f;
    private int count = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 0.0f && count == 1)
        {
            gameManager.upCountFNum();
            originalCloth.SetActive(false);
            background.SetActive(false);
            foldedCloth.SetActive(true);
            count--;
            gameObject.SetActive(false);
        }
        if(time > 0.0f)
            time -= Time.deltaTime;
    }
}
