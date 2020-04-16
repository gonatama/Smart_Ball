using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    static int StartNum = 30;
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

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void TitleMove()
    {
        SceneManager.LoadScene("Title");
    }

    public void GameOverMove()
    {
        SceneManager.LoadScene("End");
        
    }
}
