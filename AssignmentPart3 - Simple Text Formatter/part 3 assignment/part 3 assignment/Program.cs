// Prompt the user to enter a string
Console.WriteLine("Enter a string: ");

// Read the user's input
string usersString = Console.ReadLine();

// Convert the string to a character array for reversal. 
char[] usersCharArray = usersString.ToCharArray();
// Reverse the character array
Array.Reverse(usersCharArray);
// Join the reversed characters into a new string.
string reversedString = String.Join("", usersCharArray);

// Print the original string, its uppercase version, the reversed string,
// and the string with spaces replaced by underscores
Console.WriteLine($"String: {usersString} Uppercase: {usersString.ToUpper()} Reversed: {reversedString} Spaces Replaced: {usersString.Replace(' ','_')}");
