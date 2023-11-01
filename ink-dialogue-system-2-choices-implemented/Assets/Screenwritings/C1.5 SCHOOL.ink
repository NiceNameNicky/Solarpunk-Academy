EXTERNAL ShowCharacter(name, position, index)
EXTERNAL HideCharacter(name)
EXTERNAL MoveCharacter(name, position)
EXTERNAL ChangeMood(name, mood)
EXTERNAL NextScene(name)
EXTERNAL MoveCam(x, y, z, t)

#name River
This building is... Strange. And beautiful.
{MoveCam(2, 3.5, -7, 0.3)}
Just as I guessed, it’s a renovated old mansion, with a... How do I even call this? A huge glass glitterball?
#name Jagger
{MoveCam(0, 2.5, -10, 0.1)}
{ShowCharacter("Jagger", 0, 7)}
Gah-hah-hah!
#name River
{MoveCam(0, 3, -9, 0.2)}
SHIT!
{MoveCam(0, 3.5, -8, 0.2)}
Why do you have to scare me when you show up?
#name Jagger
{ChangeMood("Jagger", 4)}
You were just too focused on the scenery.
{MoveCam(0, 2.5, -10, 0.3)}
It’s beautiful, isn’t it?
#name River
{ChangeMood("Jagger", 1)}
<i>Jagger is indeed an old guy.</i>
Did you renovate this?
#name Jagger
Yeah. Me... and some robots. Plus some technicians to handle the boring work.
{ChangeMood("Jagger", 4)}
This mansion was abandoned in the 2000s. A tree grew through its roof, so I reshaped it to adapt the tree.
#name River
Interesting...
#name Jagger
{ChangeMood("Jagger", 1)}
So anyway, how was your trip?
#name River
...
*[Pretty good.]Pretty comfortable. First time on a first-class seat.
	#name Jagger
    {ChangeMood("Jagger", 7)}
	Gah-hah-hah! Knew you would like it.
    {ChangeMood("Jagger", 43)}
	What did they have for lunch?
	#name River
    {ChangeMood("Jagger", 1)}
	Uh… Garlic butter toast and shrimp cocktail.
	#name Jagger
    {ChangeMood("Jagger", 4)}
	Ahh. Shrimp cocktail, my favorite.
    {ChangeMood("Jagger", 1)}
	That was your first time in first-class?
	#name River
	What about it?
	#name Jagger
    {ChangeMood("Jagger", 20)}
	How! I thought Evelyn left you a big fortune!
	#name River
	...
    {ChangeMood("Jagger", 1)}
	You know my grandma?
	#name Jagger
    {ChangeMood("Jagger", 4)}
	More than “knowing”.
*[Cut to the chase.]That’s not the point, Jagger. Let’s cut to the chase.
	#name Jagger
    {ChangeMood("Jagger", 4)}
	Oh, yeah. Sure. 
-I will guide you through a lot of stuff later, but whatever questions you have, bring it on.{ChangeMood("Jagger", 1)}
#name River
Well, Jagger.
You see, I have a million questions in my mind right now, with the biggest one being who the hell are you.
#name Jagger
{ChangeMood("Jagger", 43)}
I’m Jagger!
#name River
......
#name Jagger
{ChangeMood("Jagger", 40)}
......
#name River
......
#name Jagger
{ChangeMood("Jagger", 7)}
Gah-hah-hah!
{ChangeMood("Jagger", 4)}
That was a funny one, isn’t it?
#name River
...
*I guess?
	#name Jagger
    {ChangeMood("Jagger", 43)}
    {MoveCam(0, 4, -7, 0.2)}
	Wealth can be earned, and knowledge can be learned. But one can only be born with a great sense of humor.
*[Not at all.]How would you even find it funny?
	#name Jagger
    {ChangeMood("Jagger", 40)}
	Aww. I waited for that line!
#name Jagger
-Anyway.{ChangeMood("Jagger", 1)}{MoveCam(0, 2.5, -10, 0.2)}
I was an old friend and colleague of your grandmother, Evelyn. I visited you when you were little.
#name River
{MoveCam(0, 3, -9, 0.2)}
So you worked in the same company?!
#name Jagger
Same corp, same lab, same project.
She was the Psychology expert in the team, I was the lead engineer.
#name River
{MoveCam(0, 2.5, -10, 0.2)}
What’s the project called?
#name Jagger
{ChangeMood("Jagger", 40)}
Uhh...
It’s a secret project.
#name River
{ChangeMood("Jagger", 1)}
Weird. Grandma never told me about you, or any secret project she has done.
#name Jagger
Of course. Because it’s a secret project!
#name River
So there’s a chance that you are making things up, and I can’t even find proof?
#name Jagger
{ChangeMood("Jagger", 46)}
Yikes...
I can confirm some information about Evelyn if you really want proof.
#name River
{ChangeMood("Jagger", 1)}
...
*[I trust you.]I will trust you so far. Since when did you work with her?
	#name Jagger
	From the late-2010s to the mid-2020s.
