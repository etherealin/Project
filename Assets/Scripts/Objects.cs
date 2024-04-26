using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Objects : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        //if (gameObject.transform.tag == "square")
            UnityEngine.Object.Destroy(this.gameObject);
    }
}
