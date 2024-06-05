using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMark : MonoBehaviour
{
    AimMark AimMark { get; set; }
    public Canvas rootCanvas;
    public RectTransform rootRectTransform;
    public Transform target;
    private void Start()
    {
        AimMark = new AimMark();
        AimMark.Setup(rootCanvas, rootRectTransform, target);
    }
}