*[I want some proof.]I’m listening.
#name Jagger
	Evelyn owns a necklace with an orange crystal on it. The crystal is an artificial product.
	#name River
	Good try Jagger, but she used to wear that necklace everywhere.
She’s a world-class psychologist, loads of people saw it. She even left it to me.
	#name Jagger
    {ChangeMood("Jagger", 4)}
	Well… If you have it, you should know it’s not only a necklace.
    {ChangeMood("Jagger", 1)}
	It’s also a brainwave amplifier.
	She used it to hypnotize individuals and observe their brain activities.
	#name River
	That’s... very specific. and accurate.
	#name Jagger
    {ChangeMood("Jagger", 43)}
	Want me to keep going?
	#name River
	...
	**[I trust you.]I will trust you so far. Since when did you work with her?
    {ChangeMood("Jagger", 1)}
	#name Jagger
	From the late-2010s to the mid-2020s.
	#name River
	...
	**[I want more proof.]You got more to tell?
    	#name Jagger
    	Evelyn was an ocean life lover and had a collection of seashells.
    	She had a tattoo of a dolphin on her shoulder.
    	#name River
    	…and?
    	#name Jagger
        {ChangeMood("Jagger", 46)}
    	It covered up a scar from an experiment. Acid burn, leaving a brown mark on her.
    	#name River
        {ChangeMood("Jagger", 1)}
    	Seriously, how did you know all these?
    	#name Jagger
        {ChangeMood("Jagger", 7)}
    	I told you. Gah-hah-hah!
        {ChangeMood("Jagger", 4)}
    	I also remember some things about little River.
        {MoveCam(0, 3, -9, 0.5)}
        When you were still a tiny bean, when was that... In 2025?
        {MoveCam(0, 3.5, -8, 0.5)}
        Evelyn bought a fish tank and put some goldfish in it. You stared at them every day.
        {MoveCam(0, 4, -7, 0.5)}
        One day, Evelyn didn't came to the lab. She said she has some"personal emergency".
        {MoveCam(0, 4.3, -6, 0.5)}
        Turned out that she took you to the hospital, because you almost drowned in the bathtub because you thought you were a fish.
        {ChangeMood("Jagger", 7)}
        It took her a long time to find out the reason why. Gah-hah-hah!!
    	#name River
        {ChangeMood("Jagger", 7)}
        {MoveCam(0, 2.5, -10, 0.2)}
    	Ok. Ok. That’s enough! You have my trust.
