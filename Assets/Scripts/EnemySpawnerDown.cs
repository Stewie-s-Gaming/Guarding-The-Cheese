using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerDown : MonoBehaviour
{
    [SerializeField] int numOfSpawns = 10;
    int currNumOfSpawns;
    [SerializeField] MoverDown prefabToSpawn;
    [Tooltip("Minimum time between consecutive spawns, in seconds")] [SerializeField] float minTimeBetweenSpawns = 2f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")] [SerializeField] float maxTimeBetweenSpawns = 8f;
    Vector3[] route = { new Vector3(-135, -562, 0), new Vector3(822, -569, 0), new Vector3(826,-421,0), new Vector3(-162,-423,0), new Vector3(-168,-285,0), new Vector3(396,-295,0) };
    Vector3[] rotation = { new Vector3(270, 0, 0), new Vector3(0, 90, -90), new Vector3(270, 0, 0), new Vector3(0,-90 ,90), new Vector3(270,0 ,0 ), new Vector3(0,90,-90) };
    void Start()
    {
        currNumOfSpawns = 0;
        this.StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        while (currNumOfSpawns<numOfSpawns)
        {
            currNumOfSpawns++;
            float timeBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(timeBetweenSpawns);
            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z);
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, positionOfSpawnedObject, Quaternion.identity);
        }
    }
    public Vector3[] getRoute()
    {
        return route;
    }
    public Vector3[] getRotation()
    {
        return rotation;
    }
}
