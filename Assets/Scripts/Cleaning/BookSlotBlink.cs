using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookSlotBlink : MonoBehaviour
{
    [SerializeField]
    private CleaningGameManager1 gameManager;

    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (gameManager.getIsDrag() == true)
        {
            animator.SetBool("blink", true);
        }
        else
        {
            animator.SetBool("blink", false);
        }
    }
}