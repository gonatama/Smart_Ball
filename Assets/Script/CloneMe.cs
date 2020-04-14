using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneMe : MonoBehaviour
{
    [ContextMenu("CloneMe")]
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CloneObj()
    {
        for(int i = 1; i<5; i++)
        {
            var obj = (GameObject)GameObject.Instantiate(gameObject);
            obj.transform.parent = transform.parent;
            obj.transform.localPosition = transform.position + Vector3.right * i;
        }
    }
}
