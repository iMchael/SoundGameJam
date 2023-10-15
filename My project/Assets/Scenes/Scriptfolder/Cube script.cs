using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubescript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()//ÉLÉÖÅ[ÉuÇÃìÆÇ≠å¸Ç´
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        { 
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.1f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.1f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
}
