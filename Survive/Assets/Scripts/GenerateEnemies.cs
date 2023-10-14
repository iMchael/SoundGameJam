using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());

    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 1)
        {
            xPos = Random.Range(-20, -3);
            zPos = Random.Range(-4, 3);

            Instantiate(theEnemy, new Vector3(xPos, -0.5f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount++;
        }
    }
}
