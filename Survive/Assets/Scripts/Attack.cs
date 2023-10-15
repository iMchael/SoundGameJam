using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameManager GameManager;
    private string enemyTag = "enemy";
    void OnTriggerEnter(Collision collision)
    {

        if (GameManager.StillAlive == true)
        {
            if (collision.gameObject.CompareTag(enemyTag))
            {
                int Addscore = 3000;
                GameManager.score += Addscore;
                Debug.Log(Addscore);
                Destroy(gameObject);

            }
        }
    }
}
