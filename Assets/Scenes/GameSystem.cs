using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public static GameSystem instance = null;

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
        if(PlayerPrefs.HasKey("SAVE"))
        {
            //int i = PlayerPrefs.GetInt("SAVE", 0);
            //Debug.Log(i);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public static void TitleMove()
    {
        SceneManager.LoadScene("Title");
    }

    public static void GameOverMove()
    {
        SceneManager.LoadScene("End");
        
    }
}
