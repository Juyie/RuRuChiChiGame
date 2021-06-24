using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPuzzle : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private GameManager3 gameManager;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            Debug.Log("Dropped");

            eventData.pointerDrag.GetComponent<DragDropPuzzle>().setIsInBox(true);
            gameManager.upCountPuzzleNum();
        }
    }
}
