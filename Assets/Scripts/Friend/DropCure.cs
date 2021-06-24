using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropCure : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private GameManager2 gameManager;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.GetComponent<DragDropCure>().GetOrder() == gameManager.GetOrder())
        {
            if (eventData.pointerDrag != null)
            {
                Debug.Log("Dropped");

                gameManager.UpCountOrder();
                eventData.pointerDrag.GetComponent<DragDropCure>().SetIsInLeg(true);
            }
        }
    }
}
