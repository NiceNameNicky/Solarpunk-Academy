EXTERNAL HideMaster(from)
EXTERNAL ShowTip(index)
EXTERNAL ShowCharacter(name, position, index)
EXTERNAL HideCharacter(name)
EXTERNAL MoveCharacter(name, position)
EXTERNAL ChangeMood(name, mood)
EXTERNAL NextScene(name)

//{ShowCharacter("Jagger", 0, 0)}
#name River
Wow!
{ChangeMood("Jagger", 1)}
What a fantastic view!
#name Jagger
{ChangeMood("Jagger", 4)}
Everyone’s room has great views.
{ChangeMood("Jagger", 7)}
It’s all because the forest itself looks amazing. Gha-hah-hah!
{ChangeMood("Jagger", 1)}
#name River
It surely does.
#name Jagger
So, did you look around the school?
#name River
Um. I didn’t have the time to.
#name Jagger
Did something happen?
*[Yes.]Some... Very confusing things happened.
    There's a guy with snake scales growing on his face threatening to throw me out of here.
    #name Jagger
    {ChangeMood("Jagger", 10)}
    ......
    #name River
    ......
    #name Jagger
    ......
    {ChangeMood("Jagger", 7)}
    Gha-hah-hah!
    My bad! I should tell Song about you!
    {ChangeMood("Jagger", 4)}
    He can be a hell of a trouble sometimes.

*[No.]No... Nothing happened.

*[Sarcasm.]Well, totally nothing weird happened.
    Just a guy with snake scales growing on his face threatening to throw me out of here.
    #name Jagger
    {ChangeMood("Jagger", 40)}
    Oh... I see.
    My bad! I should tell Song about you earlier.
    He can be a hell of a trouble sometimes.

{ChangeMood("Jagger", 1)}
#name River
-Jagger, what is an [anomaly]? What is this place actually for?
#name Jagger
{ChangeMood("Jagger", 43)}
It’s a school!
#name River
......
#name Jagger
{ChangeMood("Jagger", 40)}
......
#name River
......
#name Jagger
{ChangeMood("Jagger", 7)}
Gha-hah-hah!
{ChangeMood("Jagger", 1)}
We’re a school of abnormal mutants.
Have you heard of this term on the news before?
#name River
Abnormal mutants...
Wasn’t it a crisis in the 2020s?
#name Jagger
{ChangeMood("Jagger", 10)}
Yes. Abnormal mutation crisis, caused by radioactive pollution.
Lots of babies are born deformed and malfunctional. Most of them died within months.
Their genes were altered to the point that modern science can’t explain.
{ChangeMood("Jagger", 1)}
#name River
But what’s that supposed to do with this school?
#name Jagger
Not all mutations were fatal. Some were even undetectable, and the babies lived on normally.
These kids would show signs of mutation in their puberty.
Some got illnesses, some gained abnormal powers…
{ChangeMood("Jagger", 4)}
And most had both.
{ChangeMood("Jagger", 1)}
#name River
So that’s what this school is for. Patients with superpower?
#name Jagger
{ChangeMood("Jagger", 4)}
They are all just students… But special ones.
{ChangeMood("Jagger", 1)}

#name River
May I ask some questions?
->QUESTIONS

===QUESTIONS===
#name Jagger
Please ask any questions in your mind.
*Do people know about this school?#name River
    I don’t see this school on G-Map. Do people even know there’s a school here?
    #name Jagger
	I do want to keep all these low-key.
    I know people in the G-Map product team, so I deregistered the place.
    {ChangeMood("Jagger", 4)}
	But, as you can see – this is no top secret.
    {ChangeMood("Jagger", 1)}
	We naturally have these mountains and woods as barriers.
    ->QUESTIONS
*Does anyone know about these students?#name River
    Are these abnormal superpowers known to the world?
    #name Jagger
	The public doesn’t know. Most exposures of abnormal abilities were seen as urban mysteries.
    {ChangeMood("Jagger", 46)}
	But… Not only do the big corps know about these, they are getting their hands on it.
	#name River
	Oh… That doesn’t sound good.
	#name Jagger
    {ChangeMood("Jagger", 10)}
	They lock the anomalies up and do experiments on them.
    We don’t have a lot of students here. But every one you see here is one of the luckiests.
    ->QUESTIONS
*Are you also an anomaly?#name River
	#name Jagger
	What made you think I am one?
	#name River
	Avia looks totally normal too. But she is an anomaly, right? She just doesn’t show.
	If you are an ordinary person, why did you do all these for the anomalies?
	#name Jagger
    {ChangeMood("Jagger", 1)}
	I wasn’t born in the era of the mutation crisis. 
    {ChangeMood("Jagger", 4)}
    I’m not an anomaly, just a retired man with some free cash.
    //{ChangeMood("Gerald", 7)}
    I do this simply because I like teaching. Gha-hah-hah!
    {ChangeMood("Jagger", 1)}
    #name River
    He lied twice in a row.
    What’s his intention? What power does he have?
    ->QUESTIONS
*[I'm done.]
* ->
{ChangeMood("Jagger", 1)}
Any more questions?#name Jagger
#name River
-I think I’m done for now.
#name Jagger
{ChangeMood("Jagger", 7)}
Great! Let’s talk about your stay here! Gha-hah-hah!
Doubled pay, daily expenses covered, blah blah blah. And a nice room!
{ChangeMood("Jagger", 1)}
#name River
All these benefits… Just for a temporary stay?
#name Jagger
We need you for at least 10-15 days, until a professional therapist comes.
{ChangeMood("Jagger", 7)}
But I won’t force you, because I’m sure you will love the days here and settle down. Gah-hah-hah!
{ChangeMood("Jagger", 1)}
#name River
We’ll see!
#name Jagger
Oh, and one more thing.
{ChangeMood("Jagger", 40)}
You may need to sleep in either your office or a student dorm, because we don’t have bedrooms for faculty yet…
{ChangeMood("Jagger", 1)}
#name River
Hmm… Song will probably beat me up if I sleep near him.
Can I see the office first?
#name Jagger
{ChangeMood("Jagger", 7)}
You got it! Gah-hah-hah!


{NextScene("1.5 River's Office")}

-> END