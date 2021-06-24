using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDistroyEffect : MonoBehaviour
{
    [SerializeField]
    private string mTag;

    private void Awake()
    {
        GameObject musicObject = GameObject.FindWithTag(mTag);
        DontDestroyOnLoad(musicObject);
    }
}