-One more question, "Jagger".{ChangeMood("Jagger", 1)}#name River
Why would you need me as a therapist? I’m not even remotely professional.
#name Jagger
{ChangeMood("Jagger", 4)}
Good question! Gah-hah-hah!
{ChangeMood("Jagger", 1)}
{MoveCharacter("Jagger", -2)}
Reason one, recruiting a professional therapist requires excessive amounts of legal papers. 
It usually takes about 10 to 15 days.
#name River
You must have some really urgent problems then.
#name Jagger
{ChangeMood("Jagger", 46)}
Yes... We have some students that need mental help as soon as possible.
Even some short-term counseling helps.
{ChangeMood("Jagger", 4)}
{MoveCharacter("Jagger", 2)}
Reason two, you have incredible talents.
{ChangeMood("Jagger", 1)}
As far as I know, you can immediately understand people’s thoughts and emotions since you were little.
#name River
I thought no one else knows this besides me and Grandma.
#name Jagger
{ChangeMood("Jagger", 7)}
She didn't tell me a lot either, and that’s why I’m so curious!
{ChangeMood("Jagger", 1)}
{MoveCharacter("Jagger", 0)}
{MoveCam(0, 2.5, -10, 0.3)}
You could be an incredible therapist. I want to see your real talent shine.
{ChangeMood("Jagger", 43)}
{MoveCam(0, 4, -7, 0.3)}
Not in some corporate business, but in this academy of ours, where the future of our world lies...
#name River
{MoveCam(0, 2.5, -10, 0.2)}
Yeah, yeah. I get it, Professor X.
{ChangeMood("Jagger", 1)}
Are you doing all this for my grandma’s sake?
Did you owe her something that you want to pay back through helping me?
#name Jagger
{ChangeMood("Jagger", 40)}
Uhh...
<u>Well, I didn’t necessarily owe her something...</u>
#name River
{MoveCam(0, 4.3, -6, 3)}
<i>His tone is not confident.</i>
<i>Just like Jagger said, I’m good at understanding people’s feelings.</i>
<i><b>If I hear an <u>undertone</u> beneath their words, they are telling lies.</b></i>
<i>Jagger clearly owed grandma a lot. But what did he do?</i>
#name Jagger
{ChangeMood("Jagger", 1)}
{MoveCam(0, 2.5, -10, 0.2)}
I invited you here because I need help, and so do you.
{ChangeMood("Jagger", 7)}
This school may headstart your dream job. Gah-hah-hah!
#name River
You said this school is special?
#name Jagger
{ChangeMood("Jagger", 4)}
One-of-a-kind.
#name River
In what way?
#name Jagger
{ChangeMood("Jagger", 43)}
{MoveCam(0, 3, -8, 0.2)}
The students. Unique, one-of-a-kind, SUPER TALENTED students.
{MoveCam(0, 2.5, -10, 0.2)}
{ChangeMood("Jagger", 1)}
We can talk about it later in my office on the third floor.
{MoveCharacter("Jagger", 2)}
Now excuse me, as I go upstairs to turn on some facilities...
#name River
Facilities? What kind?
#name Jagger
{ChangeMood("Jagger", 20)}
Uh... 
{ChangeMood("Jagger", 1)}
<u>Air conditioner.</u>
#name River
{ChangeMood("Jagger", 1)}
<i>A lie again. What could that “facility” be?</i>
{MoveCam(2, 2.5, -10, 0.2)}
Well. Take your time turning on that <b>AIR CONDITIONER</b>! I will just sit here and wait.
#name Jagger
{ChangeMood("Jagger", 7)}
{MoveCharacter("Jagger", 6)}
Feel free to walk around for a minute! Gah-hah-hah!!

{MoveCharacter("Jagger", 16)}
{HideCharacter("Jagger")}

#name River
...A school in the woods, a self-claimed old friend, a double-salary offer...
And I haven’t even seen one student around here.
Sounds like the beginning of a poorly written urban horror movie.



{ShowCharacter("Song", -24, 16)}
#name Unknown
{MoveCam(-7, 2.5, -10, 0.3)}
And you sound like you're lost.
#name River
{MoveCam(-24, 2.5, -10, 0.7)}
Uhh... Who are you?
I was indeed very lost a minute ago.
#name Unknown
{ChangeMood("Song", 18)}
I don’t think you understand what I mean. You don’t belong here. Out, now.
#name River
...
*[Explain to him.]I’m here for an invitation from your principal.
	#name Unknown
    {ChangeMood("Song", 16)}
	Jagger? Are you a new student?
	#name River
	I’m not here to be a student.
	#name Unknown
    {ChangeMood("Song", 18)}
	Are you an anomaly?
	#name River
	What anomaly?
	#name Unknown
    {ChangeMood("Song", 16)}
    {MoveCam(-24, 3, -8, 0.2)}
	Then you don’t belong here.
	#name River
	I’m sorry, what does an anomaly even mean?
*[None of your business.]You don’t own this school, so It’s none of your business, I suppose?
	#name Unknown
    {ChangeMood("Song", 16)}
    Are you an anomaly?
	#name River
	What anomaly?
	#name Unknown
    {ChangeMood("Song", 18)}
    {MoveCam(-24, 3, -8, 0.2)}
	THEN GET OUT.
	#name River
	What does that even supposed to mean?
-...#name Unknown
Do I look like I have the patience to explain it to you?{ChangeMood("Song", 16)}
    {MoveCam(-24, 3.5, -7, 0.2)}
#name River
Then you have no right to kick me out either.{MoveCam(-24, 3.5, -7, 0.2)}
#name Unknown
{ChangeMood("Song", 18)}
......
{MoveCam(-24, 3.5, -5, 0.1)}
{ChangeMood("Song", 117)}
Listen up, weakling.
This is OUR place. Only anomalies are welcomed here.
#name River
<i>...What happened?</i>
<i>Did he just grow scales on his face?</i>
<i>What is he? What is this place?</i>
#name Unknown
{ChangeMood("Song", 116)}
{MoveCam(-24, 3, -8, 0.8)}
Yeah... Be terrified, as you should, WEAKLING.
I trust Jagger. He brought be all the way from my home country.
He would NEVER betray us and bring in a normal person, so you can shut your lying mouth.
{ChangeMood("Song", 117)}
{MoveCam(-24, 3.5, -7, 0.1)}
Get out of here before I throw you out!

