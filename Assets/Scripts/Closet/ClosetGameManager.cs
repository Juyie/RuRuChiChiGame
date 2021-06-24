using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClosetGameManager : MonoBehaviour
{
    [SerializeField]
    private bool isNextScene;

    [SerializeField]
    private string sceneName;

    [SerializeField]
    private GameObject[] gameObjects;

    private bool gameFin;
    private float time1 = 1.5f;
    private float time2 = 5.0f;
    private bool dress;
    private bool hat;
    private bool mask;

    public bool GetDress()
    {
        return dress;
    }

    public bool GetHat()
    {
        return hat;
    }

    public bool GetMask()
    {
        return mask;
    }

    public void SelectDress()
    {
        dress = true;
        Debug.Log("Dress!");
    }

    public void SelectHat()
    {
        hat = true;
        Debug.Log("Hat!");
    }

    public void SelectMask()
    {
        mask = true;
        Debug.Log("Mask!");
    }

    // Start is called before the first frame update
    void Start()
    {
        gameFin = false;
        dress = false;
        hat = false;
        mask = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (dress == true && hat == true && mask == true)
        {
            Debug.Log("Game Clear!");
            dress = false;
            gameFin = true;
        }

        if (gameFin && time1 > 0)
            time1 -= Time.deltaTime;
        if (time1 < 0)
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].SetActive(true);
            }
        }

        if (time1 < 0 && time2 > 0)
            time2 -= Time.deltaTime;
        if(time2 < 0)
        {
            if (isNextScene)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
