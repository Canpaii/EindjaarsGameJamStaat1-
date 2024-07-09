using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWork2 : MonoBehaviour
{
    public GameObject prefab;
    public float minZ;
    public float maxZ;
    public float location;
    public float location2;
    public Vector3 spawnRotation;



    public void SpawnFirework2(int count)
    {
        for (int i = 0; i < count; i++)
        {
            float randomZ = Random.Range(minZ, maxZ);
            Vector3 spawnPosition = new Vector3(location, location2, randomZ);
            GameObject spawnedObject = Instantiate(prefab, spawnPosition, Quaternion.Euler(spawnRotation));
            Destroy(spawnedObject, 3f);
        }
    }
}