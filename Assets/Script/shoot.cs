using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public float Speed = 0.0f;
    //Rigidbody rb;
    bool chamber = false;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        //Debug.Log(rb);
    }

    // Update is called once per frame
    void Update()
    {
        if (chamber == true)
        {

            if (Input.GetKey("a"))
            {
                this.Speed += 1.0f;
                Debug.Log("発射可能");

            }
            if (Input.GetKeyUp("a"))
            {
                //this.rb.velocity = new Vector3(0, 0, Speed);
                //this.rb.AddForce(new Vector3(0, 0, 1) * this.Speed);
                Debug.Log("発射！");
                //this.Speed = 0.0f;
            }
        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "chamber_wall")
        {
            Debug.Log("発射位置へ接触しました.");
            collision.gameObject.transform.position = root.transform.position;
            chamber = true;
        }
    }


}

