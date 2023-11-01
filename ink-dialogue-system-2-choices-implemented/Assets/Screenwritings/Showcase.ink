EXTERNAL HideMaster(from)
EXTERNAL ShowTip(index)
EXTERNAL ShowCharacter(name, position, index)
EXTERNAL HideCharacter(name)
EXTERNAL MoveCharacter(name, position)
EXTERNAL ChangeMood(name, mood)
EXTERNAL NextScene(name)

{ShowCharacter("Avia", 0, 22)}
#name Avia
...
River. You know... Sometimes I just need someone to listen to me.
{ChangeMood("Avia", 19)}
But people are busy. They run around the city, encroaching upon the last piece of breadcrumb left after the feast.
Sometimes a flesh heart can be colder than a metal one.
{HideCharacter("Avia")}
#name River
...
...
{ShowCharacter("Song", 1, 1)}
...
#name Song
All I really want... Is justice for my family. For my people.
*Agree.
*Question.
    But why would you demand justice, if you commited crimes in the first place?#name River
{ChangeMood("Song", 16)}
-You bastard...#name Song
{ChangeMood("Song", 116)}
You will never understand why, because you were not raised in the gutter like me!
I will never...
{HideCharacter("Song")}

#name Song

