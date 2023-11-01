using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using Ink.Runtime;

public class Scenes : MonoBehaviour
{
    static Scenes instance;

    //public TextAsset inkAsset;
    //Story _inkStory;

    private void Update()
    {
    }

    public void BackToMainMenu()
    {
       //SceneManager.LoadScene("0 Main Menu");
    }

    public void MenuPage()
    {
        SceneManager.LoadScene("C0 MENU");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("C0.1 CREDIT");
    }

    public void SkipPrologue()
    {
        SceneManager.LoadScene("C1.5 SCHOOL");
    }

    public void CharPreview()
    {
        SceneManager.LoadScene("C0.2 ALPHA END");
    }


    public void TestScene()
    {
        SceneManager.LoadScene("Test");
    }

    public void NextSceneInTheList()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
