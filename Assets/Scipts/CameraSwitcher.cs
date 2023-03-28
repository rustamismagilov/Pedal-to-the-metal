using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject rearCamera;
    public GameObject driverCamera;


    void Start()
    {
        rearCamera.GetComponent<Camera>().enabled = true;
        driverCamera.GetComponent<Camera>().enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            rearCamera.GetComponent<Camera>().enabled = !rearCamera.GetComponent<Camera>().enabled;
            driverCamera.GetComponent<Camera>().enabled = !driverCamera.GetComponent<Camera>().enabled;
        }
    }


}
