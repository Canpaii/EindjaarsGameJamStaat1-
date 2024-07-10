using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class BeachVOLLEEYBAAAAAL : MonoBehaviour
{
   public float delay;  
   public GameObject videoPLayer;
    void Awake()
    {
        Invoke("DisableGameObject", delay);
    }

    void DisableGameObject()
    {
        gameObject.SetActive(false);
        videoPLayer.SetActive(false);
    }
    void Update()
    {
      if (Input.anyKey)
      {
         gameObject.SetActive(false);
         videoPLayer.SetActive(false);
      }
    }
}

