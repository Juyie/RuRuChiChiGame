using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CleaningGameManager1 : MonoBehaviour
{
    [SerializeField]
    private int objectNum;

    [SerializeField]
    private bool isNextScene;

    [SerializeField]
    private string sceneName;

    [SerializeField]
    private AudioClip sound;

    [SerializeField]
    private AudioClip good;

    [SerializeField]
    private AudioSource dubbing;

    [SerializeField]
    private AudioSource audioSource;

    private int inBoxNum;
    private bool isDrag;
    private float time;
    private bool fTag;

    public void upCountInBoxNum()
    {
        inBoxNum++;
        Debug.Log("inBoxNum++!");
    }

    public void setIsDrag(bool b)
    {
        isDrag = b;
        Debug.Log("isDrag: " + b);
    }

    public bool getIsDrag()
    {
        return isDrag;
    }

    // Start is called before the first frame update
    void Start()
    {
        inBoxNum = 0;
        time = 2.0f;
        fTag = true;
    }

    // Update is called once per frame
    void Update()
    {
        // 쓰레기를 모두 담으면 게임 클리어를 콘솔에 띄운다.
        if(inBoxNum == objectNum)
        {
            if (fTag == true)
            {
                Debug.Log("Game Clear!");
                audioSource.clip = sound;
                audioSource.Play();
                dubbing.clip = good;
                dubbing.Play();
                fTag = false;
            }

            time -= Time.deltaTime;

            if(time < 0)
                if (isNextScene)
                    SceneManager.LoadScene(sceneName);
        }
    }
}