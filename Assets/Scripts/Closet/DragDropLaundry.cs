using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDropLaundry : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField]
    private Canvas canvas;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip clip;

    private RectTransform rectTransform;
    private Vector3 originalLocation;
    private CanvasGroup canvasGroup;
    private bool isInBox;

    public void setIsInBox(bool b)
    {
        isInBox = b;
    }

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        originalLocation = rectTransform.anchoredPosition3D;
        isInBox = false;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        audioSource.clip = clip;
        audioSource.Play();

        rectTransform.localScale = new Vector3(1.2f, 1.2f, 1.0f);
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;

        if (!isInBox)
            rectTransform.anchoredPosition = originalLocation;
    }
}
