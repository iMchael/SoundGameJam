using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeJumpScript : MonoBehaviour
{
    public float jumpPower;
    private Rigidbody rb;
    //’Ç‰Á
    private bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //’Ç‰Á
        if (Input.GetKeyDown(KeyCode.Space)&& !isJumping)
        {
            rb.velocity = Vector3.up * jumpPower;
            isJumping = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Terrain"))
        {
            isJumping = false;
        }
    }
}
