using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubedistancerangescript : MonoBehaviour
{
    [SerializeField] float speed;
    //XÇÃè„å¿
    float xLimit = 12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        transform.Translate(new Vector3(x, 0, 0) * speed * Time.deltaTime);
        Vector3 currentPos = transform.position;

        currentPos.x = Mathf.Clamp(currentPos.x, -xLimit, xLimit);

        transform.position = currentPos;

    }
}
