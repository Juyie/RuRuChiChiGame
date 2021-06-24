using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TakeOffClothes : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField]
    private Canvas canvas;

    [SerializeField]
    private ClosetGameManager2 gameManager;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip clip;

    private RectTransform rectTransform;
    private Vector3 originLocation;

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        originLocation = rectTransform.anchoredPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        rectTransform.localScale = new Vector3(1.2f, 1.2f, 1.0f);
        audioSource.clip = clip;
        audioSource.Play();
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (originLocation.x - rectTransform.anchoredPosition.x > 300 || originLocation.x - rectTransform.anchoredPosition.x < -300
            || originLocation.y - rectTransform.anchoredPosition.y > 300 || originLocation.y - rectTransform.anchoredPosition.y < -300)
        {
            gameManager.upCountTNum();
            gameObject.SetActive(false);
        }
        else
        {
            rectTransform.anchoredPosition = originLocation;
            rectTransform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
    }
}
