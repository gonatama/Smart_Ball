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
        BallCreateNum = 0;
    }

    // Update is called once per frame
    void Update()
    {


        if (BallCreateNum > 0)
        {
            Debug.Log(BallCreateNum);
            GameObject CreateBall = GameObject.Find("CreateBall");
            CreateBall obj = CreateBall.GetComponent<CreateBall>();
            obj.num +=  BallCreateNum;
            Debug.Log(obj.num);
            BallCreateNum = 0;
        }
    }

    public void SetCreateNum(int i)
    {
        BallCreateNum += i;
        Debug.Log(BallCreateNum);
    }


    //public static List<GameObject> GetAll(this GameObject obj)
    //{
    //    List<GameObject> allChildren = new List<GameObject>();
    //    GetChildren(obj, ref allChildren);
    //    return allChirderen;
    //}


}
