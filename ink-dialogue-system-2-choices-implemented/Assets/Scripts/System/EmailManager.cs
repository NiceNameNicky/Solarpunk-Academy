using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using TMPro;

public class EmailManager : MonoBehaviour
{
    [Header("Email Interface")]
    public List<GameObject> Emails = new List<GameObject>();
    public GameObject email;
    Vector3 position = Vector3.zero;
    Quaternion rotation = Quaternion.identity;
    public Transform container;
    public GameObject emailContentTitle;
    public GameObject emailContentInfo;
    public GameObject emailContentText;

    [Header("Email Content")]
    public List<string> Titles = new List<string>();
    public List<string> Times = new List<string>();
    public List<string> Senders = new List<string>();
    public List<TextAsset> Contents = new List<TextAsset>();

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip newMessage;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        //Restore the previously saved email when the game restarts
        foreach (int _index in EmailSaver.EmailSaved)
        {
            NewMail(_index, false);
        }
    }

    public void NewMail(int index, bool ringtone)
    {
        //Decalre text objects in the Email prefab
        GameObject titleText;
        GameObject senderText;
        titleText = email.transform.GetChild(0).gameObject;
        senderText = email.transform.GetChild(1).gameObject;

        //Set the content of the Email
        email.GetComponent<EmailPin>().index = index;
        titleText.GetComponent<TextMeshProUGUI>().SetText(Titles[index]);
        senderText.GetComponent<TextMeshProUGUI>().SetText(Senders[index]);

        //Spawn the Email in the smartphone inbox panel
        Instantiate(email, container);

        //Play ringtone if declared in the Ink script
        if (ringtone)
        {
            audioSource.PlayOneShot(newMessage);
        }

        //Save the email to prevent re-send and to archive in the player profile
        EmailSaver.EmailSaved.Add(index);
    }

    public void FillEmail(int index)
    {
        
        emailContentTitle.GetComponent<TextMeshProUGUI>().SetText(Titles[index].ToString());
        emailContentInfo.GetComponent<TextMeshProUGUI>().SetText(Times[index].ToString() + "\n" + "From: " + Senders[index].ToString());
        emailContentText.GetComponent<TextMeshProUGUI>().SetText(Contents[index].ToString());
    }
}
