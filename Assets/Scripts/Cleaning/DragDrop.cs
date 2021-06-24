using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    // 드래그를 하는 동안 커지는 비율
    [SerializeField]
    private float scaleX;

    [SerializeField]
    private float scaleY;

    // 책의 경우 책꽂이에 꽂을 때의 위ㅊ
    [SerializeField]
    private float bookPosX;

    [SerializeField]
    private float bookPosY;

    [SerializeField]
    private Canvas canvas;

    [SerializeField]
    private int id;

    [SerializeField]
    private CleaningGameManager1 gameManager;

    // 책의 경우 드래그 시 변경될 이미지 저장
    [SerializeField]
    private Sprite[] selected_image;

    [SerializeField]
    private AudioClip[] sounds;

    [SerializeField]
    private AudioSource audioSource;

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

    public Vector3 getBookLocation()
    {
        Vector3 bookLocation = new Vector3(bookPosX, bookPosY, 0f);
        return bookLocation;
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
        audioSource.clip = sounds[0];
        audioSource.Play();
        gameManager.setIsDrag(true);
        if(selected_image.Length > 0)
            gameObject.GetComponent<Image>().sprite = selected_image[1];

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
        gameManager.setIsDrag(false);
        if (selected_image.Length > 0)
        {
            if (!isInBox)
            {
                gameObject.GetComponent<Image>().sprite = selected_image[0];
                rectTransform.localScale = originScale;
            }
        }
        else
            rectTransform.localScale = originScale;
        //canvasGroup.alpha = 1.0f;
        canvasGroup.blocksRaycasts = true;

        if (!isInBox)
        {
            rectTransform.anchoredPosition = originLocation;
            audioSource.clip = sounds[1];
            audioSource.Play();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("OnPointerDown");
    }

    public void OnDrop(PointerEventData eventData)
    {
        
    }
}