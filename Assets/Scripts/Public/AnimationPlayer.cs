using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationPlayer : MonoBehaviour
{
    [SerializeField]
    private PublicGameManager1 gameManager;

    [SerializeField]
    private GameObject[] items;

    [SerializeField]
    private Animator anim;

    [SerializeField]
    private GameObject mom;

    [SerializeField]
    private Sprite happyMom;

    private int listNum;
    private float time1 = 2.5f;
    private float time2 = 1f;
    private float time3 = 5f;
    private bool b1 = true;
    private bool b2 = true;
    private bool b3 = false;

    // Start is called before the first frame update
    void Start()
    {
        listNum = gameManager.GetListNum();
    }

    // Update is called once per frame
    void Update()
    {
        if(time1 < 0 && b2)
        {
            if (b1)
            {
                anim.Play("chichiShowItems", -1, 0f);
                b1 = false;
            }
            if(time2 < 0)
            {
                items[listNum - 1].SetActive(true);
                mom.GetComponent<Image>().sprite = happyMom;
                b2 = false;
                b3 = true;
            }
            else
            {
                time2 -= Time.deltaTime;
            }
        }
        else
        {
            time1 -= Time.deltaTime;
        }

        if(b3 && time3 < 0)
        {
            gameManager.MoveScene();
        }
        else
        {
            time3 -= Time.deltaTime;
        }
    }
}
