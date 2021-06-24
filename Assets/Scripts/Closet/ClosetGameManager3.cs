using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClosetGameManager3 : MonoBehaviour
{
    [SerializeField]
    private GameObject[] clothes;

    [SerializeField]
    private GameObject[] hats;

    [SerializeField]
    private GameObject[] shoes;

    [SerializeField]
    private GameObject[] masks;

    [SerializeField]
    private GameObject effect;

    [SerializeField]
    private GameObject canvas;

    [SerializeField]
    private GameObject[] backgrounds;

    [SerializeField]
    private GameObject[] rurus;

    [SerializeField]
    private GameObject[] maskL;

    [SerializeField]
    private string sceneName;

    private string cloth;
    private string hat;
    private string mask;
    private int order;
    private float time = 1.0f;
    private float time2 = 16.0f;

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
        cloth = PlayerPrefs.GetString("dress");
        hat = PlayerPrefs.GetString("hat");
        mask = PlayerPrefs.GetString("mask");
        SettingCloth(cloth);
        SettingHat(hat);
        SettingMask(mask);
        order = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(order == 5)
        {
            Debug.Log("fin");
            if (time < 0)
            {
                canvas.SetActive(true);
                SettingEnding();
                order++;
            }
            effect.SetActive(true);
            time -= Time.deltaTime;
        }

        if(order == 6)
        {
            if(time2 < 0)
            {
                GameObject musicObject = GameObject.FindGameObjectWithTag("closetBGM");
                Destroy(musicObject);
                SceneManager.LoadScene(sceneName);
            }
            time2 -= Time.deltaTime;
        }
    }

    void SettingCloth(string cloth)
    {
        if(cloth == "summer1")
        {
            clothes[0].SetActive(true);
            shoes[0].SetActive(true);
        }
        else if(cloth == "summer2")
        {
            clothes[1].SetActive(true);
            shoes[1].SetActive(true);
        }
        else if(cloth == "winter1")
        {
            clothes[2].SetActive(true);
            shoes[2].SetActive(true);
        }
        else if(cloth == "winter2")
        {
            clothes[3].SetActive(true);
            shoes[3].SetActive(true);
        }
        else if(cloth == "rain")
        {
            clothes[4].SetActive(true);
            shoes[4].SetActive(true);
        }
    }

    void SettingHat(string hat)
    {
        if (hat == "summer_hat1")
        {
            hats[0].SetActive(true);
        }
        else if (hat == "summer_hat2")
        {
            hats[1].SetActive(true);
        }
        else if (hat == "winter_hat1")
        {
            hats[2].SetActive(true);
        }
        else if (hat == "winter_hat2")
        {
            hats[3].SetActive(true);
        }
        else if (hat == "umbrella")
        {
            hats[4].SetActive(true);
        }
    }

    void SettingMask(string mask)
    {
        if(mask == "mask1")
        {
            masks[0].SetActive(true);
        }
        else if(mask == "mask2")
        {
            masks[1].SetActive(true);
        }
    }

    void SettingEnding()
    {
        int weather = PlayerPrefs.GetInt("weather");

        backgrounds[weather].SetActive(true);

        if (cloth == "rain" && hat == "umbrella")
        {
            rurus[0].SetActive(true);
        }
        else if (cloth == "summer1" && hat == "summer_hat1")
        {
            rurus[1].SetActive(true);
        }
        else if (cloth == "summer1" && hat == "summer_hat2")
        {
            rurus[2].SetActive(true);
        }
        else if (cloth == "summer2" && hat == "summer_hat1")
        {
            rurus[3].SetActive(true);
        }
        else if (cloth == "summer2" && hat == "summer_hat2")
        {
            rurus[4].SetActive(true);
        }
        else if (cloth == "winter1" && hat == "winter_hat1")
        {
            rurus[5].SetActive(true);
        }
        else if (cloth == "winter1" && hat == "winter_hat2")
        {
            rurus[6].SetActive(true);
        }
        else if (cloth == "winter2" && hat == "winter_hat1")
        {
            rurus[7].SetActive(true);
        }
        else if (cloth == "winter2" && hat == "winter_hat2")
        {
            rurus[8].SetActive(true);
        }

        if (weather == 0)
        {
            if (mask == "mask1")
            {
                maskL[0].SetActive(true);
            }
            else if (mask == "mask2")
            {
                maskL[1].SetActive(true);
            }
        }
        else if (weather == 1)
        {
            if (mask == "mask1")
            {
                maskL[2].SetActive(true);
            }
            else if (mask == "mask2")
            {
                maskL[3].SetActive(true);
            }
        }
        else if(weather == 2)
        {
            if (mask == "mask1")
            {
                maskL[4].SetActive(true);
            }
            else if (mask == "mask2")
            {
                maskL[5].SetActive(true);
            }
        }
    }
}
