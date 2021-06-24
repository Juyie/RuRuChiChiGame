using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDropAvatar : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField]
    private Canvas canvas;

    [SerializeField]
    private GameObject clothOn;

    [SerializeField]
    private int order;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip[] clip;

    private RectTransform rectTransform;
    private Vector3 originalLocation;
    private CanvasGroup canvasGroup;
    private bool isInBox;

    public int GetOrder()
    {
        return order;
    }

    public void SetIsInBox(bool b)
    {
        isInBox = b;
    }

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        originalLocation = rectTransform.anchoredPosition3D;
        isInBox = false;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        audioSource.clip = clip[0];
        audioSource.Play();

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

        if (!isInBox)
        {
            audioSource.clip = clip[2];
            audioSource.Play();

            rectTransform.anchoredPosition = originalLocation;
            rectTransform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
            audioSource.clip = clip[1];
            audioSource.Play();

            clothOn.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
