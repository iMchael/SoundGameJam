using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerTest : MonoBehaviour
{
    public GameManager GameManager;
    public LifeIcon LifeIcon;
    private string enemyTag = "enemy";
    void OnCollisionEnter(Collision collision) // Health Manager
    {
        Debug.Log("è’ìÀÇµÇΩÇÊ");
        Debug.Log(GameManager.CurrentHP);

            if (collision.gameObject.CompareTag(enemyTag))
            {
                GameManager.CurrentHP--;
                LifeIcon.SetLifeGauge(GameManager.CurrentHP);
                LifeIcon.SetLifeGauge2(1);
            }

    }

    private void Update()
    {
        
    }

 
}
