using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunct : MonoBehaviour
{
    public GameObject button;
    public Text text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (IsCloseEnough(button, (float)0.7))
            {
                text.text = "Button has been pushed";
            }
        }
    }

    bool IsCloseEnough(GameObject gameObject1, float maxDist)
    {
        float distX =  transform.position.x - gameObject1.transform.position.x;
        float distY = transform.position.y - gameObject1.transform.position.y;
        float distZ = transform.position.z - gameObject1.transform.position.z;
        float dist = Mathf.Sqrt(distX + distY + distZ);
        if (dist < maxDist)
        {
            return true;
        }
        return false;
    }
}
