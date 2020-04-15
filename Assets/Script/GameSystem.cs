using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("SAVE"))
        {
            Debug.Log("SAVEデータは存在します。");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
        //BallCreateNum = 30;
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
