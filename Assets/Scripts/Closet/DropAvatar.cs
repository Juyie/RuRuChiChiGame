using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropAvatar : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private ClosetGameManager3 gameManager;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.GetComponent<DragDropAvatar>().GetOrder() == 2)
        {
            if (eventData.pointerDrag != null && (gameManager.GetOrder() == 2 || gameManager.GetOrder() == 3))
            {
                Debug.Log("Dropped");

                gameManager.UpCountOrder();
                eventData.pointerDrag.GetComponent<DragDropAvatar>().SetIsInBox(true);
            }
        }
        else
        {
            if (eventData.pointerDrag != null && eventData.pointerDrag.GetComponent<DragDropAvatar>().GetOrder() == gameManager.GetOrder())
            {
                Debug.Log("Dropped");

                gameManager.UpCountOrder();
                eventData.pointerDrag.GetComponent<DragDropAvatar>().SetIsInBox(true);
            }
        }
    }
}
