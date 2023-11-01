using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneUIController : MonoBehaviour
{

    [Header("Interfaces")]
    public List<GameObject> Panels = new List<GameObject>();
    public ScrollRect emailScrollRect;

    [Header("Audio")]
    AudioSource audioSource;
    public AudioClip tap;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OpenAPanel(int panelIndex)
    {
        foreach (GameObject panel in Panels)
        {
            panel.SetActive(false);
        }
        if (panelIndex != 0)
        {
            audioSource.PlayOneShot(tap);
        }
        if (panelIndex == 2)
        {
            emailScrollRect.normalizedPosition = new Vector2(0, 1);
        }
        Panels[0].SetActive(true);
        Panels[panelIndex].SetActive(true);
    }

}
