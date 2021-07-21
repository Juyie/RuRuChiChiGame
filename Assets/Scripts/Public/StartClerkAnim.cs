using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartClerkAnim : MonoBehaviour
{
    [SerializeField]
    private PublicGameManager1 gameManager;

    [SerializeField]
    private GameObject clerk1;

    [SerializeField]
    private GameObject clerk2;

    private bool startAnim;
    private float time = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        startAnim = gameManager.GetStartAnim();

        if (startAnim)
        {
            if(time < 0)
            {
                clerk1.SetActive(false);
                clerk2.SetActive(true);
            }
            else
            {
                time -= Time.deltaTime;
            }
        }
    }
}
