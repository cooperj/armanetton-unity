using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowSpawner : MonoBehaviour
{
    public GameObject[] windowTypes;
    public Transform[] spawnPoints;

    private void Start()
    {
        SpawnWindow();
    }

    void SpawnWindow ()
    {
        Instantiate(GetRandomWindowType(), GetRandomSpawnPosition(), Quaternion.identity);
    }

    GameObject GetRandomWindowType()
    {
        int i = Random.Range(0, windowTypes.Length);
        return windowTypes[i];
    }

    Vector3 GetRandomSpawnPosition()
    {
        int i = Random.Range(0, spawnPoints.Length);
        return spawnPoints[i].position;
    }
}
