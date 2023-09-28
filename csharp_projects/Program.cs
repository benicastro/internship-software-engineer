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
//             total the objects in a variable named dice */
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


