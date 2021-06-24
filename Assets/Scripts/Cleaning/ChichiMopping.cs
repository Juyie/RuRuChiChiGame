using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChichiMopping : MonoBehaviour
{
    [SerializeField]
    CleaningGameManager2 gameManager;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Triggered!" + collision);
        RectTransform rectTransform = collision.GetComponent<RectTransform>();
        Vector3 scale = rectTransform.localScale;
        if (scale.x < 0.1 || scale.y < 0.1)
        {
            rectTransform.localScale = new Vector3(0.0f, 0.0f, 1.0f);
            gameManager.upCountInVacuumNum();
        }
        else
            rectTransform.localScale = new Vector3(scale.x * 0.95f, scale.y * 0.93f, 1.0f);
    }

    /*
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("Trigger Stay");
        RectTransform rectTransform = collision.GetComponent<RectTransform>();
        Vector3 scale = rectTransform.localScale;
        if (scale.x < 0.1 || scale.y < 0.1)
        {
            rectTransform.localScale = new Vector3(0.0f, 0.0f, 1.0f);
            gameManager.upCountInVacuumNum();
        }
        else
            rectTransform.localScale = new Vector3(scale.x * 0.95f, scale.y * 0.93f, 1.0f);
    }
    */
}
