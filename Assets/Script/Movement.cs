using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5f;
    
    void Update()
    {
        transform.Translate((Vector3.right * Input.GetAxis("Horizontal") + Vector3.forward) * movementSpeed * Time.deltaTime);    
    }
}
