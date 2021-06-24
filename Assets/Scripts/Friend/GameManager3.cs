using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager3 : MonoBehaviour
{
    [SerializeField]
    private GameObject bdayTable;

    [SerializeField]
    private GameObject present;

    [SerializeField]
    private GameObject puzzle;

    [SerializeField]
    private GameObject clapArea;

    [SerializeField]
    private GameObject bar;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip[] clip;

    [SerializeField]
    private string sceneName;

    private int order;
    private int puzzleNum;
    private float time1 = 8.0f;
    private float time2 = 6.5f;
    private float time3 = 8.5f;
    private float time4 = 7.0f;
    private float time5 = 10.0f;
    private bool b1;
    private bool b2;
    private bool b3;

    public void upCountPuzzleNum()
    {
        puzzleNum++;
    }

    public void SetBool()
    {
        b3 = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        order = 0;
        puzzleNum = 0;
        b1 = true;
        b2 = true;
        b3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (order == 0)
        {
            if (time1 < 0)
            {
                bdayTable.SetActive(false);
                present.SetActive(true);
                order++;
            }
            time1 -= Time.deltaTime;
        }

        if (order == 1)
        {
            if(time2 < 0)
            {
                present.SetActive(false);
                puzzle.SetActive(true);
                order++;
            }
            time2 -= Time.deltaTime;
        }

        if(puzzleNum == 4 && order == 2)
        {
            if (b1)
            {
                audioSource.clip = clip[0];
                audioSource.Play();
                b1 = false;
            }

            if(time3 < 0)
            {
                puzzle.SetActive(false);
                bdayTable.SetActive(true);
                if (b2)
                {
                    audioSource.clip = clip[1];
                    audioSource.Play();
                    b2 = false;
                    order++;
                }
            }
            if (time3 > 0)
                time3 -= Time.deltaTime;
        }

        if(order == 3)
        {
            if(time4 < 0)
            {
                clapArea.SetActive(true);
                bar.SetActive(true);
                order++;
            }
            time4 -= Time.deltaTime;
        }

        if(order == 4 && b3)
        {
            if (time5 < 0)
            {
                GameObject musicObject = GameObject.FindGameObjectWithTag("friendBGM");
                Destroy(musicObject);
                SceneManager.LoadScene(sceneName);
            }
            time5 -= Time.deltaTime;
        }
    }
}
