using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int BallCreateNum = 0;
    public static GameManager instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        BallCreateNum += 5;
    
    }

    // Update is called once per frame
    void Update()
    {


        if (BallCreateNum > 0)
        {
            GameObject CreateBall = GameObject.Find("CreateBall");
            CreateBall obj = CreateBall.GetComponent<CreateBall>();
            obj.num +=  BallCreateNum;
            BallCreateNum = 0;
        }
    }

    public void SetCreateNum(int i)
    {
        BallCreateNum += i;
        Debug.Log(BallCreateNum);
    }
}
