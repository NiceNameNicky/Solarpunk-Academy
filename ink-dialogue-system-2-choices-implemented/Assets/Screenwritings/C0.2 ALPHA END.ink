EXTERNAL ShowCharacter(name, position, index)
EXTERNAL HideCharacter(name)
EXTERNAL MoveCharacter(name, position)
EXTERNAL ChangeMood(name, mood)
EXTERNAL NextScene(name)
EXTERNAL MoveCam(x, y, z, t)

#name River
{ShowCharacter("Avia", 20, 19)}
{ShowCharacter("Song", 20, 116)}
{ShowCharacter("Cello", 20, 1)}
{ShowCharacter("Fred", 20, 22)}
{ShowCharacter("Jagger", 20, 19)}

Congratulations! You have played through all the content in the Alpha test of Solarpunk Academy.
In the upcoming chapters, you will be playing as a therapist and hold sessions with every character, including the ones that hasn't shown up yet:

{MoveCharacter("Avia", 0)}
"A flesh heart can sometimes be colder than a metal one."
{ChangeMood("Avia", 20)}
"You're the only person that listens to my past, River."
{MoveCharacter("Avia", -20)}

{MoveCharacter("Cello", 0)}
"There's no 'Artificial Intelligence'. There are only 'Slaves', and 'Me'."
{ChangeMood("Cello", 22)}
"River, being a robot scares me."
{MoveCharacter("Cello", -20)}

{MoveCharacter("Song", 0)}
"Speak, yell, let the world hear you. If one day you become mute, bite."
{ChangeMood("Song", 101)}
"Even an outlaw deserves justice, don't you think so, River?"
{MoveCharacter("Song", -20)}

{MoveCharacter("Fred", 0)}
"Hope is a lie. I don't see any; My eyes and my heart don't lie to me."
{ChangeMood("Fred", 19)}
"River, what if all my illusions are real?"
{MoveCharacter("Fred", -20)}

{MoveCharacter("Jagger", 0)}
"I’ve been there... I grew up there. I will give everything to keep us away from there."
{ChangeMood("Jagger", 16)}
"Solarpunk is my redemption, River."
{MoveCharacter("Jagger", -20)}

The first Beta test, including 3 new chapters, will be released on 6/22/2022.
Please visit <b>www.nickydu.net/sa</b> for downloads and more informations.

{NextScene("CO MENU")}
