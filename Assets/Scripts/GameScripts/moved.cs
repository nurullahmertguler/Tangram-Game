using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class moved : MonoBehaviour, IDragHandler, IDropHandler
{
    private RectTransform rectTransform;
    //public Canvas canvas;
    public RectTransform slotTransform;
    

    GameObject slotObject;

    Vector2 startPos;

    public static bool isPaused = false;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        startPos = rectTransform.anchoredPosition;
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        if (isPaused == false) rectTransform.anchoredPosition += eventData.delta; 
    }

    public void OnDrop(PointerEventData eventData)
    {
        float distance = Vector3.Distance(slotTransform.anchoredPosition, rectTransform.anchoredPosition);
        if (distance <= 60)
        {
            rectTransform.anchoredPosition = slotTransform.anchoredPosition;
            Destroy(this);
            LevelScript.parcaSayisi--;
        }
        else
        {
            rectTransform.anchoredPosition = startPos;
        }
    }

    /* public void OnEndDrag(PointerEventData eventData)
    {
    }*/

    /* public void OnPointerDown(PointerEventData eventData)
     {

     }*/
}
