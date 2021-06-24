using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene1 : MonoBehaviour
{
    [SerializeField]
    private GameObject bubble;

    [SerializeField]
    private string sceneName;

    [SerializeField]
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bubble.SetActive(false);

        if (time < 0)
            SceneManager.LoadScene(sceneName);
        time -= Time.deltaTime;
    }
}
