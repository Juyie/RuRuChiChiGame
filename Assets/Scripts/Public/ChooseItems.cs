using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseItems : MonoBehaviour
{
    [SerializeField]
    private PublicGameManager1 gameManager;

    [SerializeField]
    private GameObject[] O;

    [SerializeField]
    private GameObject[] X;

    [SerializeField]
    private GameObject[] items;

    private int listNum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        listNum = gameManager.GetListNum();
    }

    public void ClickColorpapers()
    {
        if (listNum == 1 || listNum == 6)
        {
            O[0].SetActive(true);
            items[0].GetComponent<Animator>().enabled = true;
            items[0].transform.SetParent(GameObject.Find("chichi").transform);
            gameManager.UpCountChooseNum();
        }
        else
        {
            X[0].SetActive(true);
            X[0].GetComponent<Animator>().Play("O", -1, 0f);
            X[0].GetComponent<AudioSource>().Play();
        }
    }

    public void ClickSketchbook()
    {
        if (listNum == 5 || listNum == 9)
        {
            O[1].SetActive(true);
            items[1].GetComponent<Animator>().enabled = true;
            items[1].transform.SetParent(GameObject.Find("chichi").transform);
            gameManager.UpCountChooseNum();
        }
        else
        {
            X[1].SetActive(true);
            X[1].GetComponent<Animator>().Play("O", -1, 0f);
            X[1].GetComponent<AudioSource>().Play();
        }
    }

    public void ClickPaints()
    {
        if (listNum == 3 || listNum == 5)
        {
            O[2].SetActive(true);
            items[2].GetComponent<Animator>().enabled = true;
            items[2].transform.SetParent(GameObject.Find("chichi").transform);
            gameManager.UpCountChooseNum();
        }
        else
        {
            X[2].SetActive(true);
            X[2].GetComponent<Animator>().Play("O", -1, 0f);
            X[2].GetComponent<AudioSource>().Play();
        }
    }

    public void ClickGlue()
    {
        if (listNum == 7)
        {
            O[3].SetActive(true);
            items[3].GetComponent<Animator>().enabled = true;
            items[3].transform.SetParent(GameObject.Find("chichi").transform);
            gameManager.UpCountChooseNum();
        }
        else
        {
            X[3].SetActive(true);
            X[3].GetComponent<Animator>().Play("O", -1, 0f);
            X[3].GetComponent<AudioSource>().Play();
        }
    }

    public void ClickScissor()
    {
        if (listNum == 7)
        {
            O[4].SetActive(true);
            items[4].GetComponent<Animator>().enabled = true;
            items[4].transform.SetParent(GameObject.Find("chichi").transform);
            gameManager.UpCountChooseNum();
        }
        else
        {
            X[4].SetActive(true);
            X[4].GetComponent<Animator>().Play("O", -1, 0f);
            X[4].GetComponent<AudioSource>().Play();
        }
    }

    public void ClickCrayon()
    {
        if (listNum == 2 || listNum == 9)
        {
            O[5].SetActive(true);
            items[5].GetComponent<Animator>().enabled = true;
            items[5].transform.SetParent(GameObject.Find("chichi").transform);
            gameManager.UpCountChooseNum();
        }
        else
        {
            X[5].SetActive(true);
            X[5].GetComponent<Animator>().Play("O", -1, 0f);
            X[5].GetComponent<AudioSource>().Play();
        }
    }

    public void ClickDino()
    {
        if (listNum == 6 || listNum == 10)
        {
            O[6].SetActive(true);
            items[6].GetComponent<Animator>().enabled = true;
            items[6].transform.SetParent(GameObject.Find("chichi").transform);
            gameManager.UpCountChooseNum();
        }
        else
        {
            X[6].SetActive(true);
            X[6].GetComponent<Animator>().Play("O", -1, 0f);
            X[6].GetComponent<AudioSource>().Play();
        }
    }

    public void ClickOcto()
    {
        if (listNum == 4 || listNum == 8 || listNum == 10)
        {
            O[7].SetActive(true);
            items[7].GetComponent<Animator>().enabled = true;
            items[7].transform.SetParent(GameObject.Find("chichi").transform);
            gameManager.UpCountChooseNum();
        }
        else
        {
            X[7].SetActive(true);
            X[7].GetComponent<Animator>().Play("O", -1, 0f);
            X[7].GetComponent<AudioSource>().Play();
        }
    }

    public void ClickNote()
    {
        if (listNum == 8)
        {
            O[8].SetActive(true);
            items[8].GetComponent<Animator>().enabled = true;
            items[8].transform.SetParent(GameObject.Find("chichi").transform);
            gameManager.UpCountChooseNum();
        }
        else
        {
            X[8].SetActive(true);
            X[8].GetComponent<Animator>().Play("O", -1, 0f);
            X[8].GetComponent<AudioSource>().Play();
        }
    }
}
