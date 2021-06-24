using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropCure : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField]
    private Canvas canvas;

    [SerializeField]
    private GameObject cureOn;

    [SerializeField]
    private int order;

    private RectTransform rectTransform;
    private Vector3 originalLocation;
    private CanvasGroup canvasGroup;
    private bool isInLeg;

    public int GetOrder()
    {
        return order;
    }

    public void SetIsInLeg(bool b)
    {
        isInLeg = b;
    }

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        originalLocation = rectTransform.anchoredPosition3D;
        isInLeg = false;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        rectTransform.localScale = new Vector3(1.1f, 1.1f, 1.0f);
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;

        if (!isInLeg)
        {
            rectTransform.anchoredPosition = originalLocation;
            rectTransform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
            cureOn.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
