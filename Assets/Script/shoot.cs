using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    [SerializeField] float Speed = 0.0f;
    private Rigidbody rb;
    bool chamber_in = false;
    //bool chamber_out = true;
    GameObject cap,obj;
    [SerializeField]private Vector3 Cap_point;
    private string BallName;
    public Material[] _material;

    public int i;
    // Start is called before the first frame update
    void Start()
    {
        cap = GameObject.Find("chamber_cap");
        this.rb = GetComponent<Rigidbody>();
        //this.rb.AddForce(Vector3.back, ForceMode.VelocityChange);
        Cap_point = new Vector3(cap.transform.position.x, cap.transform.position.y, cap.transform.position.z + 0.2f);
        this.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (this.chamber_in == true)
        {
            this.i = 1;
            //chamber_out = fasle;
            if (Input.GetKey("a"))
            {
                Debug.Log(this.i);
                //ChangeMaterial(i);
                this.GetComponent<Renderer>().material = _material[i];

                this.Speed += 5.0f;
                if(this.Speed >= 500.0f)
                {
                    this.Speed = 500.0f;
                }

            }
            if (Input.GetKeyUp("a"))
            {
               
                this.transform.position = Cap_point;
                this.chamber_in = false;
                //this.rb.velocity = new Vector3(0, 0, Speed);
                this.rb.AddForce(new Vector3(1, 0, 1) * this.Speed);
                Debug.Log("発射！");
                //Debug.Log(this.rb.velocity.magnitude);
                //this.Speed = 0.0f;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "chamber_wall")
        {

            //Debug.Log("発射位置へ接触しました.");
            //Debug.Log("移動完了");
            if (this.chamber_in == false)
                this.chamber_in = true;

        }

    }

    public void ReinitializationBall(string name)
    {
        Debug.Log("呼ばれました。");
    }
    //void OnTriggerEnter(Collider collider)
    //{
    //    if (collider.gameObject.tag == "Detection")
    //    {
    //        Debug.Log(collider.gameObject.tag);
    //        Debug.Log("通過しました");
    //        Destroy(this.obj);
    //        //this.obj.SetActive(false);

    //    }
    //}
    //void ChangeMaterial(int i)
    //{

    //        this.GetComponent<Renderer>().material = _material[i];
    //}
}
