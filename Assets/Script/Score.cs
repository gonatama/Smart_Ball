using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject obj = null;
    private Text score_text;

    // Start is called before the first frame update
    void Start()
    {
        score_text = obj.GetComponent<Text>();
        SceneSystem.Score = PlayerPrefs.GetInt("SCORE", 0);
        Debug.Log(SceneSystem.Score);
        score_text.text = "GameOver\n"+"最高ボールストック数:" + SceneSystem.Score;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
