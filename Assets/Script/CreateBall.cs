using System.Collections;
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

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            num += 15;
        }

        if (BallActive() == false)
        {
            Debug.Log("初期化条件を満たしました");
            num = 0;
            //cnt = 0;
            return;
        }

        if (stop == false)
        {
            if (num > 0)
            {
                int localcnt = 0;
                localcnt = cnt + num;

                if (localcnt > 300)
                {
                    cnt = 0;
                    num = localcnt - num;
                }




                for (int i = 0; i < num; i++)
                {
                    //if()
                    Debug.Log(cnt);

                    GameObject obj = BallList[cnt + i];
                    if (obj.activeSelf == false)
                    {
                        obj.SetActive(true);
                        obj.transform.position = CreateBallPoint;
                        
                    }
                    else
                    {
                        i--;
                        cnt++;
                        Debug.Log(cnt);
                    }

                    //if (cnt == 300)
                    //{
                    //    Debug.Log("初期化条件１");
                    //}
                }
                cnt += num;
                num = 0;
            }
            else
            {
                return;
            }
        }
    }



    //void BallActive(int num)
    //{
    //    GameObject obj = BallList[num];

    //    if (obj.activeSelf == false)
    //    {
    //        Debug.Log("false");
    //    }
    //    else if(obj.activeSelf == true)
    //    {
    //        Debug.Log("true");
    //    }
    //}

    bool BallActive()
    {
        foreach (Transform child in transform)
        {
            if (child.gameObject.activeSelf == true)
            {
                n++;
                //Debug.Log(n);
            }
        }

        if(n >= 299)
        {
            n = 0;
            stop = true;
            return false;

        }
        else
        {
            n = 0;
            stop = false;
            return true;
        }
    }
}
