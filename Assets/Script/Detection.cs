using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    [SerializeField] const int i = 0;
    [SerializeField] public bool create;
    [SerializeField] private GameObject obj;
    [SerializeField] private int[] CreateNum;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void CreateBall()
    {

        if (create == false)
        {
            create = true;
            Debug.Log("trueに切り替え");

        }
        else
        {
            create = false;
            Debug.Log("falseに切り替え");
        }

    }
    
    public void GetNum(string name)
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(create);

        //if (create == false)
        //{
        //    //Debug.Log("通過していません");
        //    return;
        //}
        if (create == true)
        {
            GameManager.instance.SetCreateNum(i);
            //Debug.Log(i);
            //create = false;
            CreateBall();
        }
    }


    //void OnTriggerEnter(Collider collision)
    //{
    //    if (collision.gameObject.tag == "ball")
    //    {
    //        Debug.Log("通過しました。");
    //        Debug.Log(this.name);
    //        Destroy(collision.gameObject);
    //        //obj.create = true;
    //        CreateBall();
    //        Debug.Log(create);
    //    }
    //}

}
