using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private CleaningGameManager1 gameManager;

    [SerializeField]
    private int id;

    [SerializeField]
    private AudioClip sound;

    [SerializeField]
    private AudioSource audioSource;

    public int getId()
    {
        return id;
    }

    public void OnDrop(PointerEventData eventData)
    {
        // 범위 안에 아이템이 들어오면 처리하는 부분
        if(eventData.pointerDrag != null)
        {
            Debug.Log("Dropped");
            // 쓰레기통의 id와 쓰레기의 id가 동일한 경우 
            if (eventData.pointerDrag.GetComponent<DragDrop>().getId() == id)
            {
                audioSource.clip = sound;
                audioSource.Play();
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.GetComponent<DragDrop>().setIsInBox(true);
                
                gameManager.upCountInBoxNum();
            }
            else
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = eventData.pointerDrag.GetComponent<DragDrop>().getOriginLocation();
        }
    }
}
