using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SceneIntro : MonoBehaviour
{
    Camera cam;

    [Header("Intro")]
    public bool twoRolls = false;
    public bool unfreeze = false;
    public bool autoDialogue = false;
    public Vector3 initialPos;
    public float rolltime1;
    public Vector3 secondPos;
    public float rolltime2;
    public Vector3 finalPos;

    [Header("Show Character")]
    public bool showCharacter = false;
    public string CharacterName;
    public float CharacterPos;
    public int CharacterMood;

    [Header("UI")]
    public InputManager inputManager;
    public DialogueManager dialogueManager;
    public GameObject canvas;

    private void Awake()
    {
        cam = Camera.main;
    }

    private void Start()
    {
        gameObject.GetComponent<CameraMovement>().cameraFrozen = true;
        canvas.SetActive(false);
        inputManager.GetComponent<PlayerInput>().actions.Disable();
        roll1();

    }

    public void roll1()
    {
        cam.transform.position = initialPos;
        LeanTween.move(gameObject, secondPos, rolltime1).setEase(LeanTweenType.linear).setOnComplete(() =>
        {
            if (twoRolls)
            {
                roll2();
            }
            else
            {
                load();
            }
        });
    }

    public void roll2()
    {
        LeanTween.move(gameObject, finalPos, rolltime2).setEase(LeanTweenType.linear).setOnComplete(() =>
        {
            load();
        });
    }

    public void load()
    {

        inputManager.GetComponent<PlayerInput>().actions.Enable();
        if (unfreeze)
        {
            gameObject.GetComponent<CameraMovement>().cameraFrozen = false;
        }
        canvas.SetActive(true);

        if (showCharacter)
        {
            dialogueManager.GetComponent<DialogueManager>().ShowTheCharacter(CharacterName, CharacterPos, CharacterMood);
        }
    }
}
