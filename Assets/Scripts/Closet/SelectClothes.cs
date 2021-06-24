using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectClothes : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    private ClosetGameManager gameManager;

    [SerializeField]
    private Image effect;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip[] clip;

    private int weather;
    private RectTransform rectTransform;
    private bool isMove;
    private float speed = 0.05f;
    private Vector2 now;

    // Start is called before the first frame update
    void Start()
    {
        weather = PlayerPrefs.GetInt("weather");
        rectTransform = gameObject.GetComponent<RectTransform>();
        isMove = false;
        now = rectTransform.anchoredPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMove)
        {
            if (effect.GetComponent<RectTransform>().localScale.x < 4.0f)
            {
                effect.GetComponent<RectTransform>().localScale = new Vector3(effect.GetComponent<RectTransform>().localScale.x + 0.2f, effect.GetComponent<RectTransform>().localScale.y + 0.2f, effect.GetComponent<RectTransform>().localScale.z);
                Debug.Log(effect.GetComponent<RectTransform>().localScale.x + ", " + effect.GetComponent<RectTransform>().localScale.y);
            }
            if(effect.GetComponent<RectTransform>().localScale.x >= 4.0f && rectTransform.anchoredPosition.y > -700)
            {
                effect.GetComponent<RectTransform>().anchoredPosition = new Vector3(1000f, 1000f, 0f);
                rectTransform.Translate(new Vector3(-665f - now.x, -600f - now.y) * Time.deltaTime * speed);
            }
            if (rectTransform.anchoredPosition.y <= -700) isMove = false;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        rectTransform.localScale = new Vector3(1.2f, 1.2f, 1f);
        effect.GetComponent<RectTransform>().anchoredPosition = now;
        effect.GetComponent<RectTransform>().localScale = new Vector3(0f, 0f, 0f);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (weather == 0)
        {
            if (gameObject.name == "rain" && !gameManager.GetDress())
            {
                audioSource.clip = clip[0];
                audioSource.Play();

                Debug.Log("Select Cloth!");
                gameManager.SelectDress();
                PlayerPrefs.SetString("dress", gameObject.name);
                isMove = true;
            }
            else if (gameObject.name == "umbrella" && !gameManager.GetHat())
            {
                audioSource.clip = clip[0];
                audioSource.Play();

                Debug.Log("Select Hat!");
                gameManager.SelectHat();
                PlayerPrefs.SetString("hat", gameObject.name);
                isMove = true;
            }
            else if ((gameObject.name == "mask1" || gameObject.name == "mask2") && !gameManager.GetMask())
            {
                audioSource.clip = clip[0];
                audioSource.Play();

                Debug.Log("Select Mask!");
                gameManager.SelectMask();
                PlayerPrefs.SetString("mask", gameObject.name);
                isMove = true;
            }
            else
            {
                audioSource.clip = clip[1];
                audioSource.Play();

                Debug.Log("Already Selected!");
                rectTransform.localScale = new Vector3(1f, 1f, 1f);
            }
        }
        else if (weather == 1)
        {
            if ((gameObject.name == "summer1" || gameObject.name == "summer2") && !gameManager.GetDress())
            {
                audioSource.clip = clip[0];
                audioSource.Play();

                Debug.Log("Select Cloth!");
                gameManager.SelectDress();
                PlayerPrefs.SetString("dress", gameObject.name);
                isMove = true;
            }
            else if ((gameObject.name == "summer_hat1" || gameObject.name == "summer_hat2") && !gameManager.GetHat())
            {
                audioSource.clip = clip[0];
                audioSource.Play();

                Debug.Log("Select Hat!");
                gameManager.SelectHat();
                PlayerPrefs.SetString("hat", gameObject.name);
                isMove = true;
            }
            else if ((gameObject.name == "mask1" || gameObject.name == "mask2") && !gameManager.GetMask())
            {
                audioSource.clip = clip[0];
                audioSource.Play();

                Debug.Log("Select Mask!");
                gameManager.SelectMask();
                PlayerPrefs.SetString("mask", gameObject.name);
                isMove = true;
            }
            else
            {
                audioSource.clip = clip[1];
                audioSource.Play();

                Debug.Log("Already Selected!");
                rectTransform.localScale = new Vector3(1f, 1f, 1f);
            }
        }
        else
        {
            if ((gameObject.name == "winter1" || gameObject.name == "winter2") && !gameManager.GetDress())
            {
                audioSource.clip = clip[0];
                audioSource.Play();

                Debug.Log("Select Cloth!");
                gameManager.SelectDress();
                PlayerPrefs.SetString("dress", gameObject.name);
                isMove = true;
            }
            else if ((gameObject.name == "winter_hat1" || gameObject.name == "winter_hat2") && !gameManager.GetHat())
            {
                audioSource.clip = clip[0];
                audioSource.Play();

                Debug.Log("Select Hat!");
                gameManager.SelectHat();
                PlayerPrefs.SetString("hat", gameObject.name);
                isMove = true;
            }
            else if ((gameObject.name == "mask1" || gameObject.name == "mask2") && !gameManager.GetMask())
            {
                audioSource.clip = clip[0];
                audioSource.Play();

                Debug.Log("Select Mask!");
                gameManager.SelectMask();
                PlayerPrefs.SetString("mask", gameObject.name);
                isMove = true;
            }
            else
            {
                audioSource.clip = clip[1];
                audioSource.Play();

                Debug.Log("Already Selected!");
                rectTransform.localScale = new Vector3(1f, 1f, 1f);
            }
        }
    }
}
