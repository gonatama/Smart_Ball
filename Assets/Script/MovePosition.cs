using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePosition : MonoBehaviour
{
    private Vector3 Cap_point;
    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("chamber_cap");
        Cap_point = new Vector3(obj.transform.position.x, obj.transform.position.y, obj.transform.position.z + 0.2f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            this.transform.position = Cap_point;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            Debug.Log("発射位置へ接触しました.");
            collision.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            //this.chamber = true;
        }
    }

}
