using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //SceneNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Change();
        }
    }

    public static void Change()
    {
        // イベントに登録
        SceneManager.sceneLoaded += LoadGame;
        string scene_name = SceneSystem.ChangeGame();
        // シーン切り替え
        SceneManager.LoadScene(scene_name);
        
    }

    private static void  LoadGame(Scene next, LoadSceneMode mode)
    {
        // //シーン切り替え後のスクリプトを取得
        //var gameManager = GameObject.FindWithTag("ManagerScene").GetComponent<ManagerSceneScript>();


        //イベントから削除
        SceneManager.sceneLoaded -= LoadGame;
    }
}
