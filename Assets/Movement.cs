using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hinput = 0f;
        float vinput = 0f;

         if(Input.GetKey(KeyCode.W))
        {
            vinput = 1f;
        }
         if(Input.GetKey(KeyCode.S))
        {
            vinput = -1f;
        }
         if(Input.GetKey(KeyCode.A))
        {
            hinput = 1f;
        }
         if(Input.GetKey(KeyCode.D))
        {
            hinput = -1f;
        }

    }
    public void Move()
    {
       
    }
}
