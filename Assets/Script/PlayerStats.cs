using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] int hipsterPoints;
    [SerializeField] int redneckPoints;
    public void SetInitialState()
    {

    }
    
    public void IncreaseStatPoints(CollectibleType type, int points)
    {
        if (type == CollectibleType.Hipster)
            hipsterPoints += points;
        else if (type == CollectibleType.Redneck)
            redneckPoints += points;
    }

    private void Update()
    {
    }
}
