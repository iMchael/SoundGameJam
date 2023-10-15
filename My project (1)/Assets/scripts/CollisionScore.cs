using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CollisionScore : MonoBehaviour
{
    public GameManager GameManager;
    private string enemyTag = "enemy";
    [SerializeField] private GameObject player;


    void OnCollisionEnter(Collision collision)
    {

        if (GameManager.StillAlive == true)
        {
            if (collision.gameObject.CompareTag(enemyTag))
            {

                int Addscore = 0;
                Vector3 enemyPos = collision.gameObject.transform.position;
                Vector3 playerPos = player.transform.position;

                float dis = Vector3.Distance(enemyPos, playerPos);

                if (dis != 0)
                {

                    dis *= 1;
                    Addscore = 1000 / (int)dis;

                    if (Addscore >= 2000)
                    {
                        Addscore = 2000;
                    }

                    GameManager.score += Addscore;
                }
                Debug.Log(Addscore);
            }

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
