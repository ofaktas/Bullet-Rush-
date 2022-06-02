using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class EkranaDokunmaKontrol : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private Vector2 _DokunmaPozizyonu;
    public Vector2 Yön;
   
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        _DokunmaPozizyonu = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Yön = Vector3.zero;
    }

    public void OnDrag(PointerEventData eventData)
    {
        var delta = eventData.position - _DokunmaPozizyonu;
        Yön = delta.normalized;
    }

}
