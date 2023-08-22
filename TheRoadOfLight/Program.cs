internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to \"The Road of Light\"");        
        string playDecision;
        string lightDecision;
        string yesOrNo;
        string saveFriend;
        do
        {
            Console.WriteLine("\nWould you like to play or exit?\n");
            playDecision = Console.ReadLine();
            playDecision = playDecision.ToUpper();
            if (playDecision == "EXIT")
            {
                Exit();
                break;
            }
            else if (playDecision == "PLAY")
            {
                Console.WriteLine("\nAwesome! Lets get going!\n");
                Console.WriteLine("Whats your name?\n");
                string userName = Console.ReadLine();             
                do
                {
                    Console.Clear();
                    Console.WriteLine(StoryStarts(userName));
                    lightDecision = Console.ReadLine();
                    lightDecision = lightDecision.ToUpper();
                    if (lightDecision == "GO BACK HOME")
                    {
                        Exit();
                        break;
                    }
                    else if (lightDecision == "GO TO THE LIGHT")
                    {
                        Console.Clear();
                        Console.WriteLine("You start to walk toward the light.");
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(WalkToLight());
                            yesOrNo = Console.ReadLine();
                            yesOrNo = yesOrNo.ToUpper();
                            if (yesOrNo == "NO")
                            {
                                Exit();
                                break;
                            }
                            else if (yesOrNo == "YES")
                            {
                                Console.Clear();
                                Console.WriteLine("Bold choice. You are given a sword that seals the light.");
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine(JourneyWithSword());
                                    saveFriend = Console.ReadLine();
                                    saveFriend = saveFriend.ToUpper();
                                    if (saveFriend == "SAVE THE WORLD")
                                    {
                                        WorldSaved();
                                        break;
                                    }
                                    else if (saveFriend == "SAVE YOUR FRIEND")
                                    {
                                        FriendSaved();
                                        break;
                                    }
                                }
                                while (saveFriend != "SAVE THE WORLD" || saveFriend != "SAVE YOUR FRIEND");
                                break;
                            }
                        }
                        while (yesOrNo != "NO" || yesOrNo != "YES");
                        break;
                    }
                }
                while (lightDecision != "GO BACK HOME" || lightDecision != "GO TO THE LIGHT");
                break;
            }
        }
        while (playDecision != "EXIT" || playDecision != "PLAY");

        Console.ReadLine();
    }

    static void Exit()
    {
        Console.WriteLine("\nSee you later!");
    }

    static string StoryStarts(string name)
    {
        return $"It was a dark and weary night and {name} was walking through the rainy woods. All of a sudden, {name} sees a bright light in the distance. Does {name} go to the light or go back home?\n\nSelect \"go to the light\" or \"go back home\"\n";
    }

    static string WalkToLight()
    {
        return "As you approach the light, a crow appears and says the following \"You're entering dangerous waters. The path ahead is not for the weak.\" Do you still want to continue?\n\nSelect yes or no\n";
    }

    static string JourneyWithSword()
    {
        return "Along the path, you fight various monsters. One eyed golems, 30 foot giants, goblins with cheetah like speeds.\n\nAfter almost dying, you made it to the light source. At the center of it, your life long bestfriend.\n\nHe's been consumed with this light and to save him you must pierce his chest with the sword that seals the light. Doing this will illuminate the world but destroy every human being on it.\n\nIn order to save the world you must throw the sword that seals the light into the light itself destroying your bestfriend and keeping the world in darkness but, saving all of humanity. What will you do?\n\nSelect \"save your friend\" or \"save the world\"\n";
    }

    static void WorldSaved()
    {
        Console.Clear();
        Console.WriteLine("You have saved the world! Your friend died a noble death and will now pass to the eternal afterlife where he no longer will need to suffer. The world continues in darkness but with humanity in tact. The sword that seals the light, has vanished. Forever?");
        Console.WriteLine("\nThe End.");
    }

    static void FriendSaved()
    {
        Console.Clear();
        Console.WriteLine("With the sword that seals the darkness, you peirce your friends chest and in agony he yells. As the sword pierces deeper and deeeper, you start to feel the ground below you get lighter.\n\nIn that instant, you have a vision. In the vision, you see millions and millions perish at the very hand of the bright light.\n\nEveryone on Earth has passed, but now darkness no longer exists. You and your bestfriend walk away healed of all damage but, where will you go?");
        Console.WriteLine("\nThe End.");
    }
}