using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CleaningGameManager2 : MonoBehaviour
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

    private int inVacuumNum;
    private float time;
    private bool fTag;

    public void upCountInVacuumNum()
    {
        inVacuumNum++;
        Debug.Log("inVacuumNum++");
    }

    private void Start()
    {
        inVacuumNum = 0;
        time = 2.0f;
        fTag = true;
    }

    private void Update()
    {
        if (inVacuumNum == objectNum)
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

            if (time < 0)
                if (isNextScene)
                    SceneManager.LoadScene(sceneName);
        }
    }
}
