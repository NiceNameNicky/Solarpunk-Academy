using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]

public class CameraMovement : MonoBehaviour
{
    private Vector2 moveDirection = Vector2.zero;

    private static CameraMovement instance;

    private bool Moving;
    private bool InBounds;
    Vector3 startPosition;
    Vector3 target;
    float timeToReachTarget;
    float t;
    private float finalMoveSpeed;
    public bool cameraFrozen;

    [Header("Custom values")]
    public float returnSpeed;
    public float moveSpeed;
    public float rangeL;
    public float rangeR;
    public float rangeU;
    public float rangeD;

    public Vector3 defaultPosition = new Vector3(0, 0, -10);


    private void Awake()
    {
        startPosition = target = defaultPosition;
        if (instance != null)
        {
            Debug.LogError("Found more than one Input Manager in the scene.");
        }
        instance = this;
    }

    public static CameraMovement GetInstance()
    {
        return instance;
    }

    void Update()
    {
        finalMoveSpeed = moveSpeed;
        //finalMoveSpeed = moveSpeed - 1.5f * Mathf.Sqrt(Mathf.Pow(transform.position.x, 2) + Mathf.Pow(transform.position.y, 2));
        if (transform.position.x > rangeR || transform.position.x < -rangeL)
        {
            moveDirection.x = 0;
        }
        if (transform.position.y > rangeU || transform.position.y < -rangeD)
        {
            moveDirection.y = 0;
        }

        if (!cameraFrozen)
        {
            if (Moving)
            {
                transform.Translate(Vector2.Scale(moveDirection, new Vector2(finalMoveSpeed, finalMoveSpeed)) * Time.deltaTime);
            }
            else
            {
                t = returnSpeed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target, t);
            }
        }
    }

    public void MovePressed(InputAction.CallbackContext context)
    {
        if (context.performed && DialogueManager.choicesAreDisplayed == false)
        {
            Moving = true; 
            moveDirection = context.ReadValue<Vector2>();
        }
        else if (context.canceled)
        {
            //moveDirection = context.ReadValue<Vector2>();
            Moving = false;
            //Debug.Log(startPosition);
        }
    }

    public void MoveCam(float x, float y, float z, float t)
    {
        LeanTween.move(gameObject, new Vector3(x, y, z), t).setEase(LeanTweenType.linear).setOnComplete(() =>
        {
        });
        defaultPosition = target = new Vector3(x, y, z);
    }
}
