using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackBtn : MonoBehaviour
{
    [SerializeField]
    private GameObject PopUp;

    private AudioSource[] allAudioSources;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
    }

    public void ClickBackBtn()
    {
        //Time.timeScale = 0f;
        PopUp.SetActive(true);
        //PauseAudioSource();
    }

    public void ClickYesBtn()
    {
        SceneManager.LoadScene("GameMenu");
    }

    public void ClickNoBtn()
    {
        PopUp.SetActive(false);
        //Time.timeScale = 1f;
        //PlayAudioSource();
    }

    private void PauseAudioSource()
    {
        foreach(AudioSource audioS in allAudioSources)
        {
            audioS.Pause();
        }
    }

    private void PlayAudioSource()
    {
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Play();
        }
    }

    public void ClickGameMenuYesBtn()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
