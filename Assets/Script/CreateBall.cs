using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    [SerializeField] private Vector3 CreateBallPoint;
    [SerializeField] private int n = 0;
    [SerializeField] public int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject obj = (GameObject)Resources.Load("Prefab/Ball");
        CreateBallPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z);
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
                GameObject obj = (GameObject)Resources.Load("Prefab/Ball");
                obj.name = ("Ball" + n);
                //Instantiate(obj, new Vector3(0.1f, 0.8f, -0.05f), Quaternion.identity);
                Instantiate(obj, CreateBallPoint, Quaternion.identity);
                n++; 
                num--;
            }
        }
        else
        {
            return;
        }
    }
}
