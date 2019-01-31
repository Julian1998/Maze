using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int rotationOffset;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        #if UNITY_ANDROID
        Debug.Log(Input.acceleration);
        //transform.rotation = Quaternion.Euler(-90 + gyros.gravity.x * 10, 90 + gyros.gravity.y * 10, 0);
        //transform.rotation *= Quaternion.Euler(0, 1, 0);
        float minRotation = -45;
        float maxRotation = -135;
        Vector3 tilt = Input.acceleration;
        tilt = Quaternion.Euler(90, 0, 0) * tilt;
        rb.AddForce(tilt);
        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.red);
        //Vector3 currentRotation = transform.rotation.eulerAngles;
        //currentRotation.y = Mathf.Clamp(currentRotation.y, minRotation, maxRotation);
        //transform.rotation = Quaternion.Euler (-90 + tilt * Mathf.Clamp(Input.acceleration.x, -1, 1) , 90 + tilt * Mathf.Clamp(Input.acceleration.y, -1, 1), 0);
        //transform.Rotate(Input.acceleration.x, Input.acceleration.y, 0);

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
    
    private static Quaternion GyroToUnity(Quaternion q)
    {
        //Debug.Log(q.eulerAngles);
        return (new Quaternion(q.x, q.y, 0, 0) * Quaternion.Euler(-90, 90, 0));
    }
}