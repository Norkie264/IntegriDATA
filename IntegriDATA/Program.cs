using System;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;

namespace IntegriDATA
{
    class Program
    {
        static void Main(string[] args)
        {
            var run = true;
            var alphabet = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            while (run)
            {
                //Ask user to input text
                Console.WriteLine("Input text to be processed.");
                var inputString = Console.ReadLine();

                var stringToParse = inputString.ToLower();

                //Process the text
                var totalCount = processText(stringToParse);

                //Output the total letter count
                Console.WriteLine("The text has been processed. Total letters counted: " + totalCount);

                //Ask user if they want to continue
                Console.WriteLine("Would you like to process more text? Y/N");
                var continueInput = Console.ReadLine();
                run = continueInput.ToLower() == "y";
            }

            Console.WriteLine("Goodbye");

            int processText(string stringToParse)
            {
                var totalCount = 0;
                //Itterate over letters of the alphabet 
                Parallel.ForEach(alphabet, (letter) =>
                {
                    var letterCount = 0;
                    //Compare each character to the current letter and count
                    foreach (var c in stringToParse)
                    {
                        if (c == letter)
                        {
                            totalCount++;
                            letterCount++;
                        }
                    }
                    //Output each letters count
                    Console.WriteLine(letter + ": " + letterCount);
                });
                return totalCount;
            }
        }
    }
}
