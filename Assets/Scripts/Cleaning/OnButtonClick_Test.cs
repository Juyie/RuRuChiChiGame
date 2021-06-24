using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnButtonClick_Test : MonoBehaviour
{
    [SerializeField]
    string sceneName;

    public void OnButtonClickTest()
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
