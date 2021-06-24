using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CleaningGameManager3 : MonoBehaviour
{
    [SerializeField]
    private bool isNextScene;

    [SerializeField]
    private string sceneName;

    [SerializeField]
    private AudioClip sound;

    [SerializeField]
    private AudioSource audioSource;

    private float time;
    private bool fTag;

    // Start is called before the first frame update
    void Start()
    {
        time = 15.9f;
        fTag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (fTag == true)
        {
            Debug.Log("Game Clear!");
            audioSource.clip = sound;
            audioSource.Play();
            fTag = false;
        }

        time -= Time.deltaTime;

        if (time < 0)
            if (isNextScene)
                SceneManager.LoadScene(sceneName);
    }
}
