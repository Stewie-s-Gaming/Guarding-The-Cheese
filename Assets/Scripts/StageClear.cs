using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageClear : MonoBehaviour
{
    float destroyedEnemyCounter=0;
    [SerializeField] int enemyGoal=20;
    [SerializeField] string sceneName;
    // Update is called once per frame
    void Update()
    {
        if (destroyedEnemyCounter >= enemyGoal)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void incrementCounter()
    {
        destroyedEnemyCounter++;
    }
}
