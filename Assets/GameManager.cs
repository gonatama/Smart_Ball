using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int BallCreateNum = 0;
    [SerializeField] static bool transition;
    public static GameManager instance = null;
    private static GameObject Ball;
    private static CreateBall createBall;
    [SerializeField] private static GameSystem system;
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
        transition = false;
        Ball = GameObject.Find("CreateBall");
        createBall = Ball.GetComponent<CreateBall>();
        Debug.Log(createBall.name);
        Debug.Log(LoadData());
        BallCreateNum = 0;

    }

    // Update is called once per frame
    void Update()
    {


        if (BallCreateNum > 0)
        {
            Debug.Log(BallCreateNum);
            createBall.num += BallCreateNum;
            Debug.Log(createBall.num);
            BallCreateNum = 0;
        }

        if (transition == true)
            TransitionGame();

        if(Input.GetKeyDown(KeyCode.S))
        {

            int i = 300 - createBall.BallActive();
            SaveData(i);
            Debug.Log("セーブしました。");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            BallCreateNum = LoadData();
        }
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

        GameObject GameSystem = GameObject.Find("Transition");

        system = GameSystem.GetComponent<GameSystem>();
        system.GameOverMove();
        transition = false;

    }

    private void SaveData(int save)
    {

        PlayerPrefs.SetInt("SAVEDATA", save);
        PlayerPrefs.Save();
    }

    private int LoadData()
    {
        int i = PlayerPrefs.GetInt("SAVEDATA", 30);
        return i;
    }
}

