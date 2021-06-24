using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindAnswer : MonoBehaviour
{
    [SerializeField]
    private GameManager1 gameManager;

    [SerializeField]
    private GameObject effect;

    [SerializeField]
    private bool correct;

    private float time = 1.0f;

    private void Update()
    {
        if (effect.active == true && !correct)
        {
            if (time < 0)
            {
                effect.SetActive(false);
                time = 1.0f;
            }
            time -= Time.deltaTime;
        }
    }

    public void Clicked()
    { 
        gameManager.upCountCorrect();
    }

    public void Effect()
    {
        effect.SetActive(true);
    }
}
