using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int rotationOffset;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        #if UNITY_ANDROID
        
        #else
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Rotate(rotationOffset,0,0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(-rotationOffset,0,0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(0,-rotationOffset,0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(0,rotationOffset,0);
        }
        #endif
       
    }
}
