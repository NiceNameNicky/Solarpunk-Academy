using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmailPin : MonoBehaviour
{
    public int index;

    private void Awake()
    {
        transform.SetAsFirstSibling();

        Button button = gameObject.GetComponent<Button>();
        GameObject PhoneUIController = GameObject.Find("PhoneUIManager");
        button.onClick.AddListener(() => { PhoneUIController.GetComponent<PhoneUIController>().OpenAPanel(3);});
        button.onClick.AddListener(() => { PhoneUIController.GetComponent<EmailManager>().FillEmail(index); });
    }
}
