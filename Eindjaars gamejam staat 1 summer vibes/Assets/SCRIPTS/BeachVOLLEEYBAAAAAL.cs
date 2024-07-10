using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class BeachVOLLEEYBAAAAAL : MonoBehaviour
{
   public float delay;  
    void Awake()
    {
        Invoke("DisableGameObject", delay);
    }

    void DisableGameObject()
    {
        gameObject.SetActive(false);
    }
}

