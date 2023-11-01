using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1_22FrontGate : MonoBehaviour
{
    Camera cam;
    public PhoneController phoneController;
    public GameObject tipOne;

    private void Start()
    {
        cam = Camera.main;
        //cam.GetComponent<CameraMovement>().cameraFrozen = true;
    }

    private void Update()
    {
        if (phoneController.TipRead[0])
        {
            //cam.GetComponent<CameraMovement>().cameraFrozen = false;
            if (cam.transform.position.x < -6)
            {
                tipOne.SetActive(false);
                cam.GetComponent<CameraMovement>().cameraFrozen = true;
                phoneController.GetComponent<PhoneController>().EnterMasterPanel("below", false);
            }
        }
    }
}
