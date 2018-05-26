using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseEvents : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    EventSystem eventSystem;
    GameObject lastSelectedObject;

    // Use this for initialization
    void Start()
    {
        //eventSystem = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<EventSystem>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //eventSystem.SetSelectedGameObject(eventData.pointerEnter);
        //lastSelectedObject = eventSystem.currentSelectedGameObject;
        //Debug.Log(lastSelectedObject.name);
        Debug.Log("Pointer Down");
    }

    public void OnPointerUp(PointerEventData eventData)

    {
        //eventSystem.SetSelectedGameObject(lastSelectedObject);

        Debug.Log("Pointer Up");
    }
}
