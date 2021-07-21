using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PublicGameManager1 : MonoBehaviour
{
    [SerializeField]
    private GameObject list;

    [SerializeField]
    private GameObject paper;

    [SerializeField]
    private GameObject text1;

    [SerializeField]
    private GameObject text2;

    [SerializeField]
    private GameObject dot2;

    [SerializeField]
    private GameObject[] icons;

    [SerializeField]
    private GameObject homeOrPay;

    [SerializeField]
    private GameObject[] moneyBubbles;

    [SerializeField]
    private GameObject canvas2;

    [SerializeField]
    private GameObject canvas3;

    private int listNum;
    private int answerNum;
    private int chooseNum = 0;
    private bool b1 = true;
    private float time1 = 3f;
    private bool rightMoney = false;
    private float time2 = 3f;
    private bool startAnim = false;

    // Start is called before the first frame update
    void Start()
    {
        listNum = Random.Range(1, 11);
        Debug.Log("listNum = " + listNum);
        if (listNum == 1)
        {
            dot2.SetActive(false);
            icons[0].SetActive(true);
            text1.GetComponent<Text>().text = "색종이";
            answerNum = 1;
        }
        else if (listNum == 2)
        {
            dot2.SetActive(false);
            icons[1].SetActive(true);
            text1.GetComponent<Text>().text = "색연필";
            answerNum = 1;
        }
        else if (listNum == 3)
        {
            dot2.SetActive(false);
            icons[2].SetActive(true);
            text1.GetComponent<Text>().text = "물감";
            answerNum = 1;
        }
        else if (listNum == 4)
        {
            dot2.SetActive(false);
            icons[3].SetActive(true);
            text1.GetComponent<Text>().text = "문어 인형";
            answerNum = 1;
        }
        else if (listNum == 5)
        {
            icons[4].SetActive(true);
            text1.GetComponent<Text>().text = "물감";
            text2.GetComponent<Text>().text = "스케치북";
            answerNum = 2;
        }
        else if (listNum == 6)
        {
            icons[5].SetActive(true);
            text1.GetComponent<Text>().text = "색종이";
            text2.GetComponent<Text>().text = "공룡 인형";
            answerNum = 2;
        }
        else if (listNum == 7)
        {
            icons[6].SetActive(true);
            text1.GetComponent<Text>().text = "풀";
            text2.GetComponent<Text>().text = "가위";
            answerNum = 2;
        }
        else if (listNum == 8)
        {
            icons[7].SetActive(true);
            text1.GetComponent<Text>().text = "수첩";
            text2.GetComponent<Text>().text = "문어 인형";
            answerNum = 2;
        }
        else if (listNum == 9)
        {
            icons[8].SetActive(true);
            text1.GetComponent<Text>().text = "색연필";
            text2.GetComponent<Text>().text = "스케치북";
            answerNum = 2;
        }
        else if (listNum == 10)
        {
            icons[9].SetActive(true);
            text1.GetComponent<Text>().text = "공룡 인형";
            text2.GetComponent<Text>().text = "문어 인형";
            answerNum = 2;
        }

        moneyBubbles[listNum - 1].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(time1 < 0)
        {
            list.SetActive(true);
        }
        else
        {
            time1 -= Time.deltaTime;
        }

        if(answerNum == chooseNum && b1)
        {
            homeOrPay.SetActive(true);
            b1 = false;
        }

        if (rightMoney)
        {
            if(time2 < 0)
            {
                canvas2.SetActive(false);
                canvas3.SetActive(true);
            }
            else
            {
                time2 -= Time.deltaTime;
            }
        }
    }

    public int GetListNum()
    {
        return listNum;
    }

    public void UpCountChooseNum()
    {
        chooseNum++;
    }
    
    public void SetRightMoney()
    {
        rightMoney = true;
    }

    public void MoveScene()
    {
        SceneManager.LoadScene("GameMenu");
    }

    public void SetStartAnim()
    {
        startAnim = true;
    }

    public bool GetStartAnim()
    {
        return startAnim;
    }
}
