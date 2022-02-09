using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    [SerializeField] bool setMixedCollectables;
    [SerializeField] GameObject hipsterCollectable;
    [SerializeField] GameObject redneckCollectable;

    [Header("Rows And Columns")]
    [SerializeField] int rows;
    [SerializeField] int columns;
    [SerializeField] float transformOffsetMultiplier;

    GameObject minorityPrefab, majorityPrefab;

    private void Start()
    {
        SpawnCollectables();
    }


    public void SetPriority(CollectibleType type)
    {
        if (!setMixedCollectables) return;

        if(type == CollectibleType.Hipster)
        {
            majorityPrefab = hipsterCollectable;
            minorityPrefab = redneckCollectable;
        }
        else
        {
            majorityPrefab = redneckCollectable;
            minorityPrefab = hipsterCollectable;
        }
    }

    void SpawnCollectables()
    {
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                GameObject prefabSpawn = Instantiate(hipsterCollectable, transform.position + (new Vector3(i, 0, j) * transformOffsetMultiplier), Quaternion.identity);
            }
        }
    }
}
