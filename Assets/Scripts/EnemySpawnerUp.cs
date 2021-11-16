using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerUp : MonoBehaviour
{
    [SerializeField] int numOfSpawns = 10;
    int currNumOfSpawns;
    [SerializeField] MoverUp prefabToSpawn;
    [Tooltip("Minimum time between consecutive spawns, in seconds")] [SerializeField] float minTimeBetweenSpawns = 2f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")] [SerializeField] float maxTimeBetweenSpawns = 8f;
    Vector3[] route = {new Vector3(835,-41,0), new Vector3(-155,-39,0), new Vector3(-168,-164,0), new Vector3(828,-166,0), new Vector3(838,-294,0), new Vector3(261,-288,0) };
    Vector3[] rotation = { new Vector3(90,90,-90), new Vector3(0,270,90), new Vector3(90,270,90), new Vector3(180,270,90), new Vector3(90, 270, 90), new Vector3(0, 270, 90) };
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
