using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    private Vector3 CreateBallPoint;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject obj = (GameObject)Resources.Load("Prefab/Ball");
        CreateBallPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            GameObject obj = (GameObject)Resources.Load("Prefab/Ball");

            //Instantiate(obj, new Vector3(0.1f, 0.8f, -0.05f), Quaternion.identity);
            Instantiate(obj, CreateBallPoint, Quaternion.identity);

        }
    }
}
