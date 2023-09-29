////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/* Dice Roller Game
by Benedict Z. Castro || benedict.zcastro@gmail.com */

// using System;

// namespace DiceRoller
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             /* Create new instance of System.Random class and store a reference
//             to the objects in a variable named dice */
//             Random dice = new Random();

//             // Simulate three dice rolls
//             int roll1 = dice.Next(1, 7);
//             int roll2 = dice.Next(1, 7);
//             int roll3 = dice.Next(1, 7);

//             // Get total
//             int total = roll1 + roll2 + roll3;
//             Console.WriteLine($"Dice rolls: {roll1} + {roll2} + {roll3} = {total}");

//             // If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
//             if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
//             {
//                 // If all three dice you roll result in the same value, you get six bonus points for rolling triples.
//                 if ((roll1 == roll2) && (roll2 == roll3))
//                 {
//                     Console.WriteLine("You rolled triples! +6 bonus to total!");
//                     total += 6;
//                 }
//                 else
//                 {
//                     Console.WriteLine("You rolled doubles! +2 bonus to total");
//                     total += 2;
//                 }
//             }

//             // Console.WriteLine((total >= 15) ? "You win!" : "Sorry, you lose.");
//             if (total >= 16)
//             {
//                 Console.WriteLine("You win a new car!");
//             }
//             else if (total >= 10)
//             {
//                 Console.WriteLine("You win a new laptop!");
//             }
//             else if (total == 7)
//             {
//                 Console.WriteLine("You win a trip for two!");
//             }
//             else
//             {
//                 Console.WriteLine("You win a kitten!");
//             }


//         }
//     }
// }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* Renewal Rate of Subscriptions Challenge
by Benedict Z. Castro | benedict.zcastro@gmail.com */

// using System;

// namespace SubscriptionRate
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             /* Create new instance of System.Random class and store a reference
//             to the objects in a variable named random */

//             Random random = new Random();
//             int daysUntilExpiration = random.Next(12);
//             int discountPercentage = 0;


//             if (daysUntilExpiration == 0)
//             {
//                 Console.WriteLine("Your subscription has expired");
//             }
//             else if (daysUntilExpiration == 1)
//             {
//                 Console.WriteLine("Your subscription expires within a day!");
//                 discountPercentage = 20;
//             }
//             else if (daysUntilExpiration <= 5)
//             {
//                 Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//                 discountPercentage = 10;
//             }
//             else if (daysUntilExpiration <= 10)
//             {
//                 Console.WriteLine("Your subscription will expire soon. Renew now!");
//             }
//             else {}

//             if (discountPercentage > 0)
//             {
//                 Console.WriteLine($"Renew now and save {discountPercentage}%.");
//             }
//         }
//     }
// }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* Student Grading App
by Benedict Z. Castro | benedict.zcastro@gmail.com */

/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/

using System;

namespace StudentGradingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the header row of output
            Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

            // Initialize the number of exam assignments
            int examAssignments = 5;

            // Initialize the name of students
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            // Initialize the student scores
            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

            int[] studentScores = new int[10];

            string currentStudentLetterGrade = "";

            /*
            The outer foreach loop is used to:
            - iterate through student names 
            - assign a student's grades to the studentScores array
            - calculate exam and extra credit sums (inner foreach loop)
            - calculate numeric and letter grade
            - write the score report information
            */
            foreach (string name in studentNames)
            {
                string currentStudent = name;

                if (currentStudent == "Sophia")
                    studentScores = sophiaScores;

                else if (currentStudent == "Andrew")
                    studentScores = andrewScores;

                else if (currentStudent == "Emma")
                    studentScores = emmaScores;

                else if (currentStudent == "Logan")
                    studentScores = loganScores;

                int gradedAssignments = 0;
                int gradedExtraCreditAssignments = 0;

                int sumExamScores = 0;
                int sumExtraCreditScores = 0;

                decimal currentStudentGrade = 0;
                decimal currentStudentExamScore = 0;
                decimal currentStudentExtraCreditScore = 0;

                /* 
                the inner foreach loop: 
                - sums the exam and extra credit scores
                - counts the extra credit assignments
                */
                foreach (int score in studentScores)
                {
                    gradedAssignments += 1;

                    if (gradedAssignments <= examAssignments)
                    {
                        sumExamScores = sumExamScores + score;
                    }

                    else
                    {
                        gradedExtraCreditAssignments += 1;
                        sumExtraCreditScores += score;
                    }
                }

                currentStudentExamScore = (decimal)(sumExamScores) / examAssignments;
                currentStudentExtraCreditScore = (decimal)(sumExtraCreditScores) / gradedExtraCreditAssignments;

                currentStudentGrade = (decimal)((decimal)sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;

                if (currentStudentGrade >= 97)
                    currentStudentLetterGrade = "A+";

                else if (currentStudentGrade >= 93)
                    currentStudentLetterGrade = "A";

                else if (currentStudentGrade >= 90)
                    currentStudentLetterGrade = "A-";

                else if (currentStudentGrade >= 87)
                    currentStudentLetterGrade = "B+";

                else if (currentStudentGrade >= 83)
                    currentStudentLetterGrade = "B";

                else if (currentStudentGrade >= 80)
                    currentStudentLetterGrade = "B-";

                else if (currentStudentGrade >= 77)
                    currentStudentLetterGrade = "C+";

                else if (currentStudentGrade >= 73)
                    currentStudentLetterGrade = "C";

                else if (currentStudentGrade >= 70)
                    currentStudentLetterGrade = "C-";

                else if (currentStudentGrade >= 67)
                    currentStudentLetterGrade = "D+";

                else if (currentStudentGrade >= 63)
                    currentStudentLetterGrade = "D";

                else if (currentStudentGrade >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";


                // Student         Exam Score      Overall Grade   Extra Credit
                // Sophia          92.2            95.88   A       92 (3.68 pts)

                Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / examAssignments)} pts)");
            }
        }
    }
}