// See https://aka.ms/new-console-template for more information

#region Comments

/*
  THE FOREST GAME (inspired by Rick and Morty)
  Interactive game where user tries to survive and escape the unknown
  Technical Practice: Use of user input, while loops, if statements, switch statements, type casting, use of lists
  
STRUCTURE:
First Action - In a Forest
Second Action - By Puddle
Third Action - Hear a Sound
Fourth Action - In Clearing
Fifth Action - Holding Object
Sixth Action - Look Closely
Seventh Action - What Can I Do?
Eighth Action - Which Way?
Ninth Action - Somethings Coming
Tenth Action - The Wreckage
Final Action - Trigger
 */

#endregion

#region Title

using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using static System.Formats.Asn1.AsnWriter;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("   --------------------");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("     THE FOREST GAME");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("     THE FOREST GAME");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("     THE FOREST GAME");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("   --------------------");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(" inspired by ");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Rick ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("and ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Morty");
Console.WriteLine();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine();
Console.WriteLine("PLEASE PRESS ENTER TO BEGIN");
Console.ReadKey();
Console.WriteLine();
#endregion

#region Introduction
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("-------------------------------------------------------------------");
Console.Write("IN THIS ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("GAME ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("YOU MUST TYPE WHICH ACTION YOU WOULD LIKE TO TAKE, ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("YOU MUST TRY TO ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("SURVIVE ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("AND FIND YOUR WAY TO SAFETY");
Console.WriteLine("KEEP YOUR ACTIONS SHORT, 1, 2 OR 3 WORDS.");
Console.WriteLine("-------------------------------------------------------------------");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("PRESS ENTER TO CONTINUE");
Console.ReadKey();
Console.ForegroundColor = ConsoleColor.Green;
#endregion

#region Difficulty

bool isPlayerSure = false;
while (!isPlayerSure)
{
    Console.WriteLine();
    Console.WriteLine("PLEASE CHOOSE YOUR DIFFICULTY:");
    Console.WriteLine("1, 2, 3, 4, 5, 6, 7, 8, 9, or 10?");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("ENTER YOUR CHOICE HERE AND THEN PRESS ENTER: ");
    Console.ForegroundColor = ConsoleColor.Green;
    string? difLevel = Console.ReadLine();

    

    switch (difLevel)
    {
        case "1":
            Console.WriteLine("YOU HAVE CHOSEN DIFFICULTY LEVEL: ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("1");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(", 2, 3, 4, 5, 6, 7, 8, 9, 10.");
            break;

        case "2":
            Console.WriteLine("YOU HAVE CHOSEN DIFFICULTY LEVEL: ");

            Console.Write("1, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(", 3, 4, 5, 6, 7, 8, 9, 10.");
            break;

        case "3":
            Console.WriteLine("YOU HAVE CHOSEN DIFFICULTY LEVEL: ");

            Console.Write("1, 2, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("3");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(", 4, 5, 6, 7, 8, 9, 10.");
            break;

        case "4":
            Console.WriteLine("YOU HAVE CHOSEN DIFFICULTY LEVEL: ");

            Console.Write("1, 2, 3, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("4");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(", 5, 6, 7, 8, 9, 10.");
            break;

        case "5":
            Console.WriteLine("YOU HAVE CHOSEN DIFFICULTY LEVEL: ");

            Console.Write("1, 2, 3, 4, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("5");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(", 6, 7, 8, 9, 10.");
            break;

        case "6":
            Console.WriteLine("YOU HAVE CHOSEN DIFFICULTY LEVEL: ");

            Console.Write("1, 2, 3, 4, 5, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("6");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(", 7, 8, 9, 10.");
            break;

        case "7":
            Console.WriteLine("YOU HAVE CHOSEN DIFFICULTY LEVEL: ");

            Console.Write("1, 2, 3, 4, 5, 6, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("7");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(", 8, 9, 10.");
            break;

        case "8":
            Console.WriteLine("YOU HAVE CHOSEN DIFFICULTY LEVEL: ");

            Console.Write("1, 2, 3, 4, 5, 6, 7, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("8");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(", 9, 10.");
            break;

        case "9":
            Console.WriteLine("YOU HAVE CHOSEN DIFFICULTY LEVEL: ");

            Console.Write("1, 2, 3, 4, 5, 6, 7, 8, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("9");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(", 10.");
            break;

        case "10":
            Console.WriteLine("YOU HAVE CHOSEN DIFFICULTY LEVEL: ");

            Console.Write("1, 2, 3, 4, 5, 6, 7, 8, 9, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("10");
            Console.ForegroundColor = ConsoleColor.Green;
            break;
    }
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("ARE YOU SURE YOU WANT TO CONTINUE ON THIS DIFFICULTY? TYPE Y or N: ");
    Console.ForegroundColor = ConsoleColor.Green;
    string? playerChoice = Console.ReadLine();

    if (playerChoice == "Y")
        {
        isPlayerSure = true;
        }
    else
    {
        isPlayerSure = false;
    }

}

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("NOT THAT IT MATTERS WHAT LEVEL YOU CHOOSE...");
Console.WriteLine("I DON'T HAVE ALL YEAR TO SIT AROUND CREATING MULTIPLE VERSIONS OF THE SAME GAME :D LOL");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("PLEASE PRESS ENTER TO BEGIN.");
Console.ReadKey();
Console.WriteLine();

#endregion

#region playerAnswers LIST
List<string> playerAnswers;
playerAnswers = new List<string>();
#endregion

bool isAlive = true;

while (isAlive)
{
    /*                  --- TO DO ---

    Find way to wrap everything into a loop for alive vs dead and end entire game if dead   /DONE
    Increase cases of recognised player input   /DONE
    Check spelling   /DONE
    Change user input to yellow   /DONE
    Create method for repetitive blocks of code
   
    Create this method with Console.ForegroundColor = colour; inside it
    Tidy up bools (all true as default to simplify)
    Creat classes for front end and back end eg user inputs "..." is back end

    */

    bool isSat = true; //#1
    bool atPuddle = true; //#2
    bool hearSound = true; //#3
    bool inClearing = true; //#4
    bool holdObject = true; //#5
    bool cantRead = true; //#6
    bool needHelp = false; //#7
    bool whichWay = true; //#8
    bool doSomething = true; //#9
    bool canSmell = false; //#10
    bool pullTrigger = false; //final

    #region First Action

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("YOU WAKE UP IN A FOREST.");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(">> ");

    while (isSat)
    {

        string? firstAction = Console.ReadLine();
        playerAnswers.Add(firstAction);
        switch (firstAction)
        {
            //quit
            case "DIE":
            case "EXIT":
            case "QUIT":
                isAlive = false;
                isSat = false;
                atPuddle = false;
                hearSound = false;
                inClearing = false;
                holdObject = false;
                cantRead = false;
                needHelp = true;
                whichWay = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER.");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 1. EMBARASSING.");
                break;

                //die
            case "SCREAM":
            case "SHOUT":
            case "CRY":
            case "SING":
            case "WHISTLE":
            case "TALK":
                isAlive = false;
                isSat = false;
                atPuddle = false;
                hearSound = false;
                inClearing = false;
                holdObject = false;
                cantRead = false;
                needHelp = true;
                whichWay = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("HAVING FUN? YOU " + firstAction + "AND HAVE NOW LET THE GALACTIC FEDERATION KNOW THAT YOU ARE HERE.");
                Console.WriteLine("NEEDLESS TO SAY YOU GET TURNED INTO SWISS CHEESE WITH LASER RIFLES");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER.");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 1. EMBARASSING.");
                break;

                //success
            case "STAND":
            case "STAND UP":
            case "GET UP":
            case "STOP SITTING":
            case "CROUCH":
                isSat = false;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + firstAction + ", TURN AROUND, AND WALK OVER TO A LARGE PUDDLE.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //easter egg
            case "CLIMB A TREE":
            case "LOOK AROUND":
            case "HEAD NORTH":
                //ADD ALL OTHER CASES
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU THINK JUST BECAUSE YOU WATCHED RICK AND MORTY YOU WILL BE SAVED?");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" ....NO, NOT HOW THIS WORKS.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("--- EASTER EGG FOUND, ALL PREVIOUS ATTEMPTS REMOVED ---");
                playerAnswers.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ReadKey();
                Console.WriteLine("YOU ARE SAT DOWN AND ARE STILL IN A FOREST.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //fail
            case "HIDE":
            case "RUN":
            case "WALK":
            case "JOG":
            case "MOVE":
            case "CRAWL":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU ARE SAT DOWN AND YOU ARE STILL IN A FOREST.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            case "INSPECT":
            case "VIEW":
            case "EXPLORE":
            case "OBSERVE":
            case "SEARCH":
                //method to simplify code and repeat same block of codeeach time
                //With a repetition of code of 3 or more create method to carry out
                NewMethod("YOU " + firstAction + ", BUT YOU ARE SURROUNDED BY TREES, AND THEY ALL LOOK THE SAME.");
                break;

            //fail
            case "SIT":
            case "SIT UP":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU ARE ALREADY SITTING.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            default:
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU WAKE UP IN A FOREST.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;
        }

        //BELOW IS WAY TO NOT DO IT, SWITCH IS BETTER AS MANY MORE RESPONSES CAN BE EASILY ADDED
        /*if (firstAction == "STAND" || firstAction == "GET UP" || firstAction == "STAND UP")
        {
            isSat = false;
            Console.WriteLine();
            Console.WriteLine("YOU GET UP AND WALK OVER TO A SHALLOW PUDDLE");
        }
        else
        {
            Console.WriteLine("IT SEEMS YOU COULD NOT " + firstAction );
        }
        */
    }

    #endregion

    #region Second Action

    while (atPuddle)
    {
        string? secondAction = Console.ReadLine();
        playerAnswers.Add(secondAction);
        switch (secondAction)
        {
            //quit
            case "DIE":
            case "EXIT":
            case "QUIT":
                isAlive = false;
                atPuddle = false;
                hearSound = false;
                inClearing = false;
                holdObject = false;
                cantRead = false;
                needHelp = true;
                whichWay = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER.");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 2.");
                break;

            //die
            case "SCREAM":
            case "SHOUT":
            case "CRY":
            case "SING":
            case "WHISTLE":
            case "TALK":
                isAlive = false;
                atPuddle = false;
                hearSound = false;
                inClearing = false;
                holdObject = false;
                cantRead = false;
                needHelp = true;
                whichWay = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; ;
                Console.WriteLine("HAVING FUN? YOU " + secondAction + "AND HAVE NOW LET THE GALACTIC FEDERATION KNOW THAT YOU ARE HERE.");
                Console.WriteLine("NEEDLESS TO SAY YOU GET TURNED INTO SWISS CHESSE WITH LASER RIFLES");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER.");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 1. EMBARASSING.");
                break;

                //easter egg
            case "LOOK AROUND":
            case "HEAD NORTH":
            case "KEEP HEADING NORTH":
            case "CLIMB A TREE":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU THINK JUST BECAUSE YOU WATCHED RICK AND MORTY YOU WILL BE SAVED?");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" ....NO, NOT HOW THIS WORKS.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("--- EASTER EGG FOUND, ALL PREVIOUS ATTEMPTS REMOVED ---");
                playerAnswers.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ReadKey();
                Console.WriteLine("YOU ARE STOOD BY A LARGE PUDDLE.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //success
            case "WASH":
            case "WASH HANDS":
            case "WASH HAND":
            case "DIP":
            case "DIP HAND":
            case "DIP FEET":
            case "DIP TOE":
            case "WASH SHOES":
            case "WASH FEET":
            case "SPLASH":
            case "SPLASH FACE":
            case "SPLASH NECK":
            case "SPLASH HANDS":
            case "PLAY":
            case "TOUCH":
            case "ENTER":
            case "ENTER PUDDLE":
            case "JUMP IN":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + secondAction + " IN THE PUDDLE AND FEEL REFRESHED, YOU NOTICE A SOUND IN THE DISTANCE AHEAD.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                atPuddle = false;
                break;

                //fail
            case "ADMIRE":
            case "LOOK":
            case "LOOK AT":
            case "LOOK AT REFLECTION":
            case "SEE REFLECTION":
            case "SEE":
            case "LOOK INTO":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + secondAction + " BUT IT ONLY MAKES YOU QUESTION WHY YOU ARE HERE.");
                Console.WriteLine("YOU ARE STILL STOOD BY A LARGE PUDDLE.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            case "DRINK":
            case "HAVE A DRINK":
            case "TAKE A DRINK":
            case "SIP":
            case "TAKE SIP":
            case "TAKE A SIP":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + secondAction + " BUT YOU VOMIT IT STRAIGHT BACK UP.");
                Console.WriteLine("YOU ARE STILL STOOD BY A LARGE PUDDLE, NOW COVERED IN SICK.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            default:
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU ARE STOOD BY A LARGE PUDDLE.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;
        }
    }


    #endregion

    #region Third Action

    while (hearSound)
    {
        string? thirdAction = Console.ReadLine();
        playerAnswers.Add(thirdAction);
        switch (thirdAction)
        {
            //quit
            case "DIE":
            case "EXIT":
            case "QUIT":
                isAlive = false;
                hearSound = false;
                inClearing = false;
                holdObject = false;
                cantRead = false;
                needHelp = true;
                whichWay = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER.");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 3.");
                break;

            //die
            case "SCREAM":
            case "SHOUT":
            case "CRY":
            case "SING":
            case "WHISTLE":
            case "TALK":
                isAlive = false;
                hearSound = false;
                inClearing = false;
                holdObject = false;
                cantRead = false;
                needHelp = true;
                whichWay = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("HAVING FUN? YOU " + thirdAction + "AND HAVE NOW LET THE GALACTIC FEDERATION KNOW THAT YOU ARE HERE.");
                Console.WriteLine("NEEDLESS TO SAY YOU GET TURNED INTO SWISS CHESSE WITH LASER RIFLES");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER.");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 3. EMBARASSING.");
                break;

            //easter egg
            case "HEAD NORTH":
            case "KEEP HEADING NORTH":
            case "LOOK AROUND":
            case "CLIMB A TREE":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU THINK JUST BECAUSE YOU WATCHED RICK AND MORTY YOU WILL BE SAVED?");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" ....NO, NOT HOW THIS WORKS.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("--- EASTER EGG FOUND, ALL PREVIOUS ATTEMPTS REMOVED ---");
                playerAnswers.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ReadKey();
                Console.WriteLine("YOU CAN STILL HEAR A SOUND AHEAD.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //success
            case "GO TO SOUND":
            case "GO TO":
            case "GO TO THE SOUND":
            case "GO TOWARD SOUND":
            case "GO TOWARD THE SOUND":
            case "FOLLOW SOUND":
            case "FOLLOW":
            case "FOLLOW THE SOUND":
                hearSound = false;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + thirdAction + " AND THE SOUND GETS LOUDER.");
                Console.WriteLine("IT LEADS YOU TO A SMALL CLEARING IN THE FOREST WITH NO TREES BUT THERE IS BURNT GRASS IN THE MIDDLE.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //fail
            case "CONCENTRATE":
            case "LISTEN":
            case "FOCUS":
            case "SQUINT":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + thirdAction + " BUT YOU CANNOT SEE ANYTHING OR RECOGNISE IT.");
                Console.WriteLine("YOU CAN STILL HEAR THE SOUND.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //fail
            case "WALK":
            case "RUN":
            case "JOG":
            case "MOVE":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + thirdAction + " IN A RANDOM DIRECTION, BUT THE SOUND GETS QUIETER.");
                Console.WriteLine("YOU CAN STILL HEAR THE SOUND.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //fail
            default:
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU CAN HEAR A SOUND AHEAD.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;
        }


    }
    #endregion

    #region Fourth Action

    while (inClearing)
    {
        string? fourthAction = Console.ReadLine();
        playerAnswers.Add(fourthAction);
        switch (fourthAction)
        {
            //quit
            case "DIE":
            case "EXIT":
            case "QUIT":
                isAlive = false;
                inClearing = false;
                holdObject = false;
                cantRead = false;
                needHelp = true;
                whichWay = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 4");
                break;

                //die
            case "DANCE":
            case "SCREAM":
            case "SHOUT":
            case "CRY":
            case "SING":
            case "WHISTLE":
            case "TALK":
                isAlive = false;
                inClearing = false;
                holdObject = false;
                cantRead = false;
                needHelp = true;
                whichWay = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + fourthAction + " AND ARE IMMEDIATELY SHOT TO BITS BY SOLDIERS OF THE GALACTIC FEDERATION.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                // todo create this method with Console.ForegroundColor = colour; inside it
                //SetTextColour(ConsoleColor.Red);
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 4");
                break;

            //easter egg
            case "KEEP HEADING NORTH":
            case "HEAD NORTH":
            case "CLIMB A TREE":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU THINK JUST BECAUSE YOU WATCHED RICK AND MORTY YOU WILL BE SAVED?");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" ....NO, NOT HOW THIS WORKS.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("--- EASTER EGG FOUND, ALL PREVIOUS ATTEMPTS REMOVED ---");
                playerAnswers.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ReadKey();
                Console.WriteLine("YOU ARE IN THE CLEARING.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //success
            case "CROUCH":
            case "KNEEL":
            case "CRAWL":
            case "LOOK":
            case "EXPLORE":
            case "INVESTIGATE":
            case "WALK AROUND":
            case "WALK TO CENTRE":
            case "WALK TO THE CENTRE":
            case "WALK TO MIDDLE":
            case "WALK TO THE MIDDLE":
            case "GO TO MIDDLE":
            case "GO TO THE MIDDLE":
            case "GO TO CENTRE":
            case "GO TO THE CENTRE":
            case "GO CLOSER":
            case "GET CLOSER":
                inClearing = false;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + fourthAction + " AND NOTICE A BRIGHT FLASH OF LIGHT IN ONE OF THE TREES.");
                Console.WriteLine("YOU MOVE TOWARD THE TREE AND SEE A BOX PERCHED ON A BRANCH.");
                Console.WriteLine("YOU CAREFULLY WALK UP TO A TREE AND PULL THE DIRTY METAL BOX FROM THE BRANCH AND INTO YOUR HANDS");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //success + easter egg
            case "LOOK AROUND":
                inClearing = false;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("--- EASTER EGG FOUND, ALL PREVIOUS ATTEMPTS REMOVED ---");
                playerAnswers.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("YOU " + fourthAction + " AND NOTICE A BRIGHT FLASH OF LIGHT IN ONE OF THE TREES.");
                Console.WriteLine("YOU MOVE TOWARD THE TREE AND SEE A BOX PERCHED ON A BRANCH.");
                Console.WriteLine("YOU CAREFULLY WALK UP TO A TREE AND PULL THE DIRTY METAL BOX FROM THE BRANCH AND INTO YOUR HANDS");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //fail
            case "CONCENTRATE":
            case "LISTEN":
            case "SNIFF":
            case "SMELL":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + fourthAction + " BUT YOU CAN ONLY SEE THEM.");
                Console.WriteLine("YOU ARE IN THE CLEARING.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //fail
            case "WALK":
            case "RUN":
            case "MOVE":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + fourthAction + " BUT YOU ARE DRAWN TO THE CLEARING AS IF SOMETHING WANTS YOU TO STAY.");
                Console.WriteLine("YOU ARE IN THE CLEARING.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            case "TOUCH":
            case "FEEL":
            case "TOUCH GRASS":
            case "FEEL GRASS":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + fourthAction + " AND IT SEEMS TO BE POISONOUS, IT LEAVES A PAINFUL SENSATION ON YOUR HAND.");
                Console.WriteLine("YOU ARE STILL IN THE CLEARING, BUT NOW WITH WEIRD STUFF ON YOUR HAND.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            default:
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU ARE IN THE CLEARING.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;
        }


    }
    #endregion

    #region Fifth Action

    while (holdObject)
    {
        string? fifthAction = Console.ReadLine();
        playerAnswers.Add(fifthAction);
        switch (fifthAction)
        {
            //quit
            case "DIE":
            case "EXIT":
            case "QUIT":
                isAlive = false;
                holdObject = false;
                cantRead = false;
                needHelp = true;
                whichWay = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 5");
                break;

                //die
            case "THROW":
            case "THROW BOX":
            case "CHUCK":
            case "CHUCK BOX":
            case "KICK":
            case "KICK BOX":
            case "LAUNCH":
            case "LAUNCH BOX":
            case "SMASH":
            case "SMASH BOX":
            case "SLAP":
            case "SLAP BOX":
            case "SMACK":
            case "SMACK BOX":
            case "BASH":
            case "BASH BOX":
            case "HIT":
            case "HIT BOX":
            case "DROP":
            case "DROP BOX":
            case "SHAKE":
            case "SHAKE BOX":
                isAlive = false;
                holdObject = false;
                cantRead = false;
                needHelp = true;
                whichWay = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + fifthAction + " BUT IT BLEW UP, AND YOU EXPLODED. GREAT JOB!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 5");
                break;

                //success
            case "WIPE":
            case "WASH":
            case "CLEAN":
            case "RUB":
            case "FONDLE":
            case "JUGGLE":
            case "LICK":
            case "STROKE":
            case "SCRUB":
            case "CLEAR":
            case "CLEAR DIRT":
                holdObject = false;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + fifthAction + " THE BOX, AND SEE AN INSCRIPTION IN THE SHINEY METAL SURFACE.");
                Console.WriteLine("AS YOU LOOK CLOSELY YOU START TO NOTICE THE LETTERS: 'M_ _EES_EKS'");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //easter egg
            case "KEEP HEADING NORTH":
            case "HEAD NORTH":
            case "LOOK AROUND":
            case "CLIMB A TREE":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU THINK JUST BECAUSE YOU WATCHED RICK AND MORTY YOU WILL BE SAVED?");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" ....NO, NOT HOW THIS WORKS.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("--- EASTER EGG FOUND, ALL PREVIOUS ATTEMPTS REMOVED ---");
                playerAnswers.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("IN YOUR HANDS YOU HOLD THE DIRTY METAL BOX.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //fail
            case "CONCENTRATE":
            case "LISTEN":
            case "SNIFF":
            case "SMELL":
            case "OPEN":
            case "INSPECT":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU TRY TO " + fifthAction + " BUT IT DOESN'T HELP, YOU CANNOT SEE ANY DETAILS ON THE BOX AND THE BOX APPEARS EMPTY.");
                Console.WriteLine("IN YOUR HANDS YOU HOLD THE DIRTY METAL BOX");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //fail
            case "WALK":
            case "RUN":
            case "MOVE":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU TRY TO " + fifthAction + " BUT YOU ARE MESMERISED BY THE OBJECT.");
                Console.WriteLine("IN YOUR HANDS YOU HOLD THE DIRTY METAL BOX");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //fail
            default:
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("IN YOUR HANDS YOU HOLD THE DIRTY METAL BOX.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;
        }


    }
    #endregion

    #region Sixth Action

    while (cantRead)
    {
        string? sixthAction = Console.ReadLine();
        playerAnswers.Add(sixthAction);
        switch (sixthAction)
        {
            //quit
            case "DIE":
            case "EXIT":
            case "QUIT":
                isAlive = false;
                cantRead = false;
                needHelp = true;
                whichWay = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 6");
                break;

                //success
            case "MR MEESEEKS":
            case "LOOK AT ME":
                cantRead = false;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("YOU SEE THE WORDS ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(sixthAction);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" AND DROP THE BOX, IT LANDS UPSIDE DOWN ONTO THE BUTTON ON ITS TOP AND AS IT HITS THE FLOOR A LARGE CLOUD OF SMOKE APPEARS.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("AS THE SMOKE CLEARS A STRANGE FIGURE EMERGES.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("PLEASE PRESS ENTER TO CONTINUE.");
                Console.ReadKey();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("HE COMES TOWARDS YOU BUT YOU CANNOT MOVE, YOUR FEET HAVE BEEN BOUND BY VINES WHILST YOU WERE MESSING AROUND WITH THE BOX.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("PLEASE PRESS ENTER TO CONTINUE.");
                Console.ReadKey();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("THE GANGLEY BASTARD GETS UP IN YOUR GRILL, AND SHOUTS IN A HOARSE SCREECH ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("'IM MR MEESEEKS LOOK AT ME!'");
                Console.WriteLine("'I CAN'T DIE UNTIL YOUR PROBLEM IS SOLVED, WHAT CAN I DO FOR YOU?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //easter egg
            case "HEAD NORTH":
            case "KEEP HEADING NORTH":
            case "LOOK AROUND":
            case "CLIMB A TREE":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU THINK JUST BECAUSE YOU WATCHED RICK AND MORTY YOU WILL BE SAVED?");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" ....NO, NOT HOW THIS WORKS.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("--- EASTER EGG FOUND, ALL PREVIOUS ATTEMPTS REMOVED ---");
                playerAnswers.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ReadKey();
                Console.WriteLine("YOU CAN STILL HEAR A SOUND AHEAD.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            case "READ":
            case "WHISPER":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU TRY TO " + sixthAction + " BUT YOU DON'T KNOW WHAT IT SAYS YET.");
                Console.WriteLine("YOU LOOK CLOSELY AND START TO NOTICE THE LETTERS: 'M_ _EES_EKS'");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //fail
            case "WALK":
            case "RUN":
            case "MOVE":
            case "CRAWL":
            case "JUMP":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU TRY TO " + sixthAction + " BUT YOU CANNOT MOVE.");
                Console.WriteLine("YOU LOOK CLOSELY AND START TO NOTICE THE LETTERS: 'M_ _EES_EKS'.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //fail
            default:
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU LOOK CLOSELY AND START TO NOTICE THE LETTERS: 'M_ _EES_EKS'.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;
        }


    }
    #endregion

    //unfinsihed possibilites
    #region Seventh Action

    while (!needHelp)
    {
        string? seventhAction = Console.ReadLine();
        playerAnswers.Add(seventhAction);
        switch (seventhAction)
        {
            //quit
            case "DIE":
            case "EXIT":
            case "QUIT":
                isAlive = false;
                needHelp = true;
                whichWay = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 7");
                break;

                //die
            case "THROW":
            case "CHUCK":
            case "KICK":
            case "LAUNCH":
            case "SMASH":
            case "SLAP":
            case "SMACK":
            case "BASH":
            case "HIT":
            case "DROP":
            case "PUNCH":
                isAlive = false;
                needHelp = true;
                whichWay = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + seventhAction + " THE MEESEEKS BUT HE JUMPS BACK, PULLS OUT A LASER RIFLE AND TURNS YOU INTO MUSH.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 7");
                break;

            //easter egg
            case "HEAD NORTH":
            case "KEEP HEADING NORTH":
            case "LOOK AROUND":
            case "CLIMB A TREE":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU THINK JUST BECAUSE YOU WATCHED RICK AND MORTY YOU WILL BE SAVED?");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" ....NO, NOT HOW THIS WORKS.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("--- EASTER EGG FOUND, ALL PREVIOUS ATTEMPTS REMOVED ---");
                playerAnswers.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("'IM MR MEESEEKS LOOK AT ME!'");
                Console.WriteLine("'I CAN'T DIE UNTIL YOUR PROBLEM IS SOLVED, WHAT CAN I DO FOR YOU?");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //success
            case "HELP":
            case "ASSIST":
            case "FREE FEET":
            case "FREE ME":
            case "FREE":
            case "CUT VINES":
            case "BREAK VINES":
            case "VINES":
                needHelp = true;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU SHOUT " + seventhAction + " AND THE MEESEEKS QUICKLY DOES AS YOU ASK.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("NOW WHICH WAY DO WE GO? ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("HE SCREECHES.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //fail
            case "CONCENTRATE":
            case "LISTEN":
            case "SNIFF":
            case "SMELL":
            case "LOOK":
            case "WAIT":
            case "PAUSE":
            case "WATCH":
            case "OBSERVE":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + seventhAction + " AS YOU THOUGHT THE MEESEEKS FARTED.");
                Console.WriteLine("THE MEESEEKS LOOKS AT YOU CONFUSED...");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("'IM MR MEESEEKS LOOK AT ME!'");
                Console.WriteLine("'I CAN'T DIE UNTIL YOUR PROBLEM IS SOLVED, WHAT CAN I DO FOR YOU?");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //fail
            case "WALK":
            case "RUN":
            case "MOVE":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU TRY TO " + seventhAction + " BUT YOU CANNOT MOVE.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("'IM MR MEESEEKS LOOK AT ME!'");
                Console.WriteLine("'I CAN'T DIE UNTIL YOUR PROBLEM IS SOLVED, WHAT CAN I DO FOR YOU?");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //fail
            default:
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("'IM MR MEESEEKS LOOK AT ME!'");
                Console.WriteLine("'I CAN'T DIE UNTIL YOUR PROBLEM IS SOLVED, WHAT CAN I DO FOR YOU?");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;
        }


    }
    #endregion

    //unfinished
    #region Eighth Action

    while (whichWay)
    {
        string? eighthAction = Console.ReadLine();
        playerAnswers.Add(eighthAction);
        switch (eighthAction)
        {
            //quit
            case "DIE":
            case "EXIT":
            case "QUIT":
                isAlive = false;
                whichWay = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 8");
                break;

                //die
            case "THROW":
            case "CHUCK":
            case "KICK":
            case "LAUNCH":
            case "SMASH":
            case "SLAP":
            case "SMACK":
            case "BASH":
            case "HIT":
            case "DROP":
            case "PUNCH":
            case "SCREAM":
            case "SHOUT":
                isAlive = false;
                whichWay = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + eighthAction + " THE MEESEEKS BUT HE JUMPS BACK, PULLS OUT A LASER RIFLE AND TURNS YOU INTO MUSH.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 8");
                break;

            //easter egg
            case "KEEP HEADING NORTH":
            case "LOOK AROUND":
            case "CLIMB A TREE":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU THINK JUST BECAUSE YOU WATCHED RICK AND MORTY YOU WILL BE SAVED?");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" ....NO, NOT HOW THIS WORKS.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("--- EASTER EGG FOUND, ALL PREVIOUS ATTEMPTS REMOVED ---");
                playerAnswers.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("NOW WHICH WAY DO WE GO? ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("HE SCREECHES.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //success
            case "HEAD NORTH":
            case "GO NORTH":
            case "WALK NORTH":
            case "TRAVEL NORTH":
            case "NORTH":
            case "UP NORTH":
                whichWay = false;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU COMMAND " + eighthAction + " IN YOUR BEST SUMMER SMITH IMPRESSION AND THE MEESEEKS STARTS DANCING!.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("WE'RE HEADING NORTH, WE'RE FUCKING... I'M MR MEESEEKS! ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("HE SQUEALS.");
                Console.WriteLine();
                Console.WriteLine("YOU TRAVEL NORTH FOR 30 MINUTES THROUGH THE DENSE FOREST, ALL OF A SUDDEN THE MEESEEKS DROPS TO THE FLOOR AND WHISPERS:");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("SHIT, SHIT, SHIT... SOMETHING'S COMING, SOMETHING BIG... DO SOMETHING!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //fail
            case "CONCENTRATE":
            case "LISTEN":
            case "SNIFF":
            case "SMELL":
            case "LOOK":
            case "WAIT":
            case "PAUSE":
            case "WATCH":
            case "OBSERVE":
            case "STAND":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + eighthAction + " AS YOU THOUGHT THE MEESEEKS FARTED.");
                Console.WriteLine("THE MEESEEKS LOOKS AT YOU CONFUSED...");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("NOW WHICH WAY DO WE GO? ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("HE SCREECHES.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

                //fail
            case "WALK":
            case "RUN":
            case "MOVE":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU START TO " + eighthAction + " BUT THE MEESEEKS STOPS YOU.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("WELL YES OF COURSE LETS " + eighthAction + " BUT WHICH WAY DO WE GO? ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("HE SCREECHES.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            case "HOME":
            case "GO HOME":
            case "LETS GO":
            case "LETS FUCKING GO":
            case "GO":
            case "LFG":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU START TO " + eighthAction + " BUT THE MEESEEKS STOPS YOU.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("WELL YES OF COURSE " + eighthAction + " BUT WHICH WE DON'T KNOW WHICH WAY.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("HE SCREECHES.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            default:
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("NOW WHICH WAY DO WE GO? ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("HE SCREECHES.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;
        }


    }

    #endregion

    //unfinished
    #region Ninth Action

    while (doSomething)
    {
        string? ninthAction = Console.ReadLine();
        playerAnswers.Add(ninthAction);
        switch (ninthAction)
        {
            //quit
            case "DIE":
            case "EXIT":
            case "QUIT":
                isAlive = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 9");
                break;

            //die
            case "THROW":
            case "CHUCK":
            case "KICK":
            case "LAUNCH":
            case "SMASH":
            case "SLAP":
            case "SMACK":
            case "BASH":
            case "HIT":
            case "PUNCH":
            case "SCREAM":
            case "SHOUT":
            case "PULL GUN":
            case "SHOOT":
                isAlive = false;
                doSomething = false;
                canSmell = true;
                pullTrigger = true;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + ninthAction + " THE MEESEEKS BUT HE JUMPS BACK, PULLS OUT A LASER RIFLE AND TURNS YOU INTO MUSH.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 9");
                break;

            //easter egg
            case "HEAD NORTH":
            case "KEEP HEADING NORTH":
            case "LOOK AROUND":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU THINK JUST BECAUSE YOU WATCHED RICK AND MORTY YOU WILL BE SAVED?");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" ....NO, NOT HOW THIS WORKS.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("--- EASTER EGG FOUND, ALL PREVIOUS ATTEMPTS REMOVED ---");
                playerAnswers.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("SOMETHING'S COMING, SOMETHING BIG... DO SOMETHING!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //success
            case "HIDE":
            case "CLIMB":
            case "CLIMB TREE":
            case "CLIMB A TREE":
            case "CURL INTO BALL":
            case "CURL INTO A BALL":
            case "PUT ON DISGUISE":
            case "COVER FACE":
            case "HUG TREE":
            case "CLOSE EYES":
                doSomething = false;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + ninthAction + " AND WATCH AS THE STAMPEDE OF ALIEN SOLDIERS RUNS RIGHT BY YOU.");
                Console.WriteLine("THERE ARE SO MANY OF THEM AND ALL ARE EQUPPED WITH LASER RIFLES.");
                Console.Write("THE MEESEEKS LOOKS UP AT YOU AND WHISPERS: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("DON'T MOVE");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("PRESS ENTER TO CONTINUE");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("THE ARMY MOVE ON THROUGH THE TREES AND THEIR FOOTSTEPS START TO BECOME JUST A DISTANT RUMBLE.");
                Console.WriteLine();
                Console.WriteLine("IT IS NOW SAFE AND YOU AND THE MEESEEKS CONTINUE TO HEAD NORTH THROUGH THE TREES.");
                Console.Write("HE LEAPS AHEAD AND TURNS AROUND WAVING HIS GANGLY ARMS, HE SQUEAKS ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("'I CAN SMELL SOMETHING!'");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            case "CONCENTRATE":
            case "LISTEN":
            case "SNIFF":
            case "SMELL":
            case "LOOK":
            case "WAIT":
            case "PAUSE":
            case "WATCH":
            case "OBSERVE":
            case "PREPARE":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + ninthAction + " AS YOU THOUGHT THE MEESEEKS FARTED.");
                Console.WriteLine("THE MEESEEKS LOOKS AT YOU CONFUSED...");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("SOMETHING'S COMING, SOMETHING BIG... DO SOMETHING!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            case "DROP DOWN":
            case "DROP TO FLOOR":
            case "DROP TO GROUND":
            case "DROP":
            case "LIE DOWN":
            case "LIE":
            case "LAY DOWN":
            case "LAY":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU TRY TO " + ninthAction + " NEXT TO THE MEESEEKS.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("NOT HERE, IT'S TOO OBVIOUS, ");
                Console.WriteLine("SOMETHING'S COMING, SOMETHING BIG... DO SOMETHING!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            case "WALK":
            case "RUN":
            case "MOVE":
            case "JUMP":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU START TO " + ninthAction + " BUT THE MEESEEKS STOPS YOU.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("SOMETHING'S COMING, SOMETHING BIG... DO SOMETHING!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            default:
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("SOMETHING'S COMING, SOMETHING BIG... DO SOMETHING!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;
        }


    }


    #endregion

    //unfinished
    #region Tenth Action 

    while (!canSmell)
    {
        string? tenthAction = Console.ReadLine();
        playerAnswers.Add(tenthAction);
        switch (tenthAction)
        {
            //quit
            case "DIE":
            case "EXIT":
            case "QUIT":
                isAlive = false;
                canSmell = true;
                pullTrigger = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 10");
                break;
            //die
            case "THROW":
            case "CHUCK":
            case "KICK":
            case "LAUNCH":
            case "SMASH":
            case "SLAP":
            case "SMACK":
            case "BASH":
            case "HIT":
            case "PUNCH":
                isAlive = false;
                canSmell = true;
                pullTrigger = true;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + tenthAction + " THE MEESEEKS BUT HE JUMPS BACK, PULLS OUT A GIANT HAMMER AND FLATTENS YOU.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON LEVEL 10");
                break;

            //easter egg
            case "HEAD NORTH":
            case "KEEP HEADING NORTH":
            case "LOOK AROUND":
            case "CLIMB A TREE":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU THINK JUST BECAUSE YOU WATCHED RICK AND MORTY YOU WILL BE SAVED?");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" ....NO, NOT HOW THIS WORKS.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("--- EASTER EGG FOUND, ALL PREVIOUS ATTEMPTS REMOVED ---");
                playerAnswers.Clear();
                Console.WriteLine();
                Console.WriteLine("HE LEAPS AHEAD AND TURNS AROUND WAVING HIS GANGLY ARMS.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("I CAN SMELL SOMETHING");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //success
            case "SMELL":
            case "SNIFF":
            case "BREATHE IN":
            case "BREATHE":
            case "SNORT":
            case "TAKE A WHIFF":
            case "SMELL AIR":
            case "SNIFF AIR":
            case "OBSERVE":
                canSmell = true;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + tenthAction + " AND FIND THAT THE SCENT SEEMS FAMILIAR.");
                Console.WriteLine("IT SEEMS TO BE COMING FROM JUST BEYOND THE TREES IN THE WEST.");
                Console.Write("THE MEESEEKS GRABS YOU BY THE HAND ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("'LETS GO!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("PRESS ENTER TO CONTINUE");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("IT'S A SHORT WALK AND AS YOU BREAK THE TREE LINE YOU IMMEDIATELY SEE IT, IT'S IMPRESSIVE AND SOMEHOW LOOKS FAMILIAR.");
                Console.WriteLine();
                Console.WriteLine("IT'S A WRECKAGE OF A SPACE CRAFT, ROUND, FILTHY, A ROUND CANOPY ON THE TOP AND FILLED WITH BOTTLES.");
                Console.WriteLine();
                Console.WriteLine("YOU LOOK AROUND TO SEE IF THERE ARE SURVIVORS...");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("'I FOUND THIS!' ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SHOUTED THE MEESEEKS FROM THE OTHER SIDE OF THE DOWNED CRAFT.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("'IT LOOKS LIKE A STRANGE GUN, OR A LABELLER' ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("EXCITED YOU RUN OVER TO HIM, HE HANDS YOU THE OBJECT");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            case "LISTEN":
            case "LOOK":
            case "WAIT":
            case "PAUSE":
            case "WATCH":
            case "STAND":
            case "DROP DOWN":
            case "DROP TO FLOOR":
            case "DROP TO GROUND":
            case "DROP":
            case "LIE DOWN":
            case "LIE":
            case "LAY DOWN":
            case "LAY":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU TRY TO " + tenthAction + " NEXT TO THE MEESEEKS.");
                Console.WriteLine();
                Console.WriteLine("HE LEAPS AHEAD AND TURNS AROUND WAVING HIS GANGLY ARMS.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("I CAN SMELL SOMETHING");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            case "WALK":
            case "RUN":
            case "MOVE":
            case "JUMP":
            case "JOG":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU START TO " + tenthAction + " BUT THE MEESEEKS SLAPS YOU TO THE GROUND.");
                Console.WriteLine();
                Console.WriteLine("HE LEAPS AHEAD AND TURNS AROUND WAVING HIS GANGLY ARMS.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("I CAN SMELL SOMETHING");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            default:
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("HE LEAPS AHEAD AND TURNS AROUND WAVING HIS GANGLY ARMS.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("I CAN SMELL SOMETHING");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;
        }


    }



    #endregion

    //unfinished
    #region Final Action

    while (!pullTrigger)
    {
        string? finalAction = Console.ReadLine();
        playerAnswers.Add(finalAction);
        switch (finalAction)
        {
            //quit
            case "DIE":
            case "EXIT":
                pullTrigger = true;
                isAlive = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON THE FINAL LEVEL");
                break;

            //die
            case "THROW":
            case "CHUCK":
            case "KICK":
            case "LAUNCH":
            case "SMASH":
            case "SLAP":
            case "SMACK":
            case "BASH":
            case "HIT":
            case "PUNCH":
                pullTrigger = true;
                isAlive = false;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + finalAction + " THE MEESEEKS BUT HE JUMPS BACK, PULLS OUT A GIANT HAMMER AND FLATTENS YOU.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU DIED ON THE FINAL LEVEL, YEESH THAT SUCKS.");
                break;

            //success GAME COMPLETE
            case "PULL TRIGGER":
            case "PRESS TRIGGER":
            case "AIM":
            case "SHOOT":
            case "FIRE":
            case "PRESS":
            case "TAKE AIM":
                isAlive = false;
                pullTrigger = true;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU " + finalAction + "... THE GUN VIBRATES, AND QUICKLY SHOOTS OUT GREEN PLASMA STRAIGHT AHEAD.");
                Console.WriteLine("THEN AN OVAL HOLE RIGHT IN FRONT OF YOU OPENS UP.");
                Console.WriteLine();
                Console.Write("THE MEESEEKS GRABS YOUR SHOULDERS SMILING SUSPICIOUSLY.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("'IM DONE HERE!'");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("HE SCREECHES, AND QUICKLY IMPLODES LEAVING ONLY A SMALL BLUE CLOUD.");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("PRESS ENTER TO CONTINUE");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU LOOK INTO THE OVAL, IT LOOKS LIKE A ROOM IS ON THE OTHER SIDE. IT'S LIKE A PORTAL INTO ANOTHER DIMENSION.");
                Console.WriteLine();
                Console.WriteLine("THE ROOM THAT APPEARS INSIDE THE OVAL LOOKS LIKE A WEIRD SCI-FI GARAGE, BUT VERY FAMILIAR.");
                Console.WriteLine("WITH BIZARRE LOOKING ALIEN ITEMS, A MICROWAVE, GUNS... AND TEST TUBES...");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("PRESS ENTER TO CONTINUE");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("MORE CONCERNED ABOUT STAYING IN THE FOREST ALONE YOU STEP INTO THE STRANGE OVAL AND ONTO THE CONCRETE FLOOR OF THE GARAGE.");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("PRESS ENTER TO CONTINUE");
                Console.ReadKey();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------- CONGRATULATIONS! YOU HAVE COMPLETED THE GAME -------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("A SCORE OF UNDER 16 IS 'WUBALUBA DUB DUB!'");
                Console.WriteLine("A SCORE OF 16 TO 30 IS 'AH JEEZ RICK'");
                Console.WriteLine("AND A SCORE OF 30 OR MORE IS 'SHUT IT MORTY, YOU WORTHLESS PEICE OF SHIT, BUUURP'");
                Console.WriteLine();
                break;

            //fail
            case "DROP DOWN":
            case "DROP TO FLOOR":
            case "DROP TO GROUND":
            case "DROP":
            case "LIE DOWN":
            case "LIE":
            case "LAY DOWN":
            case "LAY":
            case "LISTEN":
            case "LOOK":
            case "WAIT":
            case "PAUSE":
            case "WATCH":
            case "STAND":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU TRY TO " + finalAction);
                Console.WriteLine();
                Console.WriteLine("THE MEESEEKS TAKES OUT A PIPE, HIS FACIAL HAIR HAS STARTED TO GROW LONG FROM BOREDOM");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("'IT LOOKS LIKE A STRANGE GUN, OR A LABELLER' ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("EXCITED YOU RUN OVER TO HIM, HE HANDS YOU THE OBJECT");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            case "WALK":
            case "RUN":
            case "MOVE":
            case "JUMP":
            case "JOG":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU START TO " + finalAction + " BUT THE MEESEEKS GRABS THE OBJECT AND TRIES TO TAKE IT FROM YOU.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("'IT LOOKS LIKE A STRANGE GUN, OR A LABELLER' ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("EXCITED YOU RUN OVER TO HIM, HE HANDS YOU THE OBJECT");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;

            //fail
            default:
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("'IT LOOKS LIKE A STRANGE GUN, OR A LABELLER' ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("EXCITED YOU RUN OVER TO HIM, HE HANDS YOU THE OBJECT");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">> ");
                break;
        }


    }

    #endregion

} //this } is end to the 'isAlive' bool

    #region Ending

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("------------ THE END ------------");



Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("PLEASE PRESS ENTER TO CONTINUE.");
Console.ReadKey();
Console.WriteLine();
Console.Write("YOU SCORED A TOTAL OF:  ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(playerAnswers.Count);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("AND YOUR ANSWERS WERE:");
Console.ForegroundColor = ConsoleColor.Cyan;
for (int i = 0; i < playerAnswers.Count; i++)
{
    Console.WriteLine(playerAnswers[i]);
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("-----------------------------------");
Console.WriteLine();
Console.Write("Pointless Game Design By ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Dan Severs");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("-----------------------------------");

static void NewMethod(string? text)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(text);
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(">> ");
}

#endregion