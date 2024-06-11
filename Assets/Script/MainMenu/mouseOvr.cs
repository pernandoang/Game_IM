using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class mouseOvr : MonoBehaviour, IPointerEnterHandler
{
    public Vector2 posisi;
    public RectTransform rect1;

    public void ChangePosition(Vector2 newPosition)
    {
        rect1.anchoredPosition = newPosition;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ChangePosition(posisi);
    }

    
}
