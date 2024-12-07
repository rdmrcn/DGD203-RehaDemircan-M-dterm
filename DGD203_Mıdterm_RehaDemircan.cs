using System;

class DGD203MidtermGame
{
    static void Main()
    {
        // Set console background and text color for cave/fire ambiance
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        // 1. Ask for the player's name
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();
        Console.WriteLine($"Welcome, {playerName}! Ready for some adventure? Let's begin!");

        // 2. First question (introduce a plot twist)
        string choice1 = AskQuestion("You're stranded on a deserted island. What will you use to survive?", new string[] { "a) A knife", "b) A fire starter" });

        // 3. Second question (introduce more scenario)
        string choice2 = AskQuestion("You find a mysterious door on the island. What do you do?", new string[] { "a) Open it and explore", "b) Leave it alone and build shelter" });

        // 4. Third question (change scenario depending on previous answers)
        string choice3 = (choice1 == "a")
            ? AskQuestion("You're in need of food. Do you hunt animals or try to forage for plants?", new string[] { "a) Hunt", "b) Forage" })
            : AskQuestion("You need shelter. Do you use leaves or branches to build it?", new string[] { "a) Leaves", "b) Branches" });

        // 5. Fourth question (add a time constraint)
        string choice4 = AskQuestion("A storm is coming! You only have time to do one thing. What do you do?", new string[] { "a) Reinforce shelter", "b) Look for shelter in a cave" });

        // 6. Bear encounter scenario with only option a, b, and c for the bear attack question
        string choice5 = AskBearEncounter();

        // Outcome for attacking unprepared (Option c)
        if (choice5 == "c")
        {
            Console.WriteLine("You chose to attack the bear, but you were completely unprepared. In a foolish act of bravery, you charged at the beast without any weapon or strategy.");
            Console.WriteLine("The bear swiftly overpowered you, and your adventure ends here.");
            Console.WriteLine("You acted too hastily and foolishly, your bravery was no match for the bear's strength.");
            Console.WriteLine("\nGame over. Press any key to exit.");
            Console.ReadKey();
            return;
        }

        string choice6 = "none";
        if (choice5 == "b")
        {
            choice6 = AskQuestion("You chose to retrieve the situation. Now do you:", new string[] { "a) Make a trap", "b) Stay away from the bear" });
        }

        // 7. Expanded Conclusion of story based on answers
        Console.WriteLine("\nHere's how your story unfolded...");

        // Define the character's final journey and personality based on choices
        if (choice1 == "a" && choice2 == "a" && choice3 == "a" && choice4 == "a" && choice5 == "a")
        {
            Console.WriteLine($"{playerName}, you were daring and fearless. You confronted the bear head-on, ready for battle, but unfortunately, your courage wasn't enough. The bear overpowered you, and you met your end fighting for survival.");
            Console.WriteLine("You may have fallen, but your bravery will be remembered as the legend of the island.");
        }
        else if (choice1 == "b" && choice2 == "b" && choice3 == "b" && choice4 == "b" && choice5 == "b")
        {
            Console.WriteLine($"{playerName}, your caution and strategic thinking guided you through the toughest challenges. You avoided direct confrontation with the bear and outsmarted it. You built a shelter, found food, and survived the storm.");
            Console.WriteLine("You proved that intelligence and patience can overcome even the wildest of obstacles.");
        }
        else if (choice5 == "b" && choice6 == "a")
        {
            // Expanded Lore and Ending
            Console.WriteLine($"{playerName}, you showed great resourcefulness in the face of danger. After deciding not to fight the bear, you cleverly set a trap, capturing and killing the beast.");
            Console.WriteLine("Your journey continues, and the island is no longer a threat, thanks to your quick thinking.");

            // Expanded lore and explanation
            Console.WriteLine("\nThe island has a long history of survivors, each one facing the same test. Many before you came here with grand ideas of overcoming the wilderness with sheer force or wit. Some succeeded; most did not.");
            Console.WriteLine("The island, unlike any other place, seems to have a strange effect on those who live here. It was once home to a group of explorers, but all records of them were lost after a storm. Now, only the remnants of their tools and shelters remain.");
            Console.WriteLine("As you sit by the fire after your victory over the bear, you realize that survival on the island isn’t just about strength. It’s about understanding the land, learning to adapt to its harsh realities, and respecting the forces that govern it.");
            Console.WriteLine("The sun begins to set, casting long shadows across the jungle. You’ve made it through another day, but you know that tomorrow will bring new challenges. But you are ready.");
            Console.WriteLine("\nThe island is not the enemy. The real enemy is the fear that you can’t survive. But now you’ve learned that fear can be conquered, one step at a time.");

            // End story message
            Console.WriteLine("\nYou’ve survived the trial. Congratulations, but your journey is far from over.");
            Console.WriteLine("The island will test you again, but you have proven yourself capable. The legend of your survival will be whispered through the jungle.");
        }
        else if (choice5 == "a" && choice2 == "a")
        {
            // Meeting the KABILE Tribe Ending
            Console.WriteLine($"{playerName}, after escaping the storm and overcoming the bear, you encounter a group of locals. They belong to a tribe called the KABILE, known for their ancient traditions and deep connection with the land.");
            Console.WriteLine("The KABILE tribe, recognizing your survival skills and bravery, welcomes you into their fold. You spend several nights with them, learning about their rituals, their ways of living in harmony with nature, and their survival skills passed down through generations.");
            Console.WriteLine("During your time with the KABILE, you share your tale of survival and the bear you conquered. The tribe listens intently, their eyes wide with awe. You realize that your actions have become a part of their stories now. They call you 'The Bear Slayer' and hold you in high regard.");

            Console.WriteLine("\nOne night, as you sit around the fire with the KABILE, you hear the sound of an approaching helicopter. It's a rescue team, sent after an emergency signal was sent from the island.");
            Console.WriteLine("The KABILE people bid you farewell, telling you that you have become a part of their legacy. You leave the island, but the stories of your survival, and your legendary battle with the bear, will live on forever in the tribe’s oral history.");
            Console.WriteLine("As you fly away in the helicopter, you look down at the island one last time. Your adventure is over, but the legend of your survival has just begun.");

            // KABILE Legend Conclusion
            Console.WriteLine("\nThe rescue team finds you safe, but the KABILE people’s respect for you remains. The islanders now know you as 'The Bear Slayer,' the one who survived against all odds and became a legend in their culture.");
            Console.WriteLine("Your tale will be told for generations, passed down from one KABILE elder to the next. In the years to come, survivors on the island will hear your name and remember your bravery, your intelligence, and the lessons you imparted on them.");
            Console.WriteLine("\nYour story has become more than survival; it has become part of something much larger — a timeless legend. Congratulations, you have not only survived the island but left a lasting mark on its people and their future.");
        }
        else
        {
            Console.WriteLine($"{playerName}, your path was one of balance. You took risks, but also made careful decisions. You encountered challenges but learned from them, forging your way through the island.");
            Console.WriteLine("Though you faced danger, your ability to adapt and learn from each moment carried you forward.");
        }

        // Display the author information
        Console.WriteLine("\nGame developed by: Reha Demircan");

        // Final congratulation message
        Console.WriteLine("\nCongratulations on completing the game! Your choices reflect your unique approach to survival, courage, and wisdom!");

        // Reset console color to default at the end
        Console.ResetColor();
    }

    // Method to handle questions and choices with randomization and logic
    static string AskQuestion(string question, string[] choices)
    {
        Console.WriteLine(question);
        foreach (var choice in choices)
        {
            Console.WriteLine(choice);
        }

        string playerChoice;
        do
        {
            Console.Write("Enter your choice (a/b): ");
            playerChoice = Console.ReadLine().ToLower();
        } while (playerChoice != "a" && playerChoice != "b");

        return playerChoice;
    }

    // Special method for the bear encounter with an option c
    static string AskBearEncounter()
    {
        Console.WriteLine("You enter a cave for shelter but encounter a bear. Do you:");
        Console.WriteLine("a) Attack the bear");
        Console.WriteLine("b) Try to retrieve without fighting");
        Console.WriteLine("c) Attack unprepared");

        string playerChoice;
        do
        {
            Console.Write("Enter your choice (a/b/c): ");
            playerChoice = Console.ReadLine().ToLower();
        } while (playerChoice != "a" && playerChoice != "b" && playerChoice != "c");

        return playerChoice;
    }
}
