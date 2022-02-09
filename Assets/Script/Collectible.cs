using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] CollectibleType collectibleType;
    [SerializeField] int points = 7;
    [SerializeField] float rotateSpeed = 10f;

    private void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerStats>().IncreaseStatPoints(collectibleType, points);
            Destroy(this.gameObject);
        }
    }
}

public enum CollectibleType
{
    Hipster,
    Redneck
}
