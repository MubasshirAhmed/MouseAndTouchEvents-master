using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Color defaultColor;
    public Color selectedColor;
    private Material _mat;

    private void Start()
    {
        _mat = GetComponent<Renderer>().material;
    }

    void OnTouchDown()
    {
        _mat.color = selectedColor;
    }

    void OnTouchUp()
    {
        _mat.color = defaultColor;
    }

    void OnTouchStay()
    {
        _mat.color = Color.gray;
    }

    void OnTouchExit()
    {
        _mat.color = Color.black;
    }
}
