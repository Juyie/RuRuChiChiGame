using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDistroy : MonoBehaviour
{
    [SerializeField]
    private string mTag;

    private void Awake()
    {
        GameObject[] musicObjects = GameObject.FindGameObjectsWithTag(mTag);
        if (musicObjects.Length > 1)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }
}
