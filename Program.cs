namespace Activity12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader inputFile; // Create a Streamreader variable
            string stringFromFile = ""; // String to hold all the words in the file
            string tempWord = ""; // Temporary variable to store each word found
            int wordCount = 0; // Count the number of words found

            // Open the file
            inputFile = File.OpenText("input.txt");

            // Loop through file until the end
            while (!inputFile.EndOfStream)
            {
                // Get the string from the file
                stringFromFile = inputFile.ReadLine();
            }

            // Loop through the string characters
            for (int index = 0; index < stringFromFile.Length; index++)
            {
                // Check if the character is a non alphanumeric value
                if (stringFromFile[index] == ',' || stringFromFile[index] == '.' || stringFromFile[index] == '!' ||
                    stringFromFile[index] == '?' || stringFromFile[index] == '"' || stringFromFile[index] == ' ')
                {
                    // Check if the length of the word is greater than 0
                    if (tempWord.Length > 0)
                    {
                        // Check if the word ends with e or t
                        if (tempWord[tempWord.Length - 1] == 'e' || tempWord[tempWord.Length - 1] == 't')
                        {
                            // Increment the word count
                            wordCount++;
                        }
                    }
                    
                    // Clear the temporary word variable
                    tempWord = "";
                }
                else
                {
                    // Add the character to the temporary word variable
                    tempWord += stringFromFile[index];
                }
            }

            // Write the number of word to the console
            Console.WriteLine("There are " + wordCount + " words that end in t or e");
        }
    }
}