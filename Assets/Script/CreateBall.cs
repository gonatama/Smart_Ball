﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    [SerializeField] private Vector3 CreateBallPoint;
    [SerializeField] private int n = 0;
    //private int StartNum;
    public int num = 0;
    [SerializeField] private int cnt = 0;
    [SerializeField] private GameObject obj;
    [SerializeField] private bool stop;
    private List<GameObject> BallList = new List<GameObject>();
    private GameSystem system;
    // Start is called before the first frame update
    void Start()
    {
        //int i = 0;
        obj = GameObject.Find("CreateBall");
        CreateBallPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        foreach(Transform child in transform)
        {
            BallList.Add(child.gameObject);
            //Debug.Log(BallList[i].name);
            //i++;
            //Debug.Log(BallList.Length);
        }

        num = 30;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject GameSystem = GameObject.Find("Transition");
            system = GameSystem.GetComponent<GameSystem>();
            system.GameOverMove();
        }
        
        if(Input.GetKeyDown(KeyCode.Return))
        {
            BallDelete();
        }


        if (Input.GetKeyDown(KeyCode.B))
        {
            num += 15;
        }

        //if (BallActive() == false)
        //{
        //    Debug.Log("初期化条件を満たしました");
        //    num = 0;
        //    //cnt = 0;
        //    return;
        //}

        int j = BallActive();
        //n = 0;

        if(j < num)
        {
            stop = true;
            j = 0;
            num = 0;
        }
        else if (j == 300)
        {
            GameObject GameSystem = GameObject.Find("Transition");
            GameSystem system = GameSystem.GetComponent<GameSystem>();
            system.GameOverMove();

        }
        else
        {
            stop = false;
            j = 0;
        }


        if (stop == false)
        {
                //int localcnt = 0;
                //localcnt = cnt + num;

                //if (localcnt > 300)
                //{
                //    cnt = 0;
                //    num = localcnt - num;
                //}




            for (int i = 0; i < num; i++)
            {
                    //if()
                    Debug.Log(cnt);
                if (cnt + i >= 300)
                {
                    cnt = 0;
                    num = 0;
                    return;
                }


                GameObject obj = BallList[cnt + i];
                    if (obj.activeSelf == false)
                {
                        obj.SetActive(true);
                        obj.transform.position = new Vector3(CreateBallPoint.x + ((float)i%15 / 10), CreateBallPoint.y, CreateBallPoint.z + ((float)i * 0.1f / 4));
                    //obj.GetComponent<Renderer>().material = obj._material[0];
                        obj.GetComponent<shoot>().ChangeMaterial(0);
                }
                else
                    {
                        i--;
                        cnt++;
                    Debug.Log(cnt);
                }

            }
                //cnt += num;

            num = 0;
        }
    }




    public int BallActive()
    {
        n = 0;
        foreach (Transform child in transform)
        {
            if (child.gameObject.activeSelf == false)
            {
                n++;

            }
        }
        Debug.Log(n);
        return n;
    }

    private void BallDelete()
    {
        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.SetActive(false);
        }

    }
}
