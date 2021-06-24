using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    [SerializeField]
    private string sceneName;

    [SerializeField]
    private GameObject bubble;

    private int correct;
    private float time = 2.0f;
    private float time2 = 7.0f;

    public void upCountCorrect()
    {
        Debug.Log("++");
        correct++;
    }

    // Start is called before the first frame update
    void Start()
    {
        correct = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(correct == 2)
        {
            if (time < 0)
                SceneManager.LoadScene(sceneName);
            time -= Time.deltaTime;
        }

        if(time2 < 0)
            bubble.SetActive(true);
        if (time2 >= 0)
            time2 -= Time.deltaTime;
    }
}
