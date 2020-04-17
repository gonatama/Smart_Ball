using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour
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
        Debug.Log(SceneSystem.btnCheck);
        if (SceneSystem.btnCheck == false)
        {
            btn.interactable = false;
        }
        else if (SceneSystem.btnCheck == true)
        {
            btn.interactable = true;
        }
    }
}
