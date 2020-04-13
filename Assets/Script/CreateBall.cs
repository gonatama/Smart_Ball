using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    [SerializeField] private Vector3 CreateBallPoint;
    //[SerializeField] private int n = 0;
    //private int StartNum;
    public int num = 0;
    private int cnt = 0;
    [SerializeField] private GameObject obj;
    private List<GameObject> BallList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        obj = GameObject.Find("CreateBall");
        CreateBallPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        foreach(Transform child in transform)
        {
            BallList.Add(child.gameObject);
            Debug.Log(BallList[i].name);
            i++;
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            num += 5;
        }
        if (num > 0)
        {
            for (int i = 0; i < num; i++)
            {
                //if(cnt<300)
                //{
                //    cnt = 0;
                //}
                Debug.Log(cnt);
                
               GameObject obj = BallList[cnt + i];
                if (obj.activeSelf == false)
                {
                    obj.SetActive(true);
                    obj.transform.position = CreateBallPoint;
                }
                else
                    i--;
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
