using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    [SerializeField] private float Speed;
    private Rigidbody rb;
    bool chamber_in = false;
    //bool chamber_out = true;
    GameObject cap,obj,mouse;
    [SerializeField]private Vector3 Cap_point;
    private string BallName;
    public Material[] _material;
    private InMouseSpeed GetMouse;
    public int i;
    [SerializeField] private static float MaxSpeed = 400.0f;
    // Start is called before the first frame update
    void Start()
    {
        cap = GameObject.Find("chamber_cap");
        mouse = GameObject.Find("MouseSpeed");
        GetMouse = mouse.GetComponent<InMouseSpeed>();
        this.rb = GetComponent<Rigidbody>();
        //this.rb.AddForce(Vector3.back, ForceMode.VelocityChange);
        Cap_point = new Vector3(cap.transform.position.x, cap.transform.position.y + 0.04f, cap.transform.position.z + 0.1f);
        this.gameObject.SetActive(false);
        //this.GetComponent<Renderer>().material = _material[0];

    }

    // Update is called once per frame
    void Update()
    {
        
        if (this.chamber_in == true)
        {
            this.i = 1;
            this.GetComponent<Renderer>().material = _material[i];

            //chamber_out = fasle;
            if (Input.GetKey("a"))
            {
                Debug.Log(this.i);
                //ChangeMaterial(i);

                this.Speed += 4.0f;
            }
            else if (Input.GetMouseButton(0))
            {
                this.Speed += (GetMouse.SetMouseSpeed() * (-2));
            }

            if (this.Speed >= MaxSpeed)
            {

                this.Speed = MaxSpeed;
            }
            else if (this.Speed < 0.0f)
            {
                this.Speed = 0.0f;
            }
            if ((Input.GetKeyUp("a")) || (Input.GetMouseButtonUp(0)))
            {

                //Debug.Log(this.Speed);
                this.transform.position = Cap_point;
                this.chamber_in = false;
                //this.rb.velocity = new Vector3(0, 0, Speed);
                this.rb.AddForce(new Vector3(1, 0, 1) * this.Speed);
                Debug.Log("発射！");
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "chamber_wall")
        {
            this.Speed = 2.0f;
            if (this.chamber_in == false)
                this.chamber_in = true;

        }

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
    public void ChangeMaterial(int i)
    {

        this.GetComponent<Renderer>().material = _material[i];
    }
}

