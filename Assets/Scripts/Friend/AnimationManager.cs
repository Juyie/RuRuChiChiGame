using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField]
    private GameObject chichi;

    [SerializeField]
    private GameObject[] rurus;

    [SerializeField]
    private GameObject[] chichis;

    [SerializeField]
    private float[] ruru_time;

    [SerializeField]
    private float[] chichi_time;

    [SerializeField]
    private GameObject kid;

    [SerializeField]
    private float[] kid_time;

    [SerializeField]
    private GameObject bubble;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip[] dubbings;

    private int ruru_num;
    private bool bRuru;
    private int chichi_num;
    private bool bChichi;
    private bool bKid;
    private int kid_num;

    // Start is called before the first frame update
    void Start()
    {
        ruru_num = 0;
        chichi_num = 0;
        kid_num = 0;
        bRuru = true;
        bChichi = true;
        bKid = true;
        audioSource.clip = dubbings[0];
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(ruru_time[ruru_num] < 0 && bRuru == true)
        {
            if (ruru_num == 0)
            {
                chichi.SetActive(true);
                audioSource.clip = dubbings[1];
                audioSource.Play();
            }

            if (ruru_num == 2)
            {
                audioSource.clip = dubbings[2];
                audioSource.Play();
            }

            if (ruru_num == 3)
            {
                audioSource.clip = dubbings[4];
                audioSource.Play();
            }

            if(ruru_num > 0)
                rurus[ruru_num - 1].SetActive(false);
            rurus[ruru_num].SetActive(true);

            ruru_num++;
            if (ruru_num >= rurus.Length)
                bRuru = false;
        }

        if (chichi_time[chichi_num] < 0 && bChichi == true)
        {
            if (chichi_num == 2)
            {
                audioSource.clip = dubbings[3];
                audioSource.Play();
            }

            if(chichi_num > 0)
                chichis[chichi_num - 1].SetActive(false);
            chichis[chichi_num].SetActive(true);

            chichi_num++;
            if (chichi_num >= chichis.Length)
            {
                bChichi = false;
            }
        }

        if(bRuru == true)
            ruru_time[ruru_num] -= Time.deltaTime;
        if(bChichi == true)
            chichi_time[chichi_num] -= Time.deltaTime;

        if (bRuru == false && bChichi == false)
        {
            if (kid_time[kid_num] < 0 && bKid == true)
            {
                if (kid_num == 0)
                {
                    kid.SetActive(true);
                    audioSource.clip = dubbings[5];
                    audioSource.Play();
                }

                if(kid_num == 1)
                {
                    audioSource.clip = dubbings[6];
                    audioSource.Play();
                }

                if (kid_num == 2)
                {
                    audioSource.clip = dubbings[7];
                    audioSource.Play();
                }

                if (kid_num == 3)
                {
                    audioSource.clip = dubbings[8];
                    audioSource.Play();
                }

                kid_num++;
                if (kid_num > 4)
                {
                    bKid = false;
                    Debug.Log("bKid false");
                }
            }
            if(bKid == true)
                kid_time[kid_num] -= Time.deltaTime;
        }

        if (bKid == false)
        {
            kid.SetActive(false);
            bubble.SetActive(true);
            audioSource.clip = dubbings[9];
            audioSource.Play();
        }
    }
}
