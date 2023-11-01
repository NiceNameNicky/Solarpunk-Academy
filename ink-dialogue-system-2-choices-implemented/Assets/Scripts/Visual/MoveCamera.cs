using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(PlayerInput))]

public class MoveCamera : MonoBehaviour
{
    private Vector3 touchStart;
    public Camera cam;
    public float groundZ = 0;
    private bool MouseIsDown = false;

    private static MoveCamera instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one Input Manager in the scene.");
        }
        Debug.Log("Move Camera working");
        instance = this;
    }

    public static MoveCamera GetInstance()
    {
        return instance;
    }

    public void MouseDownPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            touchStart = GetWorldPosition(groundZ);
            MouseIsDown = true;
            Debug.Log("Mouse is Down!");
        }
        if (context.canceled)
        {
            MouseIsDown = false;
            Debug.Log("Mouse is Up!");
        }
    }

    void Update()
    {
        if (MouseIsDown)
        {
            Vector3 direction = touchStart - GetWorldPosition(groundZ);
            cam.transform.position += direction;
        }
    }

    private Vector3 GetWorldPosition(float z)
    {
        Ray mousePos = cam.ScreenPointToRay(Input.mousePosition);
        Plane ground = new Plane(Vector3.forward, new Vector3(0, 0, z));
        float distance;
        ground.Raycast(mousePos, out distance);
        return mousePos.GetPoint(distance);
    }
}