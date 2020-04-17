using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSystem : MonoBehaviour
{
    public static SceneSystem instance = null;
    public static int ChangeNum = 0;
    public static string Changename;
    public static int LoadBallNum=0;
    public static int StartBall = 30;
    public static bool start = false;
    public static bool Continued = false;
    public static bool btnCheck = false;

    public static int Score = 0;


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



    //static int StartNum = 30;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        SaveCheck();
    }

    public static string ChangeGame()
    {
        //string name;
        if (ChangeNum == 0)
        {
            Changename = "SampleScene";
            //SceneManager.LoadScene("SampleScene");
        }
        else if (ChangeNum == 1)
        {
            Changename = "End";
            //SceneManager.LoadScene("End");
        }
        else if (ChangeNum == 2)
        {
            Changename = "Title";
            //SceneManager.LoadScene("Title");
        }
        ChangeNum++;
        ChangeNum = ChangeNum % 3;
        return Changename;
    }


    public static int LoadData()
    {
        int i = PlayerPrefs.GetInt("SAVEDATA", 0);
        return i;
    }

    public static void SaveCheck()
    {
        if (PlayerPrefs.HasKey("SAVEDATA") == true)
        {
            //int i = PlayerPrefs.GetInt("SAVE", 0);
            //Debug.Log(i);
            btnCheck = true;
            LoadBallNum = LoadData();

        }
        else if(PlayerPrefs.HasKey("SAVEDATA") == false)
        {
            btnCheck = false;
            Debug.Log("セーブデータがありません。");
        }


        if (PlayerPrefs.HasKey("SCORE") == true)
        {
            Debug.Log(Score);
            Score = PlayerPrefs.GetInt("SCORE", 0);
            Debug.Log(Score);
        }
        else if(PlayerPrefs.HasKey("SCORE") == false)
        {
            Score = 0;
            Debug.Log(Score);
        }
    }

}
