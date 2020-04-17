using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckOnClick : MonoBehaviour
{
    private Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(SceneSystem.btnCheck);
        //if (SceneSystem.btnCheck == false)
        //{
        //    btn.interactable = false;
        //}
    }

    public void CheckClick()
    {
        SceneChange.Change();
        SceneSystem.start = true;
    }

    public void CheckClickContinue()
    {

        Debug.Log(SceneSystem.LoadBallNum);
        SceneSystem.Continued = true;
        SceneChange.Change();
    }

    public void DeleteCheckClick()
    {
        if(SceneSystem.btnCheck == true)
        {
            PlayerPrefs.DeleteKey("SAVEDATA");
        }
    }
}
