using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    //[SerializeField] const int[] i;
    [SerializeField] public bool create;
    [SerializeField] private GameObject obj;
    [SerializeField] public int Num1;  //int[] CreateNum
    [SerializeField] private int Num;
    public int[] NumList;
    
    // Start is called before the first frame update
    void Start()
    {
        //Num1 = 0;

        NumList = new int[] { 0, 5, 15 };
        Debug.Log(NumList[1]);
        //Debug.Log(GetInstanceID());
    }

    // Update is called once per frame
    void Update()
    {
        if (create == true)
        {
            
            GameManager.instance.SetCreateNum(Num);
            //GameManager.instance.SetCreateNum(NumList[1]);
            CreateBall();
        }
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

    public void GetNum(int num)
    {
        Num = num;
        Debug.Log(Num);
        Debug.Log(num);
    }

}
