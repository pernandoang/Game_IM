using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class mouseOvr : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    public Vector2[] StartPosition;
    public Vector2[] posisi;
    public RectTransform[] rect;

    public void OnPointerEnter(PointerEventData eventData)
    {
        rect[0].anchoredPosition = posisi[0];
        rect[1].anchoredPosition = posisi[1];
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rect[0].anchoredPosition = StartPosition[0];
        rect[1].anchoredPosition = StartPosition[1];
    }
}
