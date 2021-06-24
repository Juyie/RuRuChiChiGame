using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDropClothes : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    // 드래그를 하는 동안 커지는 비율
    [SerializeField]
    private float scaleX;

    [SerializeField]
    private float scaleY;

    [SerializeField]
    private Canvas canvas;

    [SerializeField]
    private int id;

    // 새로운 게임 매니져로 변경
    [SerializeField]
    private ClosetGameManager gameManager;

    private RectTransform rectTransform;
    private Vector3 originScale;
    private Vector3 originLocation;
    private CanvasGroup canvasGroup;
    private bool isInBox;

    public int getId()
    {
        return id;
    }

    public Vector3 getOriginLocation()
    {
        return originLocation;
    }

    public void setIsInBox(bool b)
    {
        isInBox = b;
    }

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        originScale = rectTransform.localScale;
        originLocation = rectTransform.anchoredPosition3D;
        isInBox = false;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        rectTransform.localScale = new Vector3(scaleX, scaleY, 1.0f);
        //canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //gameManager.setIsDrag(false);
        //canvasGroup.alpha = 1.0f;
        canvasGroup.blocksRaycasts = true;
        rectTransform.localScale = originScale;

        if (!isInBox)
            rectTransform.anchoredPosition = originLocation;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("OnPointerDown");
    }

    public void OnDrop(PointerEventData eventData)
    {

    }
}