using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverDown : MonoBehaviour
{
    Vector3[] route;
    Vector3[] rotation;
    [SerializeField] float speed = 5f;
    float EPS = 0.0001f;
    int currentPoint;
    // Start is called before the first frame update
    void Start()
    {
        currentPoint = 0;
        route = GameObject.Find("EnemySpawnerDown").GetComponent<EnemySpawnerDown>().getRoute();
        rotation = GameObject.Find("EnemySpawnerDown").GetComponent<EnemySpawnerDown>().getRotation();
        transform.rotation = Quaternion.LookRotation(rotation[currentPoint]);
        Debug.Log(route);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, route[currentPoint]) < EPS)
        {
            currentPoint++;
            transform.rotation = Quaternion.LookRotation(rotation[currentPoint]);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, route[currentPoint], speed * Time.deltaTime);
        }
    }
}
