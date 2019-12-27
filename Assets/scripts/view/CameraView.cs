using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    public Vector3 startPos;
    private Transform tr;
    private Vector3 targetPos;
    
    void Start()
    {
        tr = GetComponent<Transform>();
        targetPos = startPos;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * 0.9f);
    }

    public void SetStartPos()
    {
        targetPos = startPos;
    }

    public void SetTargetPos(Vector3 newTargetPos)
    {
        newTargetPos.z -= 4;
        targetPos = newTargetPos;
    }
}
