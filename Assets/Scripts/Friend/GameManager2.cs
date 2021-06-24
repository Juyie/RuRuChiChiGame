using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip clip;

    [SerializeField]
    private string sceneName;

    private float time = 1.0f;
    private float time2 = 8.0f;
    private int order;
    private bool b;

    public void UpCountOrder()
    {
        order++;
    }

    public int GetOrder()
    {
        return order;
    }

    // Start is called before the first frame update
    void Start()
    {
        order = 0;
        b = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(order == 2 && b == true)
        {
            if (time < 0)
            {
                audioSource.clip = clip;
                audioSource.Play();
                canvas.SetActive(true);
                b = false;
            }
            if(time >= 0)
                time -= Time.deltaTime;
        }

        if(time < 0)
        {
            if(time2 < 0)
            {
                GameObject musicObject = GameObject.FindGameObjectWithTag("friendBGM");
                Destroy(musicObject);
                SceneManager.LoadScene(sceneName);
            }
            time2 -= Time.deltaTime;
        }
    }
}
