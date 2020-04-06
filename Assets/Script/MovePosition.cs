using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("muzzle_point");
    }

    // Update is called once per frame
    void Update()
    {
        
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
