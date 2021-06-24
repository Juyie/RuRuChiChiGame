using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenWindowButton : MonoBehaviour
{
    [SerializeField]
    private string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WindowOpen()
    {
        int sceneNum = Random.Range(0, 3);
        Debug.Log(sceneNum);
        PlayerPrefs.SetInt("weather", sceneNum);
        SceneManager.LoadScene(sceneName);
    }
}
