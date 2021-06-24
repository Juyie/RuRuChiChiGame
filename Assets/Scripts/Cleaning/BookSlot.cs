using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BookSlot : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private CleaningGameManager1 gameManager;

    [SerializeField]
    private AudioClip sound;

    [SerializeField]
    private AudioSource audioSource;

    private int order = 1;

    public void OnDrop(PointerEventData eventData)
    {
        // 범위 안에 아이템이 들어오면 처리하는 부분
        if (eventData.pointerDrag != null)
        {
            Debug.Log("Dropped");

            if (eventData.pointerDrag.GetComponent<DragDrop>().getId() == order)
            {
                audioSource.clip = sound;
                audioSource.Play();
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = eventData.pointerDrag.GetComponent<DragDrop>().getBookLocation();
                eventData.pointerDrag.GetComponent<DragDrop>().setIsInBox(true);

                gameManager.upCountInBoxNum();
                order++;
            }
            else
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = eventData.pointerDrag.GetComponent<DragDrop>().getOriginLocation();
        }
    }
}
