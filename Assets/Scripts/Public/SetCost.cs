using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetCost : MonoBehaviour
{
    [SerializeField]
    private PublicGameManager1 gameManager;

    [SerializeField]
    private GameObject[] items;

    private int listNum;

    // Start is called before the first frame update
    void Start()
    {
        listNum = gameManager.GetListNum();

        if(listNum == 1)
        {
            GetComponent<Text>().text = "1000";
            items[0].SetActive(true);
        }
        else if (listNum == 2)
        {
            GetComponent<Text>().text = "3000";
            items[1].SetActive(true);
        }
        else if (listNum == 3)
        {
            GetComponent<Text>().text = "4000";
            items[2].SetActive(true);
        }
        else if (listNum == 4)
        {
            GetComponent<Text>().text = "5000";
            items[3].SetActive(true);
        }
        else if (listNum == 5)
        {
            GetComponent<Text>().text = "6000";
            items[4].SetActive(true);
        }
        else if (listNum == 6)
        {
            GetComponent<Text>().text = "4000";
            items[5].SetActive(true);
        }
        else if (listNum == 7)
        {
            GetComponent<Text>().text = "2000";
            items[6].SetActive(true);
        }
        else if (listNum == 8)
        {
            GetComponent<Text>().text = "6000";
            items[7].SetActive(true);
        }
        else if (listNum == 9)
        {
            GetComponent<Text>().text = "5000";
            items[8].SetActive(true);
        }
        else
        {
            GetComponent<Text>().text = "8000";
            items[9].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
