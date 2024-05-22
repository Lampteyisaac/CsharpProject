Console.WriteLine("\t\tWelcome to the Guess Game!\n");
Console.WriteLine("Enter Your Name to Register: ");
var GameName = Console.ReadLine();

List<string> names = new List<string> { "Alice", "Bob", "Charlie", "Dave", "Eve" };
string? userName = null;

while (true)
{
    Console.Write("Make make your Guess: ");
    
    userName = Console.ReadLine();
    
    if (!string.IsNullOrEmpty(userName) && names.Contains(userName))
    {
        // Display the user's name if it exists in the list
        Console.WriteLine($"Wow you are amazing\nYou won! {GameName}");
        break; // Exit the loop
    }
    else
    {
        // Inform the user that the name is not in the list or that input is invalid
        Console.WriteLine("Sorry!. Guess again.");
    }
}
