using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sensitivity = 6;
    private float rotateHorizontal;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            rotateHorizontal = Input.GetAxis("Mouse X");
            transform.Rotate(0, rotateHorizontal * sensitivity, 0);
        }
    }
}
