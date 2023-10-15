using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeJumpScript : MonoBehaviour
{
    public float jumpPower;
    private Rigidbody rb;
    //�ǉ�
    private bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //�ǉ�
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
