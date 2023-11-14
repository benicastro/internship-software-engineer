// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0]}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0]}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);
// if (pallets[0] != null)
//     Console.WriteLine($"After: {pallets[0].ToLower()}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Can you remove null elements from an array?
// If the Array.Resize() method doesn't remove empty elements from an array, 
// is there another helper method that will do the job automatically? No. 
// The best way to empty elements from an array would be to count the number of 
// non-null elements by iterating through each item and increment a variable (a counter). 
// Next, you would create a second array that is the size of the counter variable. 
// Finally, you would loop through each element in the original array and copy non-null values into the new array.

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] pangramArray = pangram.Split(" ");
// int pangramLength = pangramArray.Length;
// // Console.WriteLine(pangramLength);
// string[] pangramResult = new string[pangramLength];
// for (int i = 0; i < pangramLength; i++)
// {
//     char[] wordArray = pangramArray[i].ToCharArray();
//     Array.Reverse(wordArray);
//     string wordResult = String.Join("", wordArray);
//     pangramResult[i] = wordResult;
// }

// string pangramReversed = String.Join(" ", pangramResult);
// Console.WriteLine(pangramReversed);

// string pangram = "The quick brown fox jumps over the lazy dog";

// // Step 1
// string[] message = pangram.Split(' ');

// //Step 2
// string[] newMessage = new string[message.Length];

// // Step 3
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// //Step 4
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] orderArray = orderStream.Split(",");
// Array.Sort(orderArray);

// foreach (var item in orderArray)
// {
//     if (item.Length == 4)
//     {
//         Console.WriteLine(item);
//     }
//     else
//     {
//         Console.WriteLine($"{item}\t- Error");
//     }

// }

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}

// Summary

// In this module, you completed exercises using helper methods to use arrays more effectively to:

// Clear items in an array, learning the elements are set to null, using the Array.Clear()method.
// Resize an array to add and remove elements using the Array.Resize() method.
// Convert a string into an array using String.Split() specifying a string separator character to produce a value in the returned array.
// Combine all of the elements of an array into a single string using the String.Join() method.
// The array helper methods allowed you to work flexibly with data in the applications. Without these features, arrays would be less useful.