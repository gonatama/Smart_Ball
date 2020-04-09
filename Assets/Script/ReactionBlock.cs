using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactionBlock : MonoBehaviour
{

    [SerializeField] public GameObject obj;
    [SerializeField] private Detection Script;
    [SerializeField] private int Num;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("Ball_Detection");
        Script = obj.GetComponent<Detection>();
        Debug.Log(Script.GetInstanceID());
        //anotherScript = GetComponentInParent<Detection>();
        //int i = anotherScript.CreateNum[0];
        //if (this.name == ("Cube_Detection(14)"))
        //{
        //    this.Num = 0;

        //}
        //else if(this.name == ("Cube_Detection(0)"))
        //{
        //    this.Num = 5;
        //}
        //else
        //{
        //    this.Num = 1;
        //}
        this.Num = SetNum(Script.Num1);
        //this.Num = Script.Num1;
        Debug.Log(Script.Num1);
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
            Script.CreateBall();
            Script.GetNum(this.Num);
            //obj.CreateBall();
        }

    }

    public int SetNum(int Num)
    {
        return Num;
    }

}
