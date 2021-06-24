using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClosetGameManager2 : MonoBehaviour
{
    [SerializeField]
    private ObjectChanger objectChanger;

    [SerializeField]
    private string sceneName;

    private int tNum;
    private int fNum;
    private float time = 3.0f;

    public void upCountTNum()
    {
        tNum++;
    }

    public void upCountFNum()
    {
        fNum++;
    }

    // Start is called before the first frame update
    void Start()
    {
       tNum = 0;
       fNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (tNum == 3)
        {
            Debug.Log("TakeOff All!");
            objectChanger.change();
            tNum++;
        }

        if(fNum == 3)
        {
            Debug.Log("Folding All!");
            if(time < 0)
                SceneManager.LoadScene(sceneName);
            time -= Time.deltaTime;
        }
    }
}
