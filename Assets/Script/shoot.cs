using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public float Speed = 0.0f;
    //Rigidbody rb;
    bool chamber = false;
    GameObject cap;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        //Debug.Log(rb);
        //cap = GameObject.Find("chamber_wall");
        //cap = GetComponent<Superstructure>.Mainboard.Luncher.chamber_cap;
        //Debug.Log = (cap.transform.position.x);

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
            //transform.position = new Vector3(cap.transform.position.x, cap.transform.position.y, cap.transform.position.z);
            //Debug.Log("移動完了");
            transform.position = new Vector3(0.0f, 3.0f, 0.0f);
            chamber = true;
        }
    }


}

