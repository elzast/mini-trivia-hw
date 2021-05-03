using System;

namespace dev_you_hw_mini_trivia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mini Trivia
            //The following application will give the user 3 different trivia categories and ask them a question based on the chosen category.

            //Prompt the user to choose between 3 trivia categories of your choice(sports, science, pop culture, etc.)
            //Based on the user’s choice give the user a question that falls in the chosen category
            //Let the user know if their answer is correct or incorrect


           
                Console.WriteLine("Welcome to mini-trivia! Choose a trivia category: Pop culture, Tech, History or select exit to Quit");

                string userAnswer;
                string triviaChoice = Console.ReadLine().ToLower();
                int score = 0;


                switch (triviaChoice)
                {
                    case "pop culture":
                        Console.WriteLine("Who is the orginal DC character that DeadPool was inspired by?");
                        userAnswer = Console.ReadLine().ToLower();
                        if (userAnswer == "deathstroke")
                        {
                            Console.WriteLine("That's correct!");
                            score++;
                            Console.WriteLine("Your score: " + score);

                        }
                        else
                        {
                            Console.WriteLine("Try again");
                        score--;
                        Console.WriteLine("Your score: " + score);
                        }
                        break;
                    case "tech":
                        Console.WriteLine("What car was nicknamed the 'Batmobile'?");
                        userAnswer = Console.ReadLine().ToLower();
                        if (userAnswer == "lincoln futura")
                        {
                            Console.WriteLine("That's correct!");
                            score++;
                            Console.WriteLine("Your score: " + score);
                        }
                        else
                        {
                            Console.WriteLine("Try again");
                        score--;
                        Console.WriteLine("Your score: " + score);
                    }

                        break;
                    case "history":
                        Console.WriteLine("In 1816, which US state was admitted to the Union as the 20th state?");
                        userAnswer = Console.ReadLine().ToLower();

                        if (userAnswer == "mississippi")
                        {
                            Console.WriteLine("That's correct!");
                             score++;
                            Console.WriteLine("Your score: " + score);
                        }
                        else
                        {
                            Console.WriteLine("Try again");
                        score--;
                        Console.WriteLine("Your score: " + score);
                    }
                        break;
                    case "exit":


                        Console.WriteLine("Thanks for playing!");

                        break;
                    default:
                        Console.WriteLine("Select a valid category");
                        break;

                }
            
            
                Console.WriteLine("Press ENTER to Exit");
                Console.ReadLine();
            
        }

        }
    }

        
