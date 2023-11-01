using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public float charPosition;
    public CharacterName Name { get; private set; }
    public CharacterMood Mood { get; private set; }

    [Header("Essentials")]
    public string charName;
    public Animator[] charImage;
    public bool IsShowing { get; private set; }


    [Header("Animations")]
    public int animIndex;


    private CharacterMoods _moods;
    private float _offScreenX;
    private float _onScreenX;
    private readonly float _animationSpeed = 0.5f;

    public void Init(CharacterName name, float position, int index, string nameString)
    {
        Name = name;
        charPosition = position;
        animIndex = index;
        charName = nameString;

        Show();
    }

    private void Start()
    {
        //GetComponent<Animator>().SetBool("Flashing", true);

        Debug.Log("Starting");

        switch (charName)
        {
            case "Avia":
                GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Avia") as RuntimeAnimatorController;
                break;
            case "Jagger":
                GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Jagger") as RuntimeAnimatorController;
                break;
            case "Song":
                GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Song") as RuntimeAnimatorController;
                break;
            case "Fred":
                GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Fred") as RuntimeAnimatorController;
                break;
            case "Cello":
                GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Cello") as RuntimeAnimatorController;
                break;
            default:
                Debug.Log("I don't recognize this character name: " + charName);
                break;
        }
    }

    public void Show()
    {

        SetAnimationValues();

        transform.position = new Vector3(charPosition, transform.position.y, 0);

        //UpdateSprite();

        GetComponent<Animator>().SetInteger("Index", 0);

        Color tmp = gameObject.GetComponent<SpriteRenderer>().color;
        tmp.a = 0;
        gameObject.GetComponent<SpriteRenderer>().color = tmp;

        LeanTween.alpha(gameObject, 1f, 0.3f).setEase(LeanTweenType.linear).setOnComplete(() =>
        {
            IsShowing = true;
            ChangeMood(animIndex);
        });

    }

    public void Hide()
    {

        LeanTween.alpha(gameObject, 0f, 1f).setEase(LeanTweenType.linear).setOnComplete(() =>
        {
            IsShowing = false;
        });
    }

    private void SetAnimationValues()
    {
        switch (charPosition)
        {
        }
    }

    public void ChangeMood(int moodIndex)
    {
        //Mood = mood;

        //UpdateSprite();

        GetComponent<Animator>().SetInteger("Index", moodIndex);

        Debug.Log("Index is: " + animIndex);
    }

    public void Move(float position)
    {
        LeanTween.moveX(gameObject, position, 0.3f).setEase(LeanTweenType.linear).setOnComplete(() =>
        {
        });
    }

    private void UpdateSprite()
    {
        //var spriteToDisplay = _moods.GetMoodSprite(Name, Mood);
        /*var image = GetComponent<Image>();

        image.sprite = spriteToDisplay;
        image.preserveAspect = true;*/


    }
}
