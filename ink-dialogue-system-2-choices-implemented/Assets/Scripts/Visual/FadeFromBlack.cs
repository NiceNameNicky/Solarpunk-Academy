using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeFromBlack : MonoBehaviour
{
    public GameObject black;
    public RectTransform blackRect;
    public float fadeInTime;
    public float fadeOutTime;

    private void Start()
    {
        black.SetActive(true);
        Debug.Log("start");
        FadeIn();
    }

    //Scene ends
    public void FadeOut(string name)
    {
        black.SetActive(true);
        var tempColor = black.GetComponent<Image>().color;
        tempColor.a = 0f;
        black.GetComponent<Image>().color = tempColor;
        LeanTween.alpha(blackRect, to: 1f, time: fadeOutTime).setEase(LeanTweenType.linear);
        LeanTween.delayedCall(gameObject, fadeOutTime, () => {
            NextScene(name);
        });
    }

    public void FadeIn()
    {
        var tempColor = black.GetComponent<Image>().color;
        tempColor.a = 1f;
        black.GetComponent<Image>().color = tempColor;
        LeanTween.alpha(blackRect, to: 0f, time: fadeInTime).setEase(LeanTweenType.linear).setOnComplete(Disabling);
    }

    public void Disabling()
    {
        black.SetActive(false);
    }

    public void NextScene(string name)
    {
        SceneManager.LoadScene(name);
    }

}
