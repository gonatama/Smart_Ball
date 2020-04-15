using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int BallCreateNum = 0;
    [SerializeField] bool transition;
    public static GameManager instance = null;
    public static GameSystem system;
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
        transition = false;
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

        if (transition == true)
            TransitionGame();
    }

    public void SetCreateNum(int i)
    {
        BallCreateNum += i;
        Debug.Log(BallCreateNum);
    }

    public void SetTransitionFlag()
    {
        transition = true;
    }

    private void TransitionGame()
    {
        transition = false;
        GameObject GameSystem = GameObject.Find("Transition");
        Debug.Log(GameSystem.name);
        system = GameSystem.GetComponent<GameSystem>();
        system.GameOverMove();
    }

}
