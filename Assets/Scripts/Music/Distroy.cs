using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distroy : MonoBehaviour
{
    [SerializeField]
    private string[] mTag;

    private void Awake()
    {
        for (int i = 0; i < mTag.Length; i++)
        {
            GameObject musicObject = GameObject.FindGameObjectWithTag(mTag[i]);
            Destroy(musicObject);
        }
    }
}
