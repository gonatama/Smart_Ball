using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public float Speed = 0.0f;
    private Rigidbody rb;
    bool chamber_in = false;
    //bool chamber_out = true;
    GameObject cap,obj;
    private Vector3 Cap_point;
    private string BallName;
    // Start is called before the first frame update
    void Start()
    {
        cap = GameObject.Find("chamber_cap");
        Debug.Log(cap.tag);
        this.rb = GetComponent<Rigidbody>();
        //Cap_point = new Vector3(cap.transform.localPosition.x, cap.transform.localPosition.y, cap.transform.localPosition.z);
        //cap_point = cap.transform.localPosition;
        Cap_point = new Vector3(cap.transform.position.x, cap.transform.position.y, cap.transform.position.z + 0.2f);

        //Debug.Log(cap_point.x);
        //Debug.Log(cap_point.y);
        //Debug.Log(cap_point.z);
        Debug.Log("生成されました。");
        Debug.Log(Cap_point.ToString("F4"));

    }

    // Update is called once per frame
    void Update()
    {
        
        if (this.chamber_in == true)
        {
            //chamber_out = fasle;
            if (Input.GetKey("a"))
            {

                this.Speed += 10.0f;
                if(this.Speed >= 500.0f)
                {
                    this.Speed = 500.0f;
                }
                Debug.Log("発射可能");
                Debug.Log(Cap_point.ToString("F4"));

            }
            if (Input.GetKeyUp("a"))
            {
                this.transform.position = Cap_point;
                this.chamber_in = false;
                //this.rb.velocity = new Vector3(0, 0, Speed);
                this.rb.AddForce(new Vector3(1, 0, 1) * this.Speed);
                Debug.Log("発射！");
                Debug.Log(this.rb.velocity.magnitude);
                //this.Speed = 0.0f;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "chamber_wall")
        {

            Debug.Log("発射位置へ接触しました.");
            //Debug.Log("移動完了");
            if (this.chamber_in == false)
                this.chamber_in = true;

        }

    }
}
