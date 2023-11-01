using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeakerAvatar : MonoBehaviour
{
    public Sprite Avia1;
    public Sprite Evelyn1;

    public void ChangeAvatar(string _sprite)
    {
        GetSpeakerAvatar(_sprite);
    }

    public void GetSpeakerAvatar(string _spritename)
    {
        if (_spritename == null)
        {
            Debug.LogError("Can't find this prite named: " + _spritename);
        }
        else if(_spritename == "Avia1")
        {
            Debug.Log("Avatar is now Avia");
            GetComponent<Image>().sprite = Avia1;
        } 
        else if( _spritename == "Evelyn1")
        {
            GetComponent<Image>().sprite = Evelyn1;
        }
    }
}
