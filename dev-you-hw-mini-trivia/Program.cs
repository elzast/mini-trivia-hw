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
            bool keepGoing = true;
            int score = 0;
            string userAnswer;
            while (keepGoing)
            {
                Console.WriteLine("Welcome to mini-trivia! Choose a trivia category: 1) Pop culture, 2) Tech, 3) History or 4) to exit");
                //string userAnswer;
                int triviaChoice = int.Parse(Console.ReadLine());

                switch (triviaChoice)
                {
                    case 1:
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
                    case 2:
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
                    case 3:
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
                    case 4:
                        Console.WriteLine("Goodbye!");
                        keepGoing = false;
                        break;



                }
                 
                if (triviaChoice <= 0 || triviaChoice >= 5) {
                    Console.WriteLine("Select a valid number");
                }

                string keepPlaying;

                Console.WriteLine("Would you like to continue? Y or N?");
                    keepPlaying = Console.ReadLine().ToLower();
                if (keepPlaying == "y") { keepGoing = true; }
                if (keepPlaying == "n") {
                    Console.WriteLine($"Thank you for playing! Your final score is {score}");
                    Console.WriteLine("Press ENTER to exit");
                    Console.ReadLine();
                    keepGoing = false;
                }






            }
          


        }


    }
    }

        
