using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrapper : MonoBehaviour
{
    [SerializeField] string tag;
    [SerializeField] string obj;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == tag)
        {
            Debug.Log("Exterminated a rat!");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            GameObject.Find(obj).GetComponent<StageClear>().incrementCounter();
        }
    }
}
