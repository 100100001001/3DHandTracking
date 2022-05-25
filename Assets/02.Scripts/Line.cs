using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    LineRenderer lineRenderer;

    public Transform origin;     // 원점
    public Transform desination; // 목적지의 위치

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.1f; // 시작 너비
        lineRenderer.endWidth = 0.1f;   // 끝 너비
    }

    void Update()
    {
        lineRenderer.SetPosition(0, origin.position);
        lineRenderer.SetPosition(1, desination.position);
    }
}
