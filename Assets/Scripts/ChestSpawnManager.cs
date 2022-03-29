using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSpawnManager : MonoBehaviour
{
    [SerializeField]
    List<Transform> spawnLocations;


    public Vector3 getNewChestLocation()
    {
        return spawnLocations[Random.Range(0, spawnLocations.Count-1)].position;
    }
}
