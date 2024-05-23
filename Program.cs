using System;
using System.Collections.Generic;

namespace QuizGame
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine($"\tWelcome to MyGameProject\n");
            Console.WriteLine($"Enter your Name to register!:");
            var GameName = Console.ReadLine();
            Console.WriteLine($"Welcome {GameName}! start playing!\n");

            

            // Create a list of questions
            List<Question> questions = new List<Question>
            {
                new Question("What is the capital of France?", new string[] { "Paris", "London", "Berlin", "Madrid" }, 0),
                new Question("What is 2 + 2?", new string[] { "3", "4", "5", "6" }, 1),
                new Question("Who wrote 'Hamlet'?", new string[] { "Charles Dickens", "Jane Austen", "William Shakespeare", "Mark Twain" }, 2)
            };

            int score = 0;

            // Loop through each question
            foreach (var question in questions)
            {
                Console.WriteLine(question.Text);
                for (int i = 0; i < question.Choices.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Choices[i]}");
                }

                Console.Write("Enter your answer (1-4): ");
                int answer;
                bool isValidInput = int.TryParse(Console.ReadLine(), out answer);
                answer--; // to make it zero-based

                // Check if the answer is correct
                if (isValidInput && answer == question.CorrectAnswerIndex)
                {
                    Console.WriteLine("Correct!");
                    score += 10; // or any other score increment logic
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine();
            }

            // Display the final score
            Console.WriteLine($"Game Over! {GameName}Your final score is: {score}");
        }
    }
}
