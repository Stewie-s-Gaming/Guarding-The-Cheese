using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyEnemies : MonoBehaviour
{
    [SerializeField] int numOfHits = 10;
    [SerializeField] string tag;
    [SerializeField] string scenceName;
    int curNumOfHits = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == tag)
        {
            curNumOfHits++;
            Destroy(other.gameObject);
            Debug.Log("Another hit!");
            if (curNumOfHits >= numOfHits)
            {
                SceneManager.LoadScene(scenceName);
            }
        }
    }
}
