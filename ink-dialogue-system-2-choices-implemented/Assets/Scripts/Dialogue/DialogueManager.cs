using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private GameObject secondaryPanel;
    [SerializeField] private GameObject speakerNamePanel;
    [SerializeField] public TextMeshProUGUI dialogueText;
    [SerializeField] public TypeWriter typeWriter;
    //private Vector3 secondaryPanelPos;
    public Sprite bubbleSprite;
    public Sprite frameSprite;
    public TextMeshProUGUI speakerNameText;
    public GameObject continueIcon;

    [Header("Choices UI")]
    public GameObject[] choices;
    public TextMeshProUGUI[] choicesText;
    public GameObject choicesPanel;

    private Story currentStory;
    private string currentLine;
    public bool dialogueIsPlaying { get; private set; }
    public static bool choicesAreDisplayed;
    List<string> tags;

    private  CharacterManager _characterManager;

    private static DialogueManager instance;

    [Header("Sound")]
    public AudioClip boop1;
    public AudioClip bubble;
    public AudioClip[] clips;
    private AudioSource audioSource;

    [Header("Other")]
    public GameObject panelController;
    public GameObject phoneUIController;
    public GameObject speakerAvatar;
    Camera cam;
    //public static bool canDisplayChoices = false;
    private string from;

    private void Awake() 
    {
        cam = Camera.main;
        _characterManager = FindObjectOfType<CharacterManager>();

        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue Manager in the scene");
        }
        instance = this;
    }

    public static DialogueManager GetInstance() 
    {
        return instance;
    }

    private void Start() 
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        //secondaryPanelPos = secondaryPanel.transform.position;

        audioSource = GetComponent<AudioSource>();

        // get all of the choices text 
        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices) 
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }

    private void Update() 
    {
        if (!dialogueIsPlaying) 
        {
            return;
        }
        if (InputManager.GetInstance().GetSubmitPressed())
        {
            choicesPanel.gameObject.SetActive(false);
            Skip();
        }
        if (InputManager.GetInstance().GetOnePressed())
        {
            choicesPanel.gameObject.SetActive(false);
            Skip();
        }
        if (panelController.GetComponent<PhoneController>().dialogueIsLocked)
        {
            //dialogueIsPlaying = false;
        }
        else
        {
            //dialogueIsPlaying = true;
        }
        ContinueIcon();
/*        if (canDisplayChoices)
        {
            DisplayChoices();
            canDisplayChoices = false;
        }*/
    }

    public void Skip()
    {
        if (typeWriter.typing == false)
        {
            if (currentStory.currentChoices.Count == 0)
            {
                ContinueStory();
            }
        }
        else
        {
            typeWriter.SkipTyping();
        }
    }

    public void EnterDialogueMode(TextAsset inkJSON) 
    {
        currentStory = new Story(inkJSON.text);
        BindExternalFunctions();

        typeWriter.ActivateWriter();

        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        panelController.GetComponent<PhoneController>().EnterMasterPanel(from, false);
    }

    void BindExternalFunctions()
    {
        currentStory.BindExternalFunction("NextScene", (string name) => cam.GetComponent<FadeFromBlack>().FadeOut(name));
        from = "below";
        currentStory.BindExternalFunction("GoHome", () => SceneManager.LoadScene("0 Main Menu"));
        currentStory.BindExternalFunction("PlaySound", (int index) => audioSource.PlayOneShot(clips[index]));
        currentStory.BindExternalFunction("HideMaster", (string from) => panelController.GetComponent<PhoneController>().HideMasterPanel(from));
        currentStory.BindExternalFunction("ShowMaster", (string from, bool skip) => panelController.GetComponent<PhoneController>().ShowMasterPanel(from, skip));
        currentStory.BindExternalFunction("ShowTip", (int index) => panelController.GetComponent<PhoneController>().ShowTip(index));
        currentStory.BindExternalFunction("HideTip", (int index) => panelController.GetComponent<PhoneController>().HideTip(index));
        currentStory.BindExternalFunction("Inbox", (int index, bool ringtone) => phoneUIController.GetComponent<EmailManager>().NewMail(index, ringtone));
        currentStory.BindExternalFunction("MoveCam", (float x, float y, float z, float t)=> cam.GetComponent<CameraMovement>().MoveCam(x, y, z, t));
        currentStory.BindExternalFunction("ShowCharacter", (string name, float position, int index)=> _characterManager.ShowCharacter(name, position, index));
        currentStory.BindExternalFunction("HideCharacter", (string name)=> _characterManager.HideCharacter(name));
        currentStory.BindExternalFunction("ChangeMood", (string name, string mood)=> _characterManager.ChangeMood(name, mood));
        currentStory.BindExternalFunction("MoveCharacter", (string name, float position)=> _characterManager.MoveCharacter(name, position));
    }

    public void ShowTheCharacter(string name, float position, int index)
    {
        _characterManager.ShowCharacter(name, position, index);
    }

    private IEnumerator ExitDialogueMode() 
    {
        yield return new WaitForSeconds(0.2f);

        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
    }

    public void ContinueStory() 
    {
        if(panelController.GetComponent<PhoneController>().dialogueIsLocked)
        {
            Debug.Log("Noooo dialogue is locked");
        }
        else
        {
            if (currentStory.canContinue) 
            {
                // set text for the current dialogue line
                //dialogueText.text = currentStory.Continue();
                currentLine = currentStory.Continue();
                typeWriter.addWriter(dialogueText, currentLine, 0.03f);
                //audioSource.PlayOneShot(bubble);
                //Debug.Log(currentLine);
                ParseTags();
               // audioSource.PlayOneShot(bubble, 0.15f);
            }
            else 
            {
                StartCoroutine(ExitDialogueMode());
            }
        }
    }

    void ParseTags()
    {
        tags = currentStory.currentTags;
        foreach (string t in tags)
        {
            string prefix = t.Split(' ')[0];
            string param = t.Split(' ')[1];

            switch (prefix.ToLower())
            {
                case "name":
                    SetSpeakerName(param);
                    break;
                case "avatar":
                    speakerAvatar.GetComponent<SpeakerAvatar>().ChangeAvatar(param);
                    break;
            }
        }
    }

    void SetSpeakerName(string _name)
    {
        speakerNameText.text = _name;
        if(_name == "River" || _name == "RIVER")
        {
            speakerNamePanel.SetActive(false);
            LeanTween.moveY(secondaryPanel, Screen.height * 0.17f, 0.2f).setEase(LeanTweenType.easeOutQuad).setDelay(0f);
        }
        else
        {
            speakerNamePanel.SetActive(true);
            LeanTween.moveY(secondaryPanel, Screen.height * 0.25f, 0.2f).setEase(LeanTweenType.easeOutQuad).setDelay(0f);
        }
    }

    public void DisplayChoices() 
    {
        //Connect with Ink language
        List<Choice> currentChoices = currentStory.currentChoices;

        if (currentChoices.Count == 0)
        {
            choicesAreDisplayed = false;
        } else
        {
            choicesAreDisplayed = true;
        }

        if (choicesAreDisplayed)
        {
            choicesPanel.gameObject.SetActive(true);
        }
        else
        {
            choicesPanel.gameObject.SetActive(false);
        }

        //Debug when not enough slots for the choices
        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("Too many choices!" 
                + currentChoices.Count);
        }

        int index = 0;

        //Show all the choices available
        foreach(Choice choice in currentChoices) 
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }

        //Make sure all the empty slots are not showing
        for (int i = index; i < choices.Length; i++) 
        {
            choices[i].gameObject.SetActive(false);
        }

        StartCoroutine(SelectFirstChoice());
    }

    private IEnumerator SelectFirstChoice() 
    {
        // Event System requires we clear it first, then wait
        // for at least one frame before we set the current selected object.
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }

    public void MakeChoice(int choiceIndex)
    {
        if (!typeWriter.typing)
        {
            currentStory.ChooseChoiceIndex(choiceIndex);
            audioSource.PlayOneShot(boop1, 0.8f);
            // NOTE: The below two lines were added to fix a bug after the Youtube video was made
            InputManager.GetInstance().RegisterSubmitPressed(); // this is specific to my InputManager script
            ContinueStory();
            choicesPanel.gameObject.SetActive(false);
            Debug.Log("Choices made. Index: " + choiceIndex);
        }
    }

    void ContinueIcon()
    {
            if (dialogueIsPlaying && currentStory.currentChoices.Count == 0 && typeWriter.characterIndex >= 1)
            {
                continueIcon.SetActive(true);
            }
            else
            {
                continueIcon.SetActive(false);
            }

        if (dialogueIsPlaying && typeWriter.characterIndex >= 1)
        {
            if(currentStory.currentChoices.Count == 0)
            {
                continueIcon.SetActive(true);
            }
            else
            {
                if (typeWriter.typing)
                {
                    continueIcon.SetActive(true);
                }
                else
                {
                    continueIcon.SetActive(false);
                }
            }
        }
        else
        {
            continueIcon.SetActive(false);
        }
    }

}
