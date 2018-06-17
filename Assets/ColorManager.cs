using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{

    public Color StartColor;
    public Color LoseColor;
    Camera _cam;

    void Start()
    {
        _cam = GetComponent<Camera>();
        _cam.backgroundColor = StartColor;
    }

    public void ChangeToLoseColor()
    {
        _cam.backgroundColor = LoseColor;
    }

    public void ChangeToStartColor()
    {
        _cam.backgroundColor = StartColor;
    }

}
