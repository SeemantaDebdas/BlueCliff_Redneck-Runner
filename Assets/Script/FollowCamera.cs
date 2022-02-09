using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform targetTransform;
    Vector3 difference;
    private void Start()
    {
        difference = transform.position - targetTransform.position;//0,0,0 - 0,0.5,-10
    }

    private void LateUpdate()
    {
        Vector3 temp = difference + targetTransform.position;
        transform.position = temp;
    }
}
