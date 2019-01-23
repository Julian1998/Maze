using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSDebug : MonoBehaviour
{
    private Text fps;
    // Start is called before the first frame update
    void Start()
    {
        fps = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        fps.text = "" + (int)(1.0f / Time.deltaTime);
    }
}
