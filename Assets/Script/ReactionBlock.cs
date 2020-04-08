using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactionBlock : MonoBehaviour
{

    //[SerializeField] public GameObject obj;
    [SerializeField] private Detection anotherScript;
    [SerializeField] private int Num;
    // Start is called before the first frame update
    void Start()
    {
        //obj = GameObject.Find("Ball_Detection");
        anotherScript = GetComponentInParent<Detection>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //anotherScript.create = true;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            Debug.Log("通過しました。");
            Debug.Log(this.name);

            Destroy(collision.gameObject);
            anotherScript.CreateBall();

            //obj.CreateBall();
        }

    }

}
