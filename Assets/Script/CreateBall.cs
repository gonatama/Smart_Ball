using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GameObject obj = (GameObject)Resources.Load("Prefab/Ball");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            GameObject obj = (GameObject)Resources.Load("Prefab/Ball");

            Instantiate(obj, new Vector3(0.1f, 0.8f, 0.2f), Quaternion.identity);
        }
    }
}
