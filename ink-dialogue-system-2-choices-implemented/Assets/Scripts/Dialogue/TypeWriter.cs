using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TypeWriter : MonoBehaviour
{
    [Header("Typing")]
    [SerializeField] public TextMeshProUGUI dialogueText;
    private string textToWrite = "";
    public int characterIndex;
    private float timePerCharacter;
    public float timer;

    [Header("Debugging and Skipping")]
    public bool activated = false;
    public bool typing = false;
    public GameObject dialogueManager;

    public AudioSource typeWriterAudio;
    public AudioClip boop1;

    public void newDialogueText(string newText)
    {
        textToWrite = newText;
    }

    public void addWriter(TextMeshProUGUI uiText, string textToWrite, float timePerCharacter)
    {
        //Called from other scripts
        this.dialogueText = uiText;
        this.textToWrite = textToWrite;
        this.timePerCharacter = timePerCharacter;
        characterIndex = 0;
    }

    private void Update()
    {
        if (activated)
        {
            if (dialogueText != null)
            {
                timer -= Time.deltaTime;
                while (timer <= 0f)
                {
                    //Typing the characters one by one
                    timer += timePerCharacter;
                    characterIndex++;
                    dialogueText.text = textToWrite.Substring(0, characterIndex);

                    //Stop typing and display choices (if any)
                    if (characterIndex >= textToWrite.Length)
                    {
                        dialogueText = null;
                        typing = false;
                        dialogueManager.GetComponent<DialogueManager>().DisplayChoices();
                        return;
                    }
                    else
                    {
                        typing = true;
                    }
                }
            }
        }
    }

    public void ActivateWriter()
    {
        activated = true;
    }

    public void DeactivateWriter()
    {
        activated = false;
    }


    public void SkipTyping()
    {
        characterIndex = textToWrite.Length - 1;
        typing = false;
        //DialogueManager.canDisplayChoices = true;
    }
}