{ShowCharacter("Avia", -17.5, 13)}

#name Unknown
{MoveCam(-24, 2.5, -8, 0.1)}
Calm yourself down, big guy!
#name Unknown
{ChangeMood("Song", 10)}
Avia?
#name Unknown
{ChangeMood("Song", 1)}
{MoveCam(-22, 2.5, -10, 0.4)}
What’s up with you again, Song? Where do you think you are at, an arena?
#name Song
We have a trespasser.
#name Avia
{ChangeMood("Avia", 10)}
That’s not the reason to use your power.
You see, wouldn’t you make the problem bigger when you reveal it?
#name Song
{ChangeMood("Song", 17)}
......
{MoveCharacter("Song", -26)}
Avia! Don’t tell me what to do!
#name Avia
{ChangeMood("Avia", 1)}
{ChangeMood("Song", 16)}
{MoveCam(-20, 3, -8, 0.3)}
What’s your name, stranger?
#name River
River. 
#name Avia
{ChangeMood("Avia", 4)}
Oh... So YOU are River!
{ChangeMood("Avia", 1)}
{ChangeMood("Song", 1)}
Avia. Nice meeting you. Did Jagger bring you in?
#name River
Exactly.
#name Avia
{ChangeMood("Avia", 1)}
{MoveCam(-22, 2.5, -10, 0.3)}
Song, River is telling the truth. I heard we have a new mental therapist coming in.
#name Song
{ChangeMood("Song", 16)}
Mental therapist? This punk right here?
#name River
I was indeed checking out a therapist position here.
*[But this place looks unfriendly.]But I see the students clearly don’t want me here, and I’m rethinking my choice.
	#name Avia
    {ChangeMood("Avia", 4)}
	Song is not the easiest person to get along with.
    {ChangeMood("Avia", 1)}
	The world outside left him with serious trauma, hence his bad attitude.
    #name River
	The world outside?
*[But this place feels so weird.]But this school feels weird from every aspect. I’m afraid I can’t stay for longer.
-I see.#name Avia
{ChangeMood("Avia", 4)}
{ChangeMood("Song", 1)}
{MoveCam(-20, 3, -8, 0.3)}
You still don’t know much about Solarpunk Academy and our kind, do you?
#name River
Your kind?
#name Avia
{ChangeMood("Avia", 1)}
This is a school for “special” students, with abnormal powers.
#name River
I still don’t get it. It’s not like X-Men have come to real life, is it?
#name Avia
{ChangeMood("Avia", 4)}
That sounds cool, but we are not X-Men.
{ChangeMood("Avia", 1)}
We only have a little extra talent compared to the normal people.
#name River
I still don’t understand. Are those scales also your "talents"?
#name Song
{MoveCam(-22, 2.5, -10, 0.3)}
{ChangeMood("Song", 18)}
Of course you don’t. You will NEVER understand us.
{ChangeMood("Song", 16)}
Take my words as a warning. If anything happens, you are done.

{HideCharacter("Song")}

#name River
{ChangeMood("Avia", 46)}
{MoveCam(-17.5, 2.5, -10, 0.5)}
......
#name Avia
......
That’s Song for you.
{ChangeMood("Avia", 1)}
Anyway, Abnormal traits. Unnatural abilities. Call it whatever you want. Everyone here has one.
#name River
I’m losing my brain cells trying to keep up with this conversation, but I’m listening.
#name Avia
It’s ok. 
I too, don't know why Jagger chose a normal person as the school's therapist.
But I trust him... Maybe he just couldn't find an anomaly therapist.
{ChangeMood("Avia", 4)}
Go talk to him. He will explain everything much better.
#name River
I suppose.
{ChangeMood("Avia", 1)}
Avia... One more question before I go.
#name Avia
Yes?
#name River
Those scales on Song’s face. Are they real?
#name Avia
{MoveCam(-17.5, 4, -7, 0.4)}
Hmm...
{ChangeMood("Avia", 4)}
<u>They are pretty safe.</u>
<u>Don’t worry about it… He wouldn’t actually hurt you.</u>
{MoveCam(-17.5, 2.5, -10, 0.3)}
I’ll see you around, River.

{HideCharacter("Avia")}

#name River
...
Well, shit.

{NextScene("C1.6 JAGGER")}
