using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PhoneController : MonoBehaviour
{
    [Header("Universal Panels")]
    public GameObject phonePanel;
    public bool phoneVisible = false;
    bool phoneIsMoving = false;
    public GameObject phoneIcon;
    public GameObject closePhoneIcon;
    public GameObject masterPanel;
    bool masterVisible = false;
    public GameObject choicePanel;
    public bool dialogueIsLocked = false;
    public DialogueManager dialogueManager;

    [Header("Scene-Specific Panels")]
    //public GameObject SceneSpecificManager;
    public List<GameObject> Tips = new List<GameObject>();
    public List<bool> TipRead = new List<bool>();
    public int sceneIndex;

    [Header("Phone UI Components")]
    public GameObject phoneUIManager;
    public AudioClip unlock;
    private AudioSource audioSource;

    private void Awake()
    {
        //Tips = SceneSpecificManager.GetComponent<Scene1_1Window>().Tips;
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        if(sceneIndex == 1)
        {
            phoneIcon.SetActive(false);
            closePhoneIcon.SetActive(false);
        }
        phonePanel.transform.position = new Vector3(Screen.width * 1.5f, Screen.height * 0.5f, transform.localPosition.z);
    }

    private void Update()
    {
        if (InputManager.GetInstance().GetPPressed())
        {
            if ((sceneIndex > 2) || TipRead[0])
            {
                if (!phoneIsMoving/* && !masterVisible*/)
                {
                    if (!phoneVisible)
                    {
                        EnterPhonePanel();
                    }
                    else
                    {
                        if (sceneIndex != 1 || TipRead[1])
                        {
                            ExitPhonePanel();
                        }
                    }
                }
            }
            phoneIsMoving = true;
        }

        if (sceneIndex == 1 && phoneUIManager.GetComponent<PhoneUIController>().Panels[3].activeSelf && !TipRead[1])
        {
            //Tips[1].SetActive(true);
            TipRead[1] = true;
            closePhoneIcon.SetActive(true); 
        }
    }

    public void OpenPhonePanel()
    {
        phonePanel.SetActive(true);
        phoneUIManager.GetComponent<PhoneUIController>().OpenAPanel(1);
        phoneIcon.SetActive(false);
    }

    public void EnterPhonePanel()
    {
        phoneVisible = !phoneVisible;
        
        //Interface change
        phoneIcon.SetActive(false);
        phonePanel.SetActive(true);

        //Display a locked screen on the phone
        phoneUIManager.GetComponent<PhoneUIController>().OpenAPanel(0);

        //Animation of phone entering
        phonePanel.transform.position = new Vector3(Screen.width * 1.5f, Screen.height * 0f, transform.localPosition.z);
        LeanTween.moveX(phonePanel, Screen.width * 1f, 0.3f).setEase(LeanTweenType.linear).setOnComplete(() =>
        {
            //Display the home screen with unlock sound
            phoneUIManager.GetComponent<PhoneUIController>().OpenAPanel(1);
            phoneIsMoving = false;
            audioSource.PlayOneShot(unlock);

            //Tutorial in the first scene
            if (sceneIndex == 1 && !TipRead[2])
            {
                Tips[2].SetActive(true);
                TipRead[2] = true;
            }
        });
    }

    public void ClosePhonePanel()
    {
        phonePanel.SetActive(false);
        phoneIcon.SetActive(true);
        phoneVisible = !phoneVisible;
        Tips[2].SetActive(false);
        EnterMasterPanel("below", false);
    }

    public void ExitPhonePanel()
    {
        phoneVisible = !phoneVisible;
        Debug.Log("Exiting");
        phoneUIManager.GetComponent<PhoneUIController>().OpenAPanel(0);
        audioSource.PlayOneShot(unlock);
        phonePanel.transform.position = new Vector3(Screen.width * 1.5f, Screen.height * 0.5f, transform.localPosition.z);
        /*LeanTween.moveX(phonePanel.GetComponent<RectTransform>(), Screen.width * 1.5f, 0.3f).setEase(LeanTweenType.linear).setOnComplete(() =>
        {*/
            phoneIsMoving = false;
            phoneIcon.SetActive(true);
            Tips[2].SetActive(false);
            EnterMasterPanel("below", false);
            Debug.Log("Still Exiting");
        /*});*/
    }

    public void EnterMasterPanel(string from, bool skip)
    {
        if (!masterVisible)
        {
            //phoneIcon.SetActive(false);
            masterVisible = true;
            
            if (from == "left")
            {
                masterPanel.transform.position = new Vector3(Screen.width * -0.5f, Screen.height * 0.5f, transform.localPosition.z);
                LeanTween.moveX(masterPanel, Screen.width * 0.5f, 0f).setEase(LeanTweenType.linear).setOnComplete(() =>
                {
                    dialogueIsLocked = false;
                    if (skip)
                    {
                        //dialogueManager.GetComponent<DialogueManager>().ContinueStory();
                    }
                });
            }
            else if (from == "below")
            {
                masterPanel.transform.position = new Vector3(Screen.width * 0.5f, Screen.height * -0.5f, transform.localPosition.z);
                LeanTween.moveY(masterPanel, Screen.height * 0.5f, 0f).setEase(LeanTweenType.linear).setOnComplete(() =>
                {
                    dialogueIsLocked = false;
                    //dialogueManager.GetComponent<DialogueManager>().ContinueStory();
                    if (skip)
                    {
                        //dialogueManager.GetComponent<DialogueManager>().ContinueStory();
                    }
                });
            }
        }
    }

    public void AdjustChoicePanel(float size)
    {
        choicePanel.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, size);
    }
   
    public void ShowMasterPanel(string from, bool skip)
    {
        EnterMasterPanel(from, skip);
    }

    public void HideMasterPanel(string from)
    {
        if (masterVisible)
        {
            phoneIcon.SetActive(true);
            masterVisible = false;
            dialogueIsLocked = true;
            if (from == "left")
            {
                masterPanel.transform.position = new Vector3(Screen.width * 0.5f, transform.position.y, transform.localPosition.z);
                LeanTween.moveX(masterPanel, Screen.width * -0.5f, 0.5f).setEase(LeanTweenType.linear).setOnComplete(() =>
                {
                });
            }
            else if (from == "below")
            {
                //masterPanel.transform.position = new Vector3(transform.position.x, Screen.height * 0.5f, transform.localPosition.z);
                LeanTween.moveY(masterPanel, Screen.height * -0.5f, 0.5f).setEase(LeanTweenType.linear).setOnComplete(() =>
                {
                });
            }
        }
    }

    public void ShowTip(int index)
    {
        Tips[index].SetActive(true);
        TipRead[index] = true;
    }
    public void HideTip(int index)
    {
        Tips[index].SetActive(false);
    }

    public void PlaySound(AudioClip audio, float volume)
    {
        audioSource.PlayOneShot(audio, volume);
    }
}
