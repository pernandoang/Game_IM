using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class mouseOvr : MonoBehaviour, IPointerEnterHandler
{
    public GameObject[] obj;
    public Vector3 current1;
    public Vector3 current2;

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }
}
