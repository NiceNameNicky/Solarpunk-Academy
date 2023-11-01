using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoods : MonoBehaviour
{
    public CharacterName Name;
    public List<Animator> Avia;
    public List<Animator> Jagger;
    public List<Animator> Song;

    public Animator GetMoodSprite(CharacterName name, CharacterMood mood)
    {
        switch (name)
        {
            case CharacterName.Avia:

                switch (mood)
                {
                    case CharacterMood.Normal:
                        return Avia[0];
                    case CharacterMood.Happy:
                        return Avia[1] ?? Avia[0];
                    case CharacterMood.LowSpirit:
                        return Avia[2] ?? Avia[2];
                    default:
                        Debug.Log($"Didn't find Sprite for character: {Name}, mood: {mood}");
                        return Avia[0];
                }

            case CharacterName.Jagger:

                switch (mood)
                {
                    case CharacterMood.Normal:
                        return Jagger[0];
                    case CharacterMood.Happy:
                        return Jagger[1] ?? Jagger[0];
                    case CharacterMood.LowSpirit:
                        return Jagger[2] ?? Jagger[2];
                    default:
                        Debug.Log($"Didn't find Sprite for character: {Name}, mood: {mood}");
                        return Jagger[0];
                }

            case CharacterName.Song:

                switch (mood)
                {
                    case CharacterMood.Normal:
                        return Song[0];
                    case CharacterMood.Happy:
                        return Song[1] ?? Song[0];
                    case CharacterMood.LowSpirit:
                        return Song[2] ?? Song[2];
                    default:
                        Debug.Log($"Didn't find Sprite for character: {Name}, mood: {mood}");
                        return Song[0];
                }

            default:
                Debug.Log($"Didn't find the character: {Name}, mood: {mood}");
                return Avia[0];
        }
    }
}
