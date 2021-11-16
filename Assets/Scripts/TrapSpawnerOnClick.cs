using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpawnerOnClick : MonoBehaviour
{
    [SerializeField] EnemyTrapper prefabToSpawn;
    [SerializeField] float zOffset=-2f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);
            Vector3 adjustedPosition = new Vector3(position.x,position.y,zOffset);
            Spawn(adjustedPosition);
        }
    }

    void Spawn(Vector3 position)
    {
        Instantiate(prefabToSpawn.gameObject).transform.position = position;
    }
}
