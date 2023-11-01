using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Linq;
using Assets.Scripts;

public class CharacterManager : MonoBehaviour
{
    private List<Character> _characters;

    [SerializeField]
    private GameObject _characterPrefab;

    private void Start()
    {
        _characters = new List<Character>();
    }

    public void ShowCharacter(string name, float position, int index)
    {
        //Parse the commands sent from the Ink scripts
        if (!Enum.TryParse(name, out CharacterName nameEnum))
        {
            Debug.LogWarning($"Something went wrong parsing this: {name}");
            return;
        }
        ShowCharacter(nameEnum, position, index, name);
    }

    public void ShowCharacter(CharacterName name, float position, int index, string nameString)
    {
        //Pick the correct character from the Enum list
        var character = _characters.FirstOrDefault(x => x.Name == name);

        //Character initiation
        if (character == null)
        {
            var characterObject = Instantiate(_characterPrefab, gameObject.transform, false);
            character = characterObject.GetComponent<Character>();
            _characters.Add(character);
        }
        else if (character.IsShowing)
        {
            Debug.LogWarning($"{name} is already here");
            return;
        }
        character.Init(name, position, index, nameString);
    }

    public void HideCharacter(string name)
    {
        if (!Enum.TryParse(name, out CharacterName nameEnum))
        {
            Debug.LogWarning($"Failed to parse character name to character enum: {name}");
            return;
        }
        HideCharacter(nameEnum);
    }

    public void HideCharacter(CharacterName name)
    {
        var character = _characters.FirstOrDefault(x => x.Name == name);
        if (character?.IsShowing != true)
        {
            Debug.LogWarning($"Character {name} is not currently shown. Can't hide it.");
            return;
        }
        else
        {
            character.Hide();
        }
    }

    public void ChangeMood(string name, string mood)
    {

        if (!Enum.TryParse(name, out CharacterName nameEnum))
        {
            Debug.LogWarning($"Failed to parse character name to character enum: {name}");
            return;
        }

        int moodEnum = int.Parse(mood);

        ChangeMood(nameEnum, moodEnum);
    }

    public void ChangeMood(CharacterName name, int mood)
    {
        var character = _characters.FirstOrDefault(x => x.Name == name);

        if (character?.IsShowing != true)
        {
            Debug.LogWarning($"Character {name} is not currently shown. Can't change the mood.");
            return;
        }
        else
        {
            character.ChangeMood(mood);
        }
    }

    public void MoveCharacter(string name, float position)
    {

        if(!Enum.TryParse(name, out CharacterName nameEnum))
        {
            Debug.LogWarning($"Failed to parse character name to enum: {name}");
            return;
        }

        MoveCharacter(nameEnum, position);
    }

    public void MoveCharacter(CharacterName nameEnum, float position)
    {
        var character = _characters.FirstOrDefault(x => x.Name == nameEnum);

        character.Move(position);
    }

    /*public CharacterMoods GetMoodSetForCharacter(CharacterName name)
    {
        switch (name)
        {
            case CharacterName.Avia:
                return _AviaMoods;
            case CharacterName.Gerald:
                return _MCMoods;
            case CharacterName.Song:
                return _SongMoods;
            default:
                Debug.LogError($"Could not find moodset for {name}");
                return null;
        }
    }*/
}
