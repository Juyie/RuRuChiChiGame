using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropLaundry : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private ClosetGameManager2 gameManager;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            Debug.Log("Dropped");

            gameManager.upCountFNum();
            eventData.pointerDrag.GetComponent<DragDropLaundry>().setIsInBox(true);
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<CanvasGroup>().alpha = 0f;
        }
    }
}
