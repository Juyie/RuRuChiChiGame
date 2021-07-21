using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        anim.Play("selectWrongMoney", -1, 0f);
    }
}
