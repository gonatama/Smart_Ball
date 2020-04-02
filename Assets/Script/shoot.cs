using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    private float Speed = 0;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {


            if (Input.GetKey("a"))
            {
                Speed += 0.05f;
            }
            if (Input.GetKeyUp("a"))
            {
                rb.velocity = new Vector3(0, 0, Speed);
                Speed = 0.0f;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "chamber_wall")
        {
            Debug.Log("発射位置へ接触しました.");
        }
    }


}

