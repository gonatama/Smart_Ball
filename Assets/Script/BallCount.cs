using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCount : MonoBehaviour
{
    //private Text CountBall;
    public Text Count = null;
    [SerializeField] GameObject obj;
    CreateBall script;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("CreateBall");
        script = obj.GetComponent<CreateBall>();
        Debug.Log(obj.name);
    }

    // Update is called once per frame
    void Update()
    {
            int count = script.BallActive();
            Debug.Log(count);
            count = 300 - count;
            Debug.Log(count);
            Count.text = /*"ボール数\n" +*/ count.ToString();
    }
}
