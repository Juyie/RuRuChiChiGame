using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDropPuzzle : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField]
    private Canvas canvas;

    [SerializeField]
    private GameManager3 gameManager;

    [SerializeField]
    private GameObject origin;

    [SerializeField]
    private Sprite[] selected_image;

    [SerializeField]
    private GameObject puzzleOn;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip[] clip;

    private RectTransform rectTransform;
    private Vector3 originalLocation;
    private CanvasGroup canvasGroup;
    private bool isInBox;

    public void setIsInBox(bool b)
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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        origin.GetComponent<Image>().sprite = selected_image[1];
        rectTransform.localScale = new Vector3(1.1f, 1.1f, 1.0f);
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!isInBox)
        {
            origin.GetComponent<Image>().sprite = selected_image[0];
            rectTransform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            rectTransform.anchoredPosition = originalLocation;
            audioSource.clip = clip[1];
            audioSource.Play();
        }
        else
        {
            puzzleOn.SetActive(true);
            gameObject.SetActive(false);
        }
            
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        audioSource.clip = clip[0];
        audioSource.Play();
    }
}
