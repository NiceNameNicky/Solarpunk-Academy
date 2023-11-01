EXTERNAL HideMaster(from)
EXTERNAL ShowTip(index)
EXTERNAL ShowCharacter(name, position, index)
EXTERNAL HideCharacter(name)
EXTERNAL MoveCharacter(name, position)
EXTERNAL ChangeMood(name, mood)
EXTERNAL NextScene(name)
EXTERNAL MoveCam(x, y, z, t)

{ShowCharacter("Jagger", -10, 1)}
{MoveCharacter("Jagger", 0)}

#name River
You really didn’t lie, Jagger. This room is beautiful.
#name Jagger
{ChangeMood("Jagger", 7)}
What did I tell you! Gah-gah-gah!
{ChangeMood("Jagger", 4)}
It's still kind of empty now, but wait until you move your stuff in.
#name River
{ChangeMood("Jagger", 1)}
You guys got a bed in the office?
#name Jagger
{MoveCam(0, 0, -10, 0.3)}
You see these two couches? They’re both expandable.
If you want an extra bed, I’ll ask the drones to deliver one to you tomorrow.
{MoveCam(0, 3, -10, 0.3)}
#name River
This is fine enough. These couches feel amazing.
#name Jagger
{ChangeMood("Jagger", 4)}
Good! Good!
Now go move your luggage in!
#name River
{ChangeMood("Jagger", 1)}
Wait, Jagger…
Aren’t we supposed to, like… sign a contract?
#name Jagger
{ChangeMood("Jagger", 7)}
Gah-hah-hah! I don’t care!
I already paid you full prize. Go check your inbox!
{ChangeMood("Jagger", 4)}
#name River
...
*[Thanks.]Jagger, you are the weirdest employer I’ve ever met. In a good way. I’ll take it!
*[I still want a contract.]Thanks, Jagger. But I still prefer a contract, just in case anything happens.
	#name Jagger
    {ChangeMood("Jagger", 46)}
	Alright, alright. I get it.
    {ChangeMood("Jagger", 1)}
	“From March 16th to March 26th, River will be helping at Solarpunk Academy!” How does that sound?
	#name River
	What about the rules and conditions?
	#name Jagger
    {ChangeMood("Jagger", 43)}
    {MoveCam(0, 4.5, -7, 0.2)}
	“River must not bully the service robots!"
	"Don’t hurt himself climbing the trees also!”
	#name River
    {MoveCam(0, 3, -10, 0.2)}
	...
	Whatever.
	#name Jagger
    {ChangeMood("Jagger", 4)}
	I will send you the contract later. If I can remember this. Gah-hah-hah!
-And...what am I supposed to do next?#name River
#name Jagger
{ChangeMood("Jagger", 1)}
Take a rest. There are plenty of students here in need of some mental counseling.
Maybe we can start with Fred tomorrow…
#name River
Fred?
#name Jagger
{ChangeMood("Jagger", 46)}
{MoveCam(0, 4, -8, 4)}
Yeah... Fred.
A pretty insecure kid, a self-claimed nihilist. 
{ChangeMood("Jagger", 10)}
He escaped from his parents because he was overwhelmed by anxiety. His whole power revolves around being scared.
#name River
{ChangeMood("Jagger", 1)}
So it's not a physical transformation?
#name Jagger
{MoveCam(0, 3, -10, 0.5)}
No. Both Fred and Avia have mind-based powers.
You should talk to them to find out what they are!
#name River
Can't you just tell me about their power right away?
#name Jagger
{ChangeMood("Jagger", 7)}
No! I like cliffhangers! Gah-hah-hah!!
#name River
Maybe tomorrow.
{ChangeMood("Jagger", 1)}
I already took in way too much information today. I think I’d better spend some time alone tonight.
#name Jagger
{ChangeMood("Jagger", 4)}
Take your time, kid. I know this is a lot to take in, but I promise you will not regret it.
{ChangeMood("Jagger", 7)}
I’ll see you tomorrow. Gah-hah-hah!

{MoveCharacter("Jagger", -20)}
{HideCharacter("Jagger")}
{MoveCam(0, 8, -10, 4)}
{NextScene("C1.8 NIGHT")}
